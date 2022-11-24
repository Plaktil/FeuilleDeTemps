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
	public partial class MainScreen : Form
	{
		public MainScreen()
		{
			InitializeComponent();
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{
			this.employesTableAdapter.FillById(employesDataSet.Employes, CurrentUser.id);
		}

		private void Menu1_Click(object sender, EventArgs e)
		{
			this.employesTableAdapter.FillById(employesDataSet.Employes, CurrentUser.id);
		}

		private void Menu2_Click(object sender, EventArgs e)
		{
			this.employesTableAdapter.Fill(employesDataSet.Employes);
		}

		private void Menu3_Click(object sender, EventArgs e)
		{
			this.employesTableAdapter.Delete("00008", "dsa", "asd", "dsd", "819-888-8888", "blah");
		}
	}
}
