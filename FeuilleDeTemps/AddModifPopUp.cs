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
	public partial class AddModifPopUp : Form
	{
		#region Private members
		private String projetId;
		private DateTime workDate;
		private String empId;
		private String modifDate;
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
			this.empId = CurrentUser.id;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today.ToLongDateString();
			this.modifBy = CurrentUser.id;

			this.mode = "ADD";
		}

		public AddModifPopUp(MainScreen mainScreen, String projetId, DateTime workDate)
		{
			InitializeComponent();
			
			// Set the query parameters to the values passed by the MainScreen
			this.projetId = projetId;
			this.workDate = workDate;
			this.empId = CurrentUser.id;


			// Lock the controls that should not be modified
			AddModifProjetIdComboBox.Enabled = false;
			AddModifEmpIdComboBox.Enabled = false;
			AddModifStartDatePicker.Enabled = false;

			// Set the work date currently in the selected row
			AddModifStartDatePicker.Value = this.workDate;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today.ToLongDateString();
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
				this.empId = "%";
			}	
			else
			{
				// Stops normal employees from selecting another id
				AddModifEmpIdComboBox.Enabled = false;
			}
			// TODO: This line of code loads data into the 'fdtDataSet.Employes' table. You can move, or remove it, as needed.
			this.employesTableAdapter.FillByUser(this.fdtDataSet.Employes, this.empId);
			// TODO: This line of code loads data into the 'fdtDataSet.Projets' table. You can move, or remove it, as needed.
			this.projetsTableAdapter.FillByProjetId(this.fdtDataSet.Projets, this.projetId);
		}
		#endregion
		#region Controls Behaviours
		/// <summary>
		/// Sets the min and max dates of the date picker according to the project selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifProjetIdComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			// This function throws an exception when the form closes since the index changes
			// but the control is already cleaned up before it sends it's updated index.
			try
			{
				var projInfos = projetsTableAdapter.GetDataByProjet(AddModifProjetIdComboBox.Text).FirstOrDefault();
				// WARNING: Min date and max date need to be reset to their true min and max before
				// re-assigning a new min and max, otherwise the min sometimes gets (temporarily) set
				// at a date later than the current max and vice-versa

				// Reset the min / max to their default
				AddModifStartDatePicker.MinDate = DateTimePicker.MinimumDateTime;
				AddModifStartDatePicker.MaxDate = DateTimePicker.MaximumDateTime;

				// Set the new value / min / max
				AddModifStartDatePicker.Value = Convert.ToDateTime(projInfos["debut"]);
				AddModifStartDatePicker.MinDate = Convert.ToDateTime(projInfos["debut"]);

				// The database contains the value NULL when the project is not yet closed
				try
				{
					AddModifStartDatePicker.MaxDate = Convert.ToDateTime(projInfos["fin"]);
				}
				catch (System.InvalidCastException)
				{
					AddModifStartDatePicker.MaxDate = DateTime.Today;
				}
			}
			catch (System.NullReferenceException)
			{
				// Nothing here, we just let the form close
			}
		}

		/// <summary>
		/// Additionnal behaviour when the form closes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddModifPopUp_FormClosed(object sender, FormClosedEventArgs e)
		{
			mainScreen.Enabled = true;
		}
		#endregion
	}
}
