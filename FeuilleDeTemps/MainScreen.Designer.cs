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
			this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
			this.HistEndDatePicker = new System.Windows.Forms.DateTimePicker();
			this.HistEndDatePickerLabel = new System.Windows.Forms.Label();
			this.HistStartDatePicker = new System.Windows.Forms.DateTimePicker();
			this.HistStartDatePickerLabel = new System.Windows.Forms.Label();
			this.HistProjetIdComboLabel = new System.Windows.Forms.Label();
			this.HistProjetIdComboBox = new System.Windows.Forms.ComboBox();
			this.projetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet1 = new FeuilleDeTemps.fdtDataSet();
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
			this.entreesHeuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.fdtDataSet = new FeuilleDeTemps.fdtDataSet();
			this.entreesHeuresTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EntreesHeuresTableAdapter();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.employesTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EmployesTableAdapter();
			this.projetsTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.ProjetsTableAdapter();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.HistProjetIdCheckBox = new System.Windows.Forms.CheckBox();
			this.HistStartDateCheckBox = new System.Windows.Forms.CheckBox();
			this.HistEndDateCheckBox = new System.Windows.Forms.CheckBox();
			this.HistSearchButton = new System.Windows.Forms.Button();
			this.HistResetButton = new System.Windows.Forms.Button();
			this.MainScreenTabControl.SuspendLayout();
			this.HistoriqueTabPage.SuspendLayout();
			this.rechercheGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).BeginInit();
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
			this.MainScreenTabControl.Location = new System.Drawing.Point(12, 38);
			this.MainScreenTabControl.Name = "MainScreenTabControl";
			this.MainScreenTabControl.SelectedIndex = 0;
			this.MainScreenTabControl.Size = new System.Drawing.Size(776, 400);
			this.MainScreenTabControl.TabIndex = 0;
			// 
			// HistoriqueTabPage
			// 
			this.HistoriqueTabPage.Controls.Add(this.rechercheGroupBox);
			this.HistoriqueTabPage.Controls.Add(this.dataGridView2);
			this.HistoriqueTabPage.Location = new System.Drawing.Point(4, 22);
			this.HistoriqueTabPage.Name = "HistoriqueTabPage";
			this.HistoriqueTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.HistoriqueTabPage.Size = new System.Drawing.Size(768, 374);
			this.HistoriqueTabPage.TabIndex = 0;
			this.HistoriqueTabPage.Text = "Historique";
			this.HistoriqueTabPage.UseVisualStyleBackColor = true;
			// 
			// rechercheGroupBox
			// 
			this.rechercheGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rechercheGroupBox.Controls.Add(this.HistResetButton);
			this.rechercheGroupBox.Controls.Add(this.HistSearchButton);
			this.rechercheGroupBox.Controls.Add(this.HistEndDateCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistStartDateCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistEndDatePicker);
			this.rechercheGroupBox.Controls.Add(this.HistEndDatePickerLabel);
			this.rechercheGroupBox.Controls.Add(this.HistStartDatePicker);
			this.rechercheGroupBox.Controls.Add(this.HistStartDatePickerLabel);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdComboLabel);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdComboBox);
			this.rechercheGroupBox.Location = new System.Drawing.Point(7, 7);
			this.rechercheGroupBox.Name = "rechercheGroupBox";
			this.rechercheGroupBox.Size = new System.Drawing.Size(755, 87);
			this.rechercheGroupBox.TabIndex = 2;
			this.rechercheGroupBox.TabStop = false;
			this.rechercheGroupBox.Text = "Critères de recherche";
			// 
			// HistEndDatePicker
			// 
			this.HistEndDatePicker.Location = new System.Drawing.Point(368, 52);
			this.HistEndDatePicker.Name = "HistEndDatePicker";
			this.HistEndDatePicker.Size = new System.Drawing.Size(134, 20);
			this.HistEndDatePicker.TabIndex = 6;
			this.HistEndDatePicker.Value = new System.DateTime(2022, 11, 29, 10, 59, 46, 0);
			// 
			// HistEndDatePickerLabel
			// 
			this.HistEndDatePickerLabel.AutoSize = true;
			this.HistEndDatePickerLabel.Location = new System.Drawing.Point(365, 32);
			this.HistEndDatePickerLabel.Name = "HistEndDatePickerLabel";
			this.HistEndDatePickerLabel.Size = new System.Drawing.Size(59, 13);
			this.HistEndDatePickerLabel.TabIndex = 5;
			this.HistEndDatePickerLabel.Text = "Date de fin";
			// 
			// HistStartDatePicker
			// 
			this.HistStartDatePicker.Location = new System.Drawing.Point(191, 51);
			this.HistStartDatePicker.Name = "HistStartDatePicker";
			this.HistStartDatePicker.Size = new System.Drawing.Size(134, 20);
			this.HistStartDatePicker.TabIndex = 4;
			this.HistStartDatePicker.Value = new System.DateTime(2022, 11, 29, 10, 59, 40, 0);
			// 
			// HistStartDatePickerLabel
			// 
			this.HistStartDatePickerLabel.AutoSize = true;
			this.HistStartDatePickerLabel.Location = new System.Drawing.Point(188, 31);
			this.HistStartDatePickerLabel.Name = "HistStartDatePickerLabel";
			this.HistStartDatePickerLabel.Size = new System.Drawing.Size(75, 13);
			this.HistStartDatePickerLabel.TabIndex = 3;
			this.HistStartDatePickerLabel.Text = "Date de début";
			// 
			// HistProjetIdComboLabel
			// 
			this.HistProjetIdComboLabel.AutoSize = true;
			this.HistProjetIdComboLabel.Location = new System.Drawing.Point(29, 32);
			this.HistProjetIdComboLabel.Name = "HistProjetIdComboLabel";
			this.HistProjetIdComboLabel.Size = new System.Drawing.Size(97, 13);
			this.HistProjetIdComboLabel.TabIndex = 1;
			this.HistProjetIdComboLabel.Text = "Identifiant de projet";
			// 
			// HistProjetIdComboBox
			// 
			this.HistProjetIdComboBox.DataSource = this.projetsBindingSource;
			this.HistProjetIdComboBox.DisplayMember = "projetId";
			this.HistProjetIdComboBox.FormattingEnabled = true;
			this.HistProjetIdComboBox.Location = new System.Drawing.Point(28, 51);
			this.HistProjetIdComboBox.Name = "HistProjetIdComboBox";
			this.HistProjetIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.HistProjetIdComboBox.TabIndex = 0;
			// 
			// projetsBindingSource
			// 
			this.projetsBindingSource.DataMember = "Projets";
			this.projetsBindingSource.DataSource = this.fdtDataSet1;
			// 
			// fdtDataSet1
			// 
			this.fdtDataSet1.DataSetName = "fdtDataSet";
			this.fdtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.dataGridView2.Location = new System.Drawing.Point(6, 100);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(756, 268);
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
			// entreesHeuresBindingSource
			// 
			this.entreesHeuresBindingSource.DataMember = "EntreesHeures";
			this.entreesHeuresBindingSource.DataSource = this.fdtDataSet1;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 374);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Modifier / Ajouter";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "Employes";
			this.bindingSource1.DataSource = this.fdtDataSet1;
			// 
			// employesTableAdapter
			// 
			this.employesTableAdapter.ClearBeforeFill = true;
			// 
			// projetsTableAdapter
			// 
			this.projetsTableAdapter.ClearBeforeFill = true;
			// 
			// LogoutButton
			// 
			this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LogoutButton.Location = new System.Drawing.Point(664, 12);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(120, 30);
			this.LogoutButton.TabIndex = 1;
			this.LogoutButton.Text = "Déconnection";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// HistProjetIdCheckBox
			// 
			this.HistProjetIdCheckBox.AutoSize = true;
			this.HistProjetIdCheckBox.Location = new System.Drawing.Point(9, 53);
			this.HistProjetIdCheckBox.Name = "HistProjetIdCheckBox";
			this.HistProjetIdCheckBox.Size = new System.Drawing.Size(15, 14);
			this.HistProjetIdCheckBox.TabIndex = 7;
			this.HistProjetIdCheckBox.UseVisualStyleBackColor = true;
			// 
			// HistStartDateCheckBox
			// 
			this.HistStartDateCheckBox.AutoSize = true;
			this.HistStartDateCheckBox.Location = new System.Drawing.Point(170, 53);
			this.HistStartDateCheckBox.Name = "HistStartDateCheckBox";
			this.HistStartDateCheckBox.Size = new System.Drawing.Size(15, 14);
			this.HistStartDateCheckBox.TabIndex = 8;
			this.HistStartDateCheckBox.UseVisualStyleBackColor = true;
			// 
			// HistEndDateCheckBox
			// 
			this.HistEndDateCheckBox.AutoSize = true;
			this.HistEndDateCheckBox.Location = new System.Drawing.Point(347, 54);
			this.HistEndDateCheckBox.Name = "HistEndDateCheckBox";
			this.HistEndDateCheckBox.Size = new System.Drawing.Size(15, 14);
			this.HistEndDateCheckBox.TabIndex = 9;
			this.HistEndDateCheckBox.UseVisualStyleBackColor = true;
			// 
			// HistSearchButton
			// 
			this.HistSearchButton.Location = new System.Drawing.Point(674, 47);
			this.HistSearchButton.Name = "HistSearchButton";
			this.HistSearchButton.Size = new System.Drawing.Size(75, 23);
			this.HistSearchButton.TabIndex = 10;
			this.HistSearchButton.Text = "Rechercher";
			this.HistSearchButton.UseVisualStyleBackColor = true;
			this.HistSearchButton.Click += new System.EventHandler(this.HistSearchButton_Click);
			// 
			// HistResetButton
			// 
			this.HistResetButton.Location = new System.Drawing.Point(674, 18);
			this.HistResetButton.Name = "HistResetButton";
			this.HistResetButton.Size = new System.Drawing.Size(75, 23);
			this.HistResetButton.TabIndex = 11;
			this.HistResetButton.Text = "Réinitialiser";
			this.HistResetButton.UseVisualStyleBackColor = true;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.MainScreenTabControl);
			this.Name = "MainScreen";
			this.Text = "Feuille De Temps";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.MainScreenTabControl.ResumeLayout(false);
			this.HistoriqueTabPage.ResumeLayout(false);
			this.rechercheGroupBox.ResumeLayout(false);
			this.rechercheGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).EndInit();
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
		private System.Windows.Forms.GroupBox rechercheGroupBox;
		private System.Windows.Forms.ComboBox HistProjetIdComboBox;
		private System.Windows.Forms.BindingSource projetsBindingSource;
		private fdtDataSetTableAdapters.ProjetsTableAdapter projetsTableAdapter;
		private System.Windows.Forms.Label HistStartDatePickerLabel;
		private System.Windows.Forms.Label HistProjetIdComboLabel;
		private System.Windows.Forms.DateTimePicker HistStartDatePicker;
		private System.Windows.Forms.DateTimePicker HistEndDatePicker;
		private System.Windows.Forms.Label HistEndDatePickerLabel;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.CheckBox HistProjetIdCheckBox;
		private System.Windows.Forms.CheckBox HistEndDateCheckBox;
		private System.Windows.Forms.CheckBox HistStartDateCheckBox;
		private System.Windows.Forms.Button HistSearchButton;
		private System.Windows.Forms.Button HistResetButton;
	}
}