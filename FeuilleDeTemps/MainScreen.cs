using System;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class MainScreen : Form
	{
		#region Private Members
		/// <summary>
		/// Refference to the caller form in order to return to it after logout
		/// </summary>
		private LoginForm loginForm;

		// Private 
		private String currentSearchProjId;
		private String currentSearchEmpId;
		private String currentSearchStartDate;
		private String currentSearchEndDate;
		#endregion
		#region Constructor
		/// <summary>
		/// MainScreen Constructor
		/// </summary>
		/// <param name="loginForm">The instance of the (hidden) login form to return to</param>
		public MainScreen(LoginForm loginForm)
		{
			InitializeComponent();
			this.loginForm = loginForm;
		}
		#endregion
		#region On Load
		private void MainScreen_Load(object sender, EventArgs e)
		{
			// Loads the employes ids for the empId filter and sets checkboxes to their default state
			if (CurrentUser.IsAdmin())
			{
				// Admins can see every employees punch time
				this.employesTableAdapter.Fill(this.fdtDataSet1.Employes);
			}
			else
			{
				// Normal users can only see their own punch time
				this.employesTableAdapter.FillByUser(this.fdtDataSet1.Employes, CurrentUser.id);
				SearchEmpIdCheckBox.Checked = true;
				SearchEmpIdCheckBox.Enabled = false;
				SearchEmpIdComboBox.Enabled = false;
			}

			// Loads the existing project Ids for the Project Id filter
			this.projetsTableAdapter.Fill(this.fdtDataSet1.Projets);

			// Set the default query parameters and controls
			this.DefaultSearchParams();

			// Get all the existing unsubmitted punch clock data for the current user (unless admin)
			LaunchSearch(AddDeleteTabPage);

			// Get all the existing unsubmitted punch clock data for the current user (unless admin)
			LaunchSearch(HistTabPage);
		}
		#endregion
		#region Controls Behaviours

		/// <summary>
		/// Returns the user to the login form, resets the current user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LogoutButton_Click(object sender, EventArgs e)
		{
			// TODO: Prompt to save or submit unsaved entries
			this.Close();
		}

		/// <summary>
		/// Launches the search using the values that have their associated checkbox checked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchButton_Click(object sender, EventArgs e)
		{
			this.currentSearchProjId = SearchProjetIdCheckBox.Checked ? SearchProjetIdComboBox.Text : "%";
			this.currentSearchEmpId = SearchEmpIdCheckBox.Checked ? SearchEmpIdComboBox.Text : "%";
			this.currentSearchStartDate = SearchStartDateCheckBox.Checked ? SearchStartDatePicker.Text : "1999-01-01";
			this.currentSearchEndDate = SearchEndDateCheckBox.Checked ? SearchEndDatePicker.Text : DateTime.Today.ToLongDateString();

			LaunchSearch(MainScreenTabControl.SelectedTab);
		}

		/// <summary>
		/// Resets the filters and launches a search with the default values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HistResetButton_Click(object sender, EventArgs e)
		{
			DefaultSearchParams();
			LaunchSearch(MainScreenTabControl.SelectedTab);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			AddModifPopUp addPopUp = new AddModifPopUp(this);
			addPopUp.Show();
			this.Enabled = false;
		}

		private void ModifyButton_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRows = AddModifDGV.SelectedRows;

			// Reverse the counter since the first item in the selected collection is the last
			// one selected by the user. In short, for the UX.
			for (int i = selectedRows.Count - 1; i >= 0; i--)
			{
				DataGridViewCellCollection currentCells = selectedRows[i].Cells;
				AddModifPopUp addPopUp = new AddModifPopUp(
					this,
					currentCells[0].Value.ToString(), 
					Convert.ToDateTime(currentCells[2].Value)
				);
				addPopUp.Show();
				this.Enabled = false;
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			// TODO: Create a dialog box that shows what will be deleted and asks to confirm the deletion.
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			// TODO: Create a dialog box that shows what will be submitted and asks to confirm the submission
		}

		/// <summary>
		/// Custom behaviour when closing the form: logout user, return to login form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			CurrentUser.Logout();
			this.loginForm.Show();
		}
		#endregion
		#region Helper Methods
		/// <summary>
		/// Reset the default values (different for admin) in the search fields, launches the search with the default values.
		/// </summary>
		private void DefaultSearchParams()
		{
			// Reset the query parameters
			this.currentSearchProjId = "%";
			this.currentSearchEmpId = CurrentUser.IsAdmin() ? "%" : CurrentUser.id;
			this.currentSearchStartDate = "1999-01-01";
			this.currentSearchEndDate = DateTime.Today.ToLongDateString();			

			// Reset the search controls values
			SearchProjetIdComboBox.SelectedIndex = 0;
			SearchStartDatePicker.Value = DateTime.Today;
			SearchEndDatePicker.Value = DateTime.Today;
			SearchEmpIdComboBox.SelectedIndex = 0;

			// Reset the checkbox states
			SearchProjetIdCheckBox.Checked = false;
			SearchStartDateCheckBox.Checked = false;
			SearchEndDateCheckBox.Checked = false;
			SearchEmpIdCheckBox.Checked = !CurrentUser.IsAdmin();
		}

		/// <summary>
		/// Launches the query with the current search filters into the right tab
		/// </summary>
		private void LaunchSearch(TabPage activeTab)
		{
			// TOOD: This repetition can be dealt with by implementing the LaunchSearch method in
			// each tab's respective class.
			if (activeTab.Name == "AddDeleteTabPage")
			{
				this.horodateurTableAdapter.FillByFilter(
					this.fdtDataSet1.Horodateur,
					this.currentSearchEmpId,
					this.currentSearchProjId,
					this.currentSearchStartDate,
					this.currentSearchEndDate
				);
			}
			else if (activeTab.Name == "HistTabPage")
			{
				this.entreesHeuresTableAdapter.FillByFilter(
					this.fdtDataSet1.EntreesHeures,
					this.currentSearchEmpId,
					this.currentSearchProjId,
					this.currentSearchStartDate,
					this.currentSearchEndDate
				);
			}
		}
		#endregion

		
	}
}
