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
	public partial class LoginForm : Form
	{
		#region Constructors
		public LoginForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Controls Behaviours

		/// <summary>
		/// Basic login function comparing the entered credentials with the database entries of known users
		/// </summary>
		/// <param name="sender">L'element qui appelle la fonction</param>
		/// <param name="e">L'evenement qui declenche la fonction</param>
		private void loginButton_Click(object sender, EventArgs e)
		{
			// Try to fetch a match in the DB
			var currentUser = new fdtDataSetTableAdapters.EmployesTableAdapter().GetDataByLogin(idTextBox.Text, pwdTextBox.Text).FirstOrDefault();

			if (currentUser != null )
			{
				// Set th ecurrent user profile
				CurrentUser.fullName = currentUser.fname + " " + currentUser.lname;
				CurrentUser.id = currentUser.empId.ToString();
				CurrentUser.role = currentUser.job;

				// Clear the form
				idTextBox.Text = String.Empty;
				pwdTextBox.Text = String.Empty;
				idTextBox.Focus();

				// Launch the main form
				MainScreen mainScreen = new MainScreen(this);
				mainScreen.Show();

				this.Hide();
			}
			else
			{
				// The login failed, try again
				MessageBox.Show("Identifiant / Mot de passe invalide", "System.Login");
				pwdTextBox.Text = String.Empty;
			}
		}

		#endregion
	}
}
