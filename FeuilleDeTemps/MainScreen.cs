using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class MainScreen : Form
	{
		#region Private Members
		// Refference to the caller form in order to return to it after logout
		private LoginForm loginForm;

		private String currentSearchProjId;
		private String currentSearchEmpId;
		private String currentSearchStartDate;
		private String currentSearchEndDate;
		private AddModifPopUp[] pendingPopUps;
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

			// Allows delete button to call popUpHandler to refresh the search results
			this.pendingPopUps = new AddModifPopUp[0];
		}
		#endregion
		#region On Load
		/// <summary>
		/// Loads DGVs and other controls dependent on the user privileges and IDs
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainScreen_Load(object sender, EventArgs e)
		{
			//Greets the user
			WelcomeLabel.Text = $"Bonjour {CurrentUser.fullName}";
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
			LaunchSearch(AddModifTabPage);

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
			this.Close();
		}

		/// <summary>
		/// Launches the search using the values that have their associated checkbox checked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void SearchButton_Click(object sender, EventArgs e)
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

		/// <summary>
		/// Opens a form to create a new work entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			AddModifPopUp addPopUp = new AddModifPopUp(this);
			this.pendingPopUps = new AddModifPopUp[1];
			this.pendingPopUps[0] = addPopUp;
			popUpHandler();
		}

		/// <summary>
		/// Opens a form(s) to modify the time values entered in the selected row(s)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModifyButton_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRows = AddModifDGV.SelectedRows;

			// Create a list of popups for the selected rows
			this.pendingPopUps = new AddModifPopUp[selectedRows.Count];

			for (int i = 0; i < selectedRows.Count; i++)
			{
				// TODO: Find out how to get the cells by column name to de-obfuscate code
				// Instantiate the popups and store them in the array
				DataGridViewCellCollection currentCells = selectedRows[i].Cells;
				AddModifPopUp addModifPopUp = new AddModifPopUp(
					this,
					// projetId
					currentCells[0].Value.ToString(), 
					// empId
					currentCells[1].Value.ToString(),
					// journee
					Convert.ToDateTime(currentCells[2].Value)
				);
				this.pendingPopUps[i] = addModifPopUp;
			}

			// Lock the screen while the popups are dealt with by the user
			this.Enabled = false;

			// Call the PopUps handler to serve them one by one
			popUpHandler();
		}

		/// <summary>
		/// Opens a dialog box asking the user to confirm deletion of the selected rows, 
		/// then deletes them from the DB
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRows = AddModifDGV.SelectedRows;
			if (selectedRows.Count > 0)
			{
				var dialogResult = MessageBox.Show("Voulez vous vraiment supprimer les entrées sélectionnées?", "System.Horodateur", MessageBoxButtons.OKCancel);

				if (dialogResult.ToString() == "OK")
				{
					// TODO: Find out how to get the cells by column name to de-obfuscate code
					// Deletion all the selected rows
					for (int i = selectedRows.Count - 1; i >= 0; i--)
					{
						DataGridViewCellCollection currentCells = selectedRows[i].Cells;
						horodateurTableAdapter.DeleteByPK(
							currentCells[0].Value.ToString(),
							currentCells[1].Value.ToString(),
							currentCells[2].Value.ToString()
						);
					}
				}
			}
			// Since the popup array is empty, will refresh the DGV
			popUpHandler();
		}

		/// <summary>
		/// Opens a dialog box asking the user to confirm submission of the selected rows, 
		/// then submits all selected opened punch clock entries
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SubmitButton_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRows = AddModifDGV.SelectedRows;
			if (selectedRows.Count > 0)
			{
				var dialogResult = MessageBox.Show("Voulez vous vraiment soumettre les entrées sélectionnées?", "System.Horodateur", MessageBoxButtons.OKCancel);

				if (dialogResult.ToString() == "OK")
				{
					// TODO: Find out how to get the cells by column name to de-obfuscate code
					// Updates the "soumis" field of every selected entry
					for (int i = 0; i < selectedRows.Count; i++)
					{
						DataGridViewCellCollection currentCells = selectedRows[i].Cells;
						horodateurTableAdapter.UpdateSoumisByPK(
							true,
							currentCells[0].Value.ToString(),
							currentCells[1].Value.ToString(),
							currentCells[2].Value.ToString()
						);
					}
				}
			}
			// Since the popup array is empty, will refresh the DGV
			popUpHandler();
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
		/// Reset the default values (different for admin) in the search fields,
		/// launches the search with the default values.
		/// </summary>
		private void DefaultSearchParams()
		{
			// Reset the query parameters
			this.currentSearchProjId = "%";
			this.currentSearchEmpId = CurrentUser.IsAdmin() ? "%" : CurrentUser.id;
			this.currentSearchStartDate = DateTime.Today.AddDays(-7).ToLongDateString();
			this.currentSearchEndDate = DateTime.Today.ToLongDateString();			

			// Reset the search controls values
			SearchProjetIdComboBox.SelectedIndex = 0;
			SearchStartDatePicker.Value = DateTime.Today.AddDays(-7);
			SearchEndDatePicker.Value = DateTime.Today;
			SearchEmpIdComboBox.SelectedIndex = 0;

			// Reset the checkbox states
			SearchProjetIdCheckBox.Checked = false;
			SearchStartDateCheckBox.Checked = true;
			SearchEndDateCheckBox.Checked = true;
			SearchEmpIdCheckBox.Checked = !CurrentUser.IsAdmin();
		}

		/// <summary>
		/// Launches the query with the current search filters into the specified tab
		/// </summary>
		private void LaunchSearch(TabPage targetTab)
		{
			// TOOD: This repetition can be dealt with by implementing the LaunchSearch method in
			// each tab's respective class.
			if (targetTab.Name == "AddModifTabPage")
			{
				this.horodateurTableAdapter.FillByFilter(
					this.fdtDataSet1.Horodateur,
					this.currentSearchEmpId,
					this.currentSearchProjId,
					this.currentSearchStartDate,
					this.currentSearchEndDate
				);
			}
			else if (targetTab.Name == "HistTabPage")
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

		/// <summary>
		/// Allows the addModifPopUp to be shown one by one. In the end, refreshes the DGV
		/// in both tabs and re-enables the main form.
		/// </summary>
		public void popUpHandler()
		{
			if (pendingPopUps.Length > 0)
			{
				// Show the next window
				// Last in the array since the last selected item is first in the array
				this.pendingPopUps[this.pendingPopUps.Length - 1].Show();

				// Remove the shown window from the pending array
				AddModifPopUp[] tmpArray = new AddModifPopUp[this.pendingPopUps.Length - 1];
				Array.Copy(this.pendingPopUps, 0, tmpArray, 0, tmpArray.Length);
				this.pendingPopUps = tmpArray;

			}
			else
			{
				// When they are all processed, re-enable the MainScreen.
				this.Enabled = true;
				// Refresh the search results in each tabs using the current filters
				LaunchSearch(HistTabPage);
				LaunchSearch(AddModifTabPage);
			}
		}
		#endregion
	}
}
