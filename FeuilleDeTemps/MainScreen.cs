using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class MainScreen : Form
	{
		/// <summary>
		/// Refference to the caller form in order to return to it after logout
		/// </summary>
		private LoginForm loginForm;

		// Private 
		private String currentSearchProjId;
		private String currentSearchUserId;
		private String currentSearchStartDate;
		private String currentSearchEndDate;

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
			// Loads the existing project Ids for the Project Id filter
			this.projetsTableAdapter.Fill(this.fdtDataSet1.Projets);

			// On load, gets all the existing data for the current user
			this.DefaultSearchParams();
			this.entreesHeuresTableAdapter.FillByFilter(this.fdtDataSet1.EntreesHeures, this.currentSearchUserId, this.currentSearchProjId, this.currentSearchStartDate, this.currentSearchEndDate);
		}
		#endregion
		#region Controls Behaviour

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

		private void HistSearchButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"{HistProjetIdCheckBox.Checked}: {HistProjetIdComboBox.Text}");
			MessageBox.Show($"{HistStartDateCheckBox.Checked}: {HistStartDatePicker.Text}");
			MessageBox.Show($"{HistEndDateCheckBox.Checked}: {HistEndDatePicker.Text}");
			//string projId = HistProjetIdCheckBox.Checked ? HistProjetIdComboBox.Text: String.Empty;

			//this.entreesHeuresTableAdapter.FillByUser(this.fdtDataSet1.EntreesHeures, CurrentUser.id);
		}

		private void HistResetButton_Click(object sender, EventArgs e)
		{
			this.DefaultSearchParams();
			MessageBox.Show(this.currentSearchEndDate);
		}

		#endregion
		#region Helper Methods
		private void DefaultSearchParams()
		{
			this.currentSearchProjId = "%";
			this.currentSearchUserId = CurrentUser.id;
			this.currentSearchStartDate = "1999-01-01";
			this.currentSearchEndDate = DateTime.Today.AddDays(1.0).ToLongDateString();
			// TODO: set projid field, userId field to default, set dates fields to today
		}
		#endregion
	}
}
