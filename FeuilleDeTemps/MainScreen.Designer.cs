namespace FeuilleDeTemps
{
	partial class MainScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.MainScreenTabControl = new System.Windows.Forms.TabControl();
			this.HistoriqueTabPage = new System.Windows.Forms.TabPage();
			this.entreesHeuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet1 = new FeuilleDeTemps.fdtDataSet();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.entreesHorodateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet = new FeuilleDeTemps.fdtDataSet();
			this.entreesHeuresTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EntreesHeuresTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.projetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cliNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.journeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modifParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.employesTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EmployesTableAdapter();
			this.MainScreenTabControl.SuspendLayout();
			this.HistoriqueTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHorodateurBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainScreenTabControl
			// 
			this.MainScreenTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainScreenTabControl.Controls.Add(this.HistoriqueTabPage);
			this.MainScreenTabControl.Controls.Add(this.tabPage2);
			this.MainScreenTabControl.Location = new System.Drawing.Point(12, 103);
			this.MainScreenTabControl.Name = "MainScreenTabControl";
			this.MainScreenTabControl.SelectedIndex = 0;
			this.MainScreenTabControl.Size = new System.Drawing.Size(776, 335);
			this.MainScreenTabControl.TabIndex = 0;
			// 
			// HistoriqueTabPage
			// 
			this.HistoriqueTabPage.Controls.Add(this.dataGridView2);
			this.HistoriqueTabPage.Location = new System.Drawing.Point(4, 22);
			this.HistoriqueTabPage.Name = "HistoriqueTabPage";
			this.HistoriqueTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.HistoriqueTabPage.Size = new System.Drawing.Size(768, 309);
			this.HistoriqueTabPage.TabIndex = 0;
			this.HistoriqueTabPage.Text = "Historique";
			this.HistoriqueTabPage.UseVisualStyleBackColor = true;
			// 
			// entreesHeuresBindingSource
			// 
			this.entreesHeuresBindingSource.DataMember = "EntreesHeures";
			this.entreesHeuresBindingSource.DataSource = this.fdtDataSet1;
			// 
			// fdtDataSet1
			// 
			this.fdtDataSet1.DataSetName = "fdtDataSet";
			this.fdtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 309);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Modifier / Ajouter";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// entreesHorodateurBindingSource
			// 
			this.entreesHorodateurBindingSource.DataMember = "EntreesHorodateur";
			this.entreesHorodateurBindingSource.DataSource = this.fdtDataSet;
			// 
			// fdtDataSet
			// 
			this.fdtDataSet.DataSetName = "fdtDataSet";
			this.fdtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// entreesHeuresTableAdapter
			// 
			this.entreesHeuresTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projetIdDataGridViewTextBoxColumn,
            this.cliNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.journeeDataGridViewTextBoxColumn,
            this.heuresDataGridViewTextBoxColumn,
            this.minsDataGridViewTextBoxColumn,
            this.dateModifDataGridViewTextBoxColumn,
            this.modifParDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.entreesHeuresBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(756, 297);
			this.dataGridView2.TabIndex = 1;
			// 
			// projetIdDataGridViewTextBoxColumn
			// 
			this.projetIdDataGridViewTextBoxColumn.DataPropertyName = "projetId";
			this.projetIdDataGridViewTextBoxColumn.HeaderText = "Identifiant de projet";
			this.projetIdDataGridViewTextBoxColumn.Name = "projetIdDataGridViewTextBoxColumn";
			this.projetIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cliNameDataGridViewTextBoxColumn
			// 
			this.cliNameDataGridViewTextBoxColumn.DataPropertyName = "cliName";
			this.cliNameDataGridViewTextBoxColumn.HeaderText = "Client";
			this.cliNameDataGridViewTextBoxColumn.Name = "cliNameDataGridViewTextBoxColumn";
			this.cliNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "empId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Identifiant d\'employé";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
			this.dataGridViewTextBoxColumn2.HeaderText = "Prénom";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "lname";
			this.dataGridViewTextBoxColumn3.HeaderText = "Nom de famille";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// journeeDataGridViewTextBoxColumn
			// 
			this.journeeDataGridViewTextBoxColumn.DataPropertyName = "journee";
			this.journeeDataGridViewTextBoxColumn.HeaderText = "Journée de travail";
			this.journeeDataGridViewTextBoxColumn.Name = "journeeDataGridViewTextBoxColumn";
			this.journeeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// heuresDataGridViewTextBoxColumn
			// 
			this.heuresDataGridViewTextBoxColumn.DataPropertyName = "heures";
			this.heuresDataGridViewTextBoxColumn.HeaderText = "Heures travaillées";
			this.heuresDataGridViewTextBoxColumn.Name = "heuresDataGridViewTextBoxColumn";
			this.heuresDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// minsDataGridViewTextBoxColumn
			// 
			this.minsDataGridViewTextBoxColumn.DataPropertyName = "mins";
			this.minsDataGridViewTextBoxColumn.HeaderText = "Minutes";
			this.minsDataGridViewTextBoxColumn.Name = "minsDataGridViewTextBoxColumn";
			this.minsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateModifDataGridViewTextBoxColumn
			// 
			this.dateModifDataGridViewTextBoxColumn.DataPropertyName = "dateModif";
			this.dateModifDataGridViewTextBoxColumn.HeaderText = "Dernière modification";
			this.dateModifDataGridViewTextBoxColumn.Name = "dateModifDataGridViewTextBoxColumn";
			this.dateModifDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// modifParDataGridViewTextBoxColumn
			// 
			this.modifParDataGridViewTextBoxColumn.DataPropertyName = "modifPar";
			this.modifParDataGridViewTextBoxColumn.HeaderText = "Modifié par";
			this.modifParDataGridViewTextBoxColumn.Name = "modifParDataGridViewTextBoxColumn";
			this.modifParDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "Employes";
			this.bindingSource1.DataSource = this.fdtDataSet1;
			// 
			// employesTableAdapter
			// 
			this.employesTableAdapter.ClearBeforeFill = true;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainScreenTabControl);
			this.Name = "MainScreen";
			this.Text = "Feuille De Temps";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.MainScreenTabControl.ResumeLayout(false);
			this.HistoriqueTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHorodateurBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource employesBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabControl MainScreenTabControl;
		private System.Windows.Forms.TabPage HistoriqueTabPage;
		private System.Windows.Forms.TabPage tabPage2;
		private fdtDataSet fdtDataSet;
		private System.Windows.Forms.BindingSource entreesHorodateurBindingSource;
		private fdtDataSet fdtDataSet1;
		private System.Windows.Forms.BindingSource entreesHeuresBindingSource;
		private fdtDataSetTableAdapters.EntreesHeuresTableAdapter entreesHeuresTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn projetIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cliNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn journeeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn heuresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn minsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateModifDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modifParDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bindingSource1;
		private fdtDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
	}
}