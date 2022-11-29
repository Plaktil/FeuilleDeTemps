using System;
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

		public MainScreen(LoginForm loginForm)
		{
			InitializeComponent();
			this.loginForm = loginForm;
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'fdtDataSet1.Projets' table. You can move, or remove it, as needed.
			this.projetsTableAdapter.Fill(this.fdtDataSet1.Projets);
			// TODO: This line of code loads data into the 'fdtDataSet1.Employes' table. You can move, or remove it, as needed.
			this.entreesHeuresTableAdapter.FillByUser(this.fdtDataSet1.EntreesHeures, CurrentUser.id);
		}

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
	}
}
