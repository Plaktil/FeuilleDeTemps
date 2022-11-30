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
				this.employesTableAdapter.FillByCurrentUser(this.fdtDataSet1.Employes, CurrentUser.id);
				HistEmpIdCheckBox.Checked = true;
				HistEmpIdCheckBox.Enabled = false;
				HistEmpIdComboBox.Enabled = false;
			}

			// Loads the existing project Ids for the Project Id filter
			this.projetsTableAdapter.Fill(this.fdtDataSet1.Projets);

			// Get all the existing punch clock data for the current user (unless admin)
			this.DefaultSearchParams();
			LaunchSearch();
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
		/// Does the same work when the user closes the form as when he logs out.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			CurrentUser.Logout();
			this.loginForm.Show();
		}

		/// <summary>
		/// Launches the search using the values that have their associated checkbox checked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HistSearchButton_Click(object sender, EventArgs e)
		{
			this.currentSearchProjId = HistProjetIdCheckBox.Checked ? HistProjetIdComboBox.Text : "%";
			this.currentSearchEmpId = HistEmpIdCheckBox.Checked ? HistEmpIdComboBox.Text : "%";
			this.currentSearchStartDate = HistStartDateCheckBox.Checked ? HistStartDatePicker.Text : "1999-01-01";
			this.currentSearchEndDate = HistEndDateCheckBox.Checked ? HistEndDatePicker.Text : DateTime.Today.ToLongDateString();

			LaunchSearch();
		}

		/// <summary>
		/// Resets the filters and launches a search with the default values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HistResetButton_Click(object sender, EventArgs e)
		{
			DefaultSearchParams();
			LaunchSearch();
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

			// Reset the controls values
			HistProjetIdComboBox.SelectedIndex = 0;
			HistStartDatePicker.Value = DateTime.Today;
			HistEndDatePicker.Value = DateTime.Today;
			HistEmpIdComboBox.SelectedIndex = 0;

			// Reset the checkbox states
			HistProjetIdCheckBox.Checked = false;
			HistStartDateCheckBox.Checked = false;
			HistEndDateCheckBox.Checked = false;
			HistEmpIdCheckBox.Checked = !CurrentUser.IsAdmin();
		}

		/// <summary>
		/// Launches the query with the current search filters
		/// </summary>
		private void LaunchSearch()
		{
			String activeTab = MainScreenTabControl.SelectedTab.Name;
			if (activeTab == "AddDeleteTabPage")
			{
				this.horodateurTableAdapter.FillByFilter(
					this.fdtDataSet1.Horodateur,
					this.currentSearchEmpId,
					this.currentSearchProjId,
					this.currentSearchStartDate,
					this.currentSearchEndDate
				);
			}
			else if (activeTab == "HistTabPage")
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
