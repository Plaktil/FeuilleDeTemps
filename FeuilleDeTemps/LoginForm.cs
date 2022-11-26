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
		public LoginForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Fonction qui valide les informations entrees avec celles contenues dans la base de donnees apres
		/// avoir appuye sur le bouton connection
		/// </summary>
		/// <param name="sender">L'element qui appelle la fonction</param>
		/// <param name="e">L'evenement qui declenche la fonction</param>
		private void loginButton_Click(object sender, EventArgs e)
		{
			var currentUser = new fdtDataSetTableAdapters.EmployesTableAdapter().GetDataByLogin(idTextBox.Text, pwdTextBox.Text).FirstOrDefault();

			if (currentUser != null )
			{
				CurrentUser.fullName = currentUser.fname + " " + currentUser.lname;
				CurrentUser.id = currentUser.empId.ToString();
				CurrentUser.role = currentUser.job;

				MessageBox.Show($"Bienvenue {CurrentUser.fullName} -- {CurrentUser.id}");

				MainScreen mainScreen = new MainScreen();
				mainScreen.Show();

				this.Hide(); // Ne pas oublier de fermer cette fenetre quand on quitte l'application
			}
			else
			{
				MessageBox.Show("Identifiant / Mot de passe invalide", "System.Login");
			}
		}
	}
}
