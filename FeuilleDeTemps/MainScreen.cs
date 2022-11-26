using System;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			InitializeComponent();
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'fdtDataSet1.EntreesHeures' table. You can move, or remove it, as needed.
			this.entreesHeuresTableAdapter.FillByCurrentUser(fdtDataSet.EntreesHeures, CurrentUser.id);
		}
	}
}
