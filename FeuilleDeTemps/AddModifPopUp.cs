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
		protected private String projetId;
		protected private DateTime workDate;
		protected private String currentUserId;
		protected private String originalEmpId;
		protected private int hours;
		protected private int minutes;
		protected private bool submitted;
		protected private DateTime modifDate;
		protected private String modifBy;
		protected private MainScreen mainScreen;
		#endregion
		#region Constructors
		/// <summary>
		/// Empty constructor for the Designer tool
		/// </summary>
		public AddModifPopUp()
		{
			InitializeComponent();
		}
		#endregion
		#region On Load
		/// <summary>
		/// Set the interface according to the context and the privilege 
		/// level of the current user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		virtual public void AddModifPopUp_Load(object sender, EventArgs e)
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
		protected private void AddModifProjetIdComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			// Fetch the row for the currently selected project
			var projInfos = projetsTableAdapter.GetDataByProjet(AddModifProjetIdComboBox.Text).FirstOrDefault();

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

		/// <summary>
		/// Calls the main screen's popup handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected private void AddModifPopUp_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainScreen.popUpHandler();
		}

		/// <summary>
		/// Save the current entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected private void SaveButton_Click(object sender, EventArgs e)
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
		protected private void SaveAndSubmitButton_Click(object sender, EventArgs e)
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
		protected private void AddModifCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		#region Helper Methods
		/// <summary>
		/// Sets the query parameters to the values in the input fields
		/// </summary>
		protected private void GetUserInputParameters()
		{
			this.projetId = AddModifProjetIdComboBox.Text;
			this.currentUserId = AddModifEmpIdComboBox.Text;
			this.workDate = AddModifDatePicker.Value;
			this.hours = Convert.ToInt32(AddModifHoursComboBox.Text);
			this.minutes = Convert.ToInt32(AddModifMinutesComboBox.Text);
		}

		/// <summary>
		/// Does an insert or an update, depending on the context,
		/// with the current query parameters
		/// </summary>
		public virtual void InsertOrUpdate()
		{
			throw new Exception("This method needs to be overriden");
		}
		/// <summary>
		/// Stops the user from typing a date in the date picker
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected private void AddModifDatePicker_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true; 
			e.Handled = true;
		}
		#endregion

	}
}
