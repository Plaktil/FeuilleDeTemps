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
		private String projId;
		private String workDate;
		private String empId;
		private int hours;
		private int minutes;
		private String modifDate;
		private String modifBy;
		private String mode;

		public AddModifPopUp()
		{
			InitializeComponent();

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today.ToLongDateString();
			this.modifBy = CurrentUser.id;
			this.mode = "ADD";
		}

		public AddModifPopUp(String projId, String workDate, String empId, int hours, int minutes)
		{
			InitializeComponent();
			
			// Set the query parameters to the values passed by the MainScreen
			this.projId = projId;
			this.workDate = workDate;
			this.empId = empId;
			this.hours = hours;
			this.minutes = minutes;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today.ToLongDateString();
			this.modifBy = CurrentUser.id;

			this.mode = "MODIFY";
		}

	}
}
