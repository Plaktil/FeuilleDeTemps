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
		private MainScreen mainScreen;
		#endregion
		#region Constructors
		/// <summary>
		/// Constructor for the "add" action with a reference to the calling form
		/// </summary>
		/// <param name="mainScreen">The calling form</param>
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

		/// <summary>
		/// Constructor for the "modify" action with a reference to the calling form
		/// </summary>
		/// <param name="mainScreen">The calling form</param>
		/// <param name="projetId">The selected row's projetId</param>
		/// <param name="empId">The selected row's empId</param>
		/// <param name="workDate">The selected row's date</param>
		public AddModifPopUp(MainScreen mainScreen, String projetId, String empId, DateTime workDate)
		{
			InitializeComponent();
			
			// Set the query parameters to the values passed by the MainScreen
			this.projetId = projetId;
			this.workDate = workDate;
			this.currentUserId = empId;
			this.originalEmpId = empId;

			// Lock the controls that should not be modified (only the hours, minute should be modified)
			AddModifProjetIdComboBox.Enabled = false;
			AddModifEmpIdComboBox.Enabled = false;
			AddModifDatePicker.Enabled = false;

			// Set the date picker to the selected row's value
			AddModifDatePicker.Value = this.workDate;

			// Set the last modification date and modified by query parameters to their new values
			this.modifDate = DateTime.Today;
			this.modifBy = CurrentUser.id;

			this.mainScreen = mainScreen;

			this.mode = "MODIFY";
		}
		#endregion
		#region On Load
		/// <summary>
		/// Set the interface according to the context and the privilege 
		/// level of the current user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

			// Set hours and minutes to default values (otherwise "", causes error
			// when unchanged by the user)
			AddModifHoursComboBox.SelectedIndex= 0;
			AddModifMinutesComboBox.SelectedIndex= 0;

			// Load the existing projects selection for the combo box
			this.projetsTableAdapter.FillByProjetId(this.fdtDataSet.Projets, this.projetId);

			// Trigger the selected index changed to set the min / max dates
			AddModifProjetIdComboBox_SelectedIndexChanged(sender, e);
		}
		#endregion
		#region Controls Behaviours
		/// <summary>
		/// Sets the min and max dates of the date picker according to the selected project's
		/// begin and end dates.
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

				// This function throws an exception when the form closes because the text value in
				// the combo box is now null, therefore the fetch returns null.
				if (projInfos != null)
				{
					// Set the new value / min / max
					AddModifDatePicker.Value = Convert.ToDateTime(projInfos["debut"]);
					AddModifDatePicker.MinDate = Convert.ToDateTime(projInfos["debut"]);

					// The database contains the value NULL when the project is not yet closed
					if (projInfos["fin"].ToString() != String.Empty)
					{
						AddModifDatePicker.MaxDate = Convert.ToDateTime(projInfos["fin"]);
					}
					else
					{
						AddModifDatePicker.MaxDate = DateTime.Today;
					}
				}
			}
		}

		/// <summary>
		/// Calls the main screen's popup handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifPopUp_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainScreen.popUpHandler();
		}

		/// <summary>
		/// Save the current entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Save and submit the current entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Simply close the form without saving any modifications
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		#region Helper Methods
		/// <summary>
		/// Sets the query parameters to the values in the input fields
		/// </summary>
		private void GetUserInputParameters()
		{
			this.projetId = AddModifProjetIdComboBox.Text;
			this.currentUserId = AddModifEmpIdComboBox.Text;
			this.workDate = AddModifDatePicker.Value;
			this.hours = Convert.ToInt32(AddModifHoursComboBox.Text);
			this.minutes = Convert.ToInt32(AddModifMinutesComboBox.Text);
		}

		/// <summary>
		/// Does an insert or an update, dependin on the context,
		/// with the current query parameters
		/// </summary>
		private void InsertOrUpdate()
		{
			
			if (this.mode == "ADD")
			{
				try
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
				// The db will throw an error if there is already an entry for the
				// PK (projetId, empId, journee)
				catch (System.Data.SqlClient.SqlException)
				{
					MessageBox.Show($"Erreur: L'horodateur contient déjà une entrée avec les informations suivantes: Projet: {this.projetId} Employé: {this.originalEmpId} Date: {this.workDate.ToLongDateString()}", "System.Horodateur");
				}
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
		/// <summary>
		/// Stops the user from typing a date in the date picker
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
