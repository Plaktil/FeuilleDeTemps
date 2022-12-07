using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class ModifPopUp : FeuilleDeTemps.AddModifPopUp
	{
		public ModifPopUp()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Constructor for the "modify" action with a reference to the calling form
		/// </summary>
		/// <param name="mainScreen">The calling form</param>
		/// <param name="projetId">The selected row's projetId</param>
		/// <param name="empId">The selected row's empId</param>
		/// <param name="workDate">The selected row's date</param>
		public ModifPopUp(MainScreen mainScreen, String projetId, String empId, DateTime workDate)
		{
			InitializeComponent();

			// Set the query parameters to the values passed by the MainScreen
			this.projetId = projetId;
			this.workDate = workDate;
			this.currentUserId = empId;
			this.originalEmpId = empId;

			// Lock the controls that should not be modified (only the hours, minute should be modified)
			AddModifProjetIdComboBox.Enabled = false;
			AddModifEmpIdComboBox.Enabled = false;
			AddModifDatePicker.Enabled = false;

			// Set the date picker to the selected row's value
			AddModifDatePicker.Value = this.workDate;

			// Set the last modification date and modified by query parameters to their new values
			this.modifDate = DateTime.Today;
			this.modifBy = CurrentUser.id;

			this.mainScreen = mainScreen;
		}

		public override void AddModifPopUp_Load(object sender, EventArgs e)
		{
			base.AddModifPopUp_Load(sender, e);

			// Load the available users selection for the combo box according to context
			this.employesTableAdapter.FillByUser(this.fdtDataSet.Employes, this.originalEmpId);
		}

		/// <summary>
		/// Does an insert or an update, depending on the context,
		/// with the current query parameters
		/// </summary>
		public override void InsertOrUpdate()
		{
			mainScreen.horodateurTableAdapter.UpdateByPK(
				this.hours,
				this.minutes,
				this.submitted,
				this.modifDate.ToLongDateString(),
				this.modifBy,
				this.projetId,
				this.originalEmpId,
				this.workDate.ToLongDateString()
			);
		}
	}
}
