﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FeuilleDeTemps
{
	public partial class AddPopUp : FeuilleDeTemps.AddModifPopUp
	{
		public AddPopUp()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Constructor for the "add" action with a reference to the calling form
		/// </summary>
		/// <param name="mainScreen">The calling form</param>
		public AddPopUp(MainScreen mainScreen)
		{
			InitializeComponent();

			this.mainScreen = mainScreen;

			// Set the query parameters to their default
			this.projetId = "%";
			this.currentUserId = CurrentUser.id;
			this.originalEmpId = CurrentUser.id;

			// Set the last modification date and modified by fields to their new values
			this.modifDate = DateTime.Today;
			this.modifBy = CurrentUser.id;
		}

		public override void AddModifPopUp_Load(object sender, EventArgs e)
		{
			base.AddModifPopUp_Load(sender, e);

			// Load the available users selection for the combo box according to context
			this.employesTableAdapter.FillByUser(this.fdtDataSet.Employes, this.currentUserId);
		}

		/// <summary>
		/// Does an insert or an update, depending on the context,
		/// with the current query parameters
		/// </summary>
		public override void InsertOrUpdate()
		{
			try
			{
				mainScreen.horodateurTableAdapter.Insert(
					this.projetId,
					this.currentUserId,
					this.workDate,
					this.hours,
					this.minutes,
					this.submitted,
					this.modifDate,
					this.modifBy
				);
			}
			// The db will throw an error if there is already an entry for the
			// PK (projetId, empId, journee)
			catch (System.Data.SqlClient.SqlException)
			{
				MessageBox.Show($"Erreur: L'horodateur contient déjà une entrée avec les informations suivantes: Projet: {this.projetId} Employé: {this.originalEmpId} Date: {this.workDate.ToLongDateString()}", "System.Horodateur");
			}
		}
	}
}
