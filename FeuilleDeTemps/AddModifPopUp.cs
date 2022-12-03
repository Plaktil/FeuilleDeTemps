using FeuilleDeTemps.fdtDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	// TOOD: This class could be split into 2 children (add and modify) to remove the 'mode' checks
	public partial class AddModifPopUp : Form
	{
		#region Private members
		private String projetId;
		private DateTime workDate;
		private String currentUserId;
		private String originalEmpId;
		private int hours;
		private int minutes;
		private bool submitted;
		private DateTime modifDate;
		private String modifBy;
		private String mode;

		MainScreen mainScreen;
		#endregion
		#region Constructors

		public AddModifPopUp(MainScreen mainScreen)
		{
			InitializeComponent();

			this.mainScreen = mainScreen;
			
			// Set the query parameters to their default
			this.projetId = "%";
			this.currentUserId = CurrentUser.id;
			this.originalEmpId = CurrentUser.id;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today;
			this.modifBy = CurrentUser.id;

			this.mode = "ADD";
		}

		public AddModifPopUp(MainScreen mainScreen, String projetId, String empId, DateTime workDate)
		{
			InitializeComponent();
			
			// Set the query parameters to the values passed by the MainScreen
			this.projetId = projetId;
			this.workDate = workDate;
			this.currentUserId = empId;
			this.originalEmpId = empId;


			// Lock the controls that should not be modified
			AddModifProjetIdComboBox.Enabled = false;
			AddModifEmpIdComboBox.Enabled = false;
			AddModifDatePicker.Enabled = false;

			// Set the work date currently in the selected row
			AddModifDatePicker.Value = this.workDate;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today;
			this.modifBy = CurrentUser.id;

			this.mainScreen = mainScreen;

			this.mode = "MODIFY";
		}
		#endregion
		#region On Load
		private void AddModifPopUp_Load(object sender, EventArgs e)
		{
			if (CurrentUser.IsAdmin())
			{
				// Allow admin to add an entry for any employee
				this.currentUserId = "%";
			}	
			else
			{
				// Stops normal employees from selecting another id
				AddModifEmpIdComboBox.Enabled = false;
			}

			// Load the available users selection for the combo box according to context
			if (this.mode == "ADD")
			{
				this.employesTableAdapter.FillByUser(this.fdtDataSet.Employes, this.currentUserId);
			}
			else if (this.mode == "MODIFY")
			{
				this.employesTableAdapter.FillByUser(this.fdtDataSet.Employes, this.originalEmpId);
			}
			// Load the available project selection for the combo box
			this.projetsTableAdapter.FillByProjetId(this.fdtDataSet.Projets, this.projetId);

			// Trigger the selected index changed
			AddModifProjetIdComboBox_SelectedIndexChanged(sender, e);
		}
		#endregion
		#region Controls Behaviours
		/// <summary>
		/// Sets the min and max dates of the date picker according to the project selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifProjetIdComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			// Fetch the row for the currently selected project
			var projInfos = projetsTableAdapter.GetDataByProjet(AddModifProjetIdComboBox.Text).FirstOrDefault();


			if (this.mode == "ADD")
			{
				// WARNING: Min date and max date need to be reset to their true min and max before
				// re-assigning a new min and max, otherwise the min sometimes gets (temporarily) set
				// at a date later than the current max and vice-versa

				// Reset the min / max to their default
				AddModifDatePicker.MinDate = DateTimePicker.MinimumDateTime;
				AddModifDatePicker.MaxDate = DateTimePicker.MaximumDateTime;

				// This function throws an exception when the form closes since the index changes
				// but the control is already cleaned up before it sends it's updated index.
				if (projInfos != null)
				{
					// Set the new value / min / max
					AddModifDatePicker.Value = Convert.ToDateTime(projInfos["debut"]);
					AddModifDatePicker.MinDate = Convert.ToDateTime(projInfos["debut"]);
					// The database contains the value NULL when the project is not yet closed
					try
					{
						AddModifDatePicker.MaxDate = Convert.ToDateTime(projInfos["fin"]);
					}
					catch (System.InvalidCastException)
					{
						AddModifDatePicker.MaxDate = DateTime.Today;
					}
				}
			}
		}

		/// <summary>
		/// Additionnal behaviour when the form closes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifPopUp_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Call the function that shows the next popup or re-enables the mainscreen
			mainScreen.popUpHandler();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			// Set query params to current user input
			GetUserInputParameters();
			// Save but not submit
			this.submitted = false;
			// Insert or update the row
			InsertOrUpdate();
			this.Close();
		}

		private void SaveAndSubmitButton_Click(object sender, EventArgs e)
		{
			// Set query params to current user input
			GetUserInputParameters();
			// Save and submit
			this.submitted = true;
			// Insert or update the row
			InsertOrUpdate();
			this.Close();
		}

		private void AddModifCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		#region Helper Methods
		private void GetUserInputParameters()
		{
			this.projetId = AddModifProjetIdComboBox.Text;
			this.currentUserId = AddModifEmpIdComboBox.Text;
			this.workDate = AddModifDatePicker.Value;
			this.hours = Convert.ToInt32(AddModifHoursComboBox.Text);
			this.minutes = Convert.ToInt32(AddModifMinutesComboBox.Text);
		}

		private void InsertOrUpdate()
		{
			try
			{
				if (this.mode == "ADD")
				{
					mainScreen.horodateurTableAdapter.Insert(
						this.projetId,
						this.currentUserId,
						this.workDate,
						this.hours,
						this.minutes,
						this.submitted,
						this.modifDate,
						this.modifBy
						);
				}
				else if (this.mode == "MODIFY")
				{
					mainScreen.horodateurTableAdapter.UpdateByPK(
						this.hours,
						this.minutes,
						this.submitted,
						this.modifDate.ToLongDateString(),
						this.modifBy,
						this.projetId,
						this.originalEmpId,
						this.workDate.ToLongDateString()
					);
				}
			}
			catch (System.Data.SqlClient.SqlException)
			{
				MessageBox.Show($"Erreur: L'horodateur contient déjà une entrée avec les informations suivantes: Projet: {this.projetId} Employé: {this.originalEmpId} Date: {this.workDate.ToLongDateString()}", "System.Horodateur");
			}
		}
		/// <summary>
		/// Blocks the user from typing a date in the date picker
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifDatePicker_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true; 
			e.Handled = true;
		}
		#endregion

	}
}
