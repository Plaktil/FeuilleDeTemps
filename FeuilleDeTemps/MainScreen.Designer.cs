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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
			this.MainScreenTabControl = new System.Windows.Forms.TabControl();
			this.AddDeleteTabPage = new System.Windows.Forms.TabPage();
			this.AddModifDGV = new System.Windows.Forms.DataGridView();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horodateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet1 = new FeuilleDeTemps.fdtDataSet();
			this.HistTabPage = new System.Windows.Forms.TabPage();
			this.HistDGV = new System.Windows.Forms.DataGridView();
			this.projetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cliNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.journeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soumis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dateModifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modifParDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entreesHeuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rechercheGroupBox = new System.Windows.Forms.GroupBox();
			this.HistEmpIdComboBox = new System.Windows.Forms.ComboBox();
			this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.HistEmpIdCheckBox = new System.Windows.Forms.CheckBox();
			this.HistEmpIdLabel = new System.Windows.Forms.Label();
			this.HistResetButton = new System.Windows.Forms.Button();
			this.HistSearchButton = new System.Windows.Forms.Button();
			this.HistEndDateCheckBox = new System.Windows.Forms.CheckBox();
			this.HistStartDateCheckBox = new System.Windows.Forms.CheckBox();
			this.HistProjetIdCheckBox = new System.Windows.Forms.CheckBox();
			this.HistEndDatePicker = new System.Windows.Forms.DateTimePicker();
			this.HistEndDatePickerLabel = new System.Windows.Forms.Label();
			this.HistStartDatePicker = new System.Windows.Forms.DateTimePicker();
			this.HistStartDatePickerLabel = new System.Windows.Forms.Label();
			this.HistProjetIdLabel = new System.Windows.Forms.Label();
			this.HistProjetIdComboBox = new System.Windows.Forms.ComboBox();
			this.projetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet = new FeuilleDeTemps.fdtDataSet();
			this.entreesHeuresTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EntreesHeuresTableAdapter();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.employesTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EmployesTableAdapter();
			this.projetsTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.ProjetsTableAdapter();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.entreesHeuresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.horodateurTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.HorodateurTableAdapter();
			this.MainScreenTabControl.SuspendLayout();
			this.AddDeleteTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddModifDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.horodateurBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).BeginInit();
			this.HistTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HistDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).BeginInit();
			this.rechercheGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainScreenTabControl
			// 
			this.MainScreenTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainScreenTabControl.Controls.Add(this.AddDeleteTabPage);
			this.MainScreenTabControl.Controls.Add(this.HistTabPage);
			this.MainScreenTabControl.Location = new System.Drawing.Point(12, 168);
			this.MainScreenTabControl.Name = "MainScreenTabControl";
			this.MainScreenTabControl.SelectedIndex = 0;
			this.MainScreenTabControl.Size = new System.Drawing.Size(831, 343);
			this.MainScreenTabControl.TabIndex = 0;
			// 
			// AddDeleteTabPage
			// 
			this.AddDeleteTabPage.Controls.Add(this.AddModifDGV);
			this.AddDeleteTabPage.Location = new System.Drawing.Point(4, 22);
			this.AddDeleteTabPage.Name = "AddDeleteTabPage";
			this.AddDeleteTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.AddDeleteTabPage.Size = new System.Drawing.Size(823, 317);
			this.AddDeleteTabPage.TabIndex = 1;
			this.AddDeleteTabPage.Text = "Modifier / Ajouter";
			this.AddDeleteTabPage.UseVisualStyleBackColor = true;
			// 
			// AddModifDGV
			// 
			this.AddModifDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddModifDGV.AutoGenerateColumns = false;
			this.AddModifDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.AddModifDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.AddModifDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AddModifDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
			this.AddModifDGV.DataSource = this.horodateurBindingSource;
			this.AddModifDGV.Location = new System.Drawing.Point(6, 6);
			this.AddModifDGV.Name = "AddModifDGV";
			this.AddModifDGV.Size = new System.Drawing.Size(811, 305);
			this.AddModifDGV.TabIndex = 2;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "soumis";
			this.dataGridViewCheckBoxColumn1.FillWeight = 60F;
			this.dataGridViewCheckBoxColumn1.HeaderText = "Soumettre";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "projetId";
			this.dataGridViewTextBoxColumn4.HeaderText = "Identifiant de projet";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "empId";
			this.dataGridViewTextBoxColumn6.HeaderText = "Identifiant d\'employé";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "journee";
			this.dataGridViewTextBoxColumn9.HeaderText = "Journée de travail";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "heures";
			this.dataGridViewTextBoxColumn10.HeaderText = "Heures travaillées";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "mins";
			this.dataGridViewTextBoxColumn11.HeaderText = "Minutes";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "dateModif";
			this.dataGridViewTextBoxColumn12.HeaderText = "Dernière modification";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "modifPar";
			this.dataGridViewTextBoxColumn13.HeaderText = "Modifié par";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// horodateurBindingSource
			// 
			this.horodateurBindingSource.DataMember = "Horodateur";
			this.horodateurBindingSource.DataSource = this.fdtDataSet1;
			// 
			// fdtDataSet1
			// 
			this.fdtDataSet1.DataSetName = "fdtDataSet";
			this.fdtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// HistTabPage
			// 
			this.HistTabPage.Controls.Add(this.HistDGV);
			this.HistTabPage.Location = new System.Drawing.Point(4, 22);
			this.HistTabPage.Name = "HistTabPage";
			this.HistTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.HistTabPage.Size = new System.Drawing.Size(823, 317);
			this.HistTabPage.TabIndex = 0;
			this.HistTabPage.Text = "Historique";
			this.HistTabPage.UseVisualStyleBackColor = true;
			// 
			// HistDGV
			// 
			this.HistDGV.AllowUserToAddRows = false;
			this.HistDGV.AllowUserToDeleteRows = false;
			this.HistDGV.AllowUserToOrderColumns = true;
			this.HistDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HistDGV.AutoGenerateColumns = false;
			this.HistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.HistDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.HistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.HistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projetIdDataGridViewTextBoxColumn,
            this.cliNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.journeeDataGridViewTextBoxColumn,
            this.heuresDataGridViewTextBoxColumn,
            this.minsDataGridViewTextBoxColumn,
            this.soumis,
            this.dateModifDataGridViewTextBoxColumn,
            this.modifParDataGridViewTextBoxColumn});
			this.HistDGV.DataSource = this.entreesHeuresBindingSource;
			this.HistDGV.Location = new System.Drawing.Point(6, 6);
			this.HistDGV.Name = "HistDGV";
			this.HistDGV.Size = new System.Drawing.Size(811, 305);
			this.HistDGV.TabIndex = 1;
			// 
			// projetIdDataGridViewTextBoxColumn
			// 
			this.projetIdDataGridViewTextBoxColumn.DataPropertyName = "projetId";
			this.projetIdDataGridViewTextBoxColumn.HeaderText = "Identifiant de projet";
			this.projetIdDataGridViewTextBoxColumn.Name = "projetIdDataGridViewTextBoxColumn";
			// 
			// cliNameDataGridViewTextBoxColumn
			// 
			this.cliNameDataGridViewTextBoxColumn.DataPropertyName = "cliName";
			this.cliNameDataGridViewTextBoxColumn.HeaderText = "Client";
			this.cliNameDataGridViewTextBoxColumn.Name = "cliNameDataGridViewTextBoxColumn";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "empId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Identifiant d\'employé";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "fname";
			this.dataGridViewTextBoxColumn2.HeaderText = "Prénom";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "lname";
			this.dataGridViewTextBoxColumn3.HeaderText = "Nom de famille";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// journeeDataGridViewTextBoxColumn
			// 
			this.journeeDataGridViewTextBoxColumn.DataPropertyName = "journee";
			this.journeeDataGridViewTextBoxColumn.HeaderText = "Journée de travail";
			this.journeeDataGridViewTextBoxColumn.Name = "journeeDataGridViewTextBoxColumn";
			// 
			// heuresDataGridViewTextBoxColumn
			// 
			this.heuresDataGridViewTextBoxColumn.DataPropertyName = "heures";
			this.heuresDataGridViewTextBoxColumn.HeaderText = "Heures travaillées";
			this.heuresDataGridViewTextBoxColumn.Name = "heuresDataGridViewTextBoxColumn";
			// 
			// minsDataGridViewTextBoxColumn
			// 
			this.minsDataGridViewTextBoxColumn.DataPropertyName = "mins";
			this.minsDataGridViewTextBoxColumn.HeaderText = "Minutes";
			this.minsDataGridViewTextBoxColumn.Name = "minsDataGridViewTextBoxColumn";
			// 
			// soumis
			// 
			this.soumis.DataPropertyName = "soumis";
			this.soumis.HeaderText = "Soumis";
			this.soumis.Name = "soumis";
			// 
			// dateModifDataGridViewTextBoxColumn
			// 
			this.dateModifDataGridViewTextBoxColumn.DataPropertyName = "dateModif";
			this.dateModifDataGridViewTextBoxColumn.HeaderText = "Dernière modification";
			this.dateModifDataGridViewTextBoxColumn.Name = "dateModifDataGridViewTextBoxColumn";
			// 
			// modifParDataGridViewTextBoxColumn
			// 
			this.modifParDataGridViewTextBoxColumn.DataPropertyName = "modifPar";
			this.modifParDataGridViewTextBoxColumn.HeaderText = "Modifié par";
			this.modifParDataGridViewTextBoxColumn.Name = "modifParDataGridViewTextBoxColumn";
			// 
			// entreesHeuresBindingSource
			// 
			this.entreesHeuresBindingSource.DataMember = "EntreesHeures";
			this.entreesHeuresBindingSource.DataSource = this.fdtDataSet1;
			// 
			// rechercheGroupBox
			// 
			this.rechercheGroupBox.Controls.Add(this.HistEmpIdComboBox);
			this.rechercheGroupBox.Controls.Add(this.HistEmpIdCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistEmpIdLabel);
			this.rechercheGroupBox.Controls.Add(this.HistResetButton);
			this.rechercheGroupBox.Controls.Add(this.HistSearchButton);
			this.rechercheGroupBox.Controls.Add(this.HistEndDateCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistStartDateCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdCheckBox);
			this.rechercheGroupBox.Controls.Add(this.HistEndDatePicker);
			this.rechercheGroupBox.Controls.Add(this.HistEndDatePickerLabel);
			this.rechercheGroupBox.Controls.Add(this.HistStartDatePicker);
			this.rechercheGroupBox.Controls.Add(this.HistStartDatePickerLabel);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdLabel);
			this.rechercheGroupBox.Controls.Add(this.HistProjetIdComboBox);
			this.rechercheGroupBox.Location = new System.Drawing.Point(16, 48);
			this.rechercheGroupBox.Name = "rechercheGroupBox";
			this.rechercheGroupBox.Size = new System.Drawing.Size(823, 118);
			this.rechercheGroupBox.TabIndex = 2;
			this.rechercheGroupBox.TabStop = false;
			this.rechercheGroupBox.Text = "Critères de recherche";
			// 
			// HistEmpIdComboBox
			// 
			this.HistEmpIdComboBox.DataSource = this.bindingSource3;
			this.HistEmpIdComboBox.DisplayMember = "empId";
			this.HistEmpIdComboBox.FormattingEnabled = true;
			this.HistEmpIdComboBox.Location = new System.Drawing.Point(545, 52);
			this.HistEmpIdComboBox.Name = "HistEmpIdComboBox";
			this.HistEmpIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.HistEmpIdComboBox.TabIndex = 15;
			// 
			// bindingSource3
			// 
			this.bindingSource3.DataMember = "Employes";
			this.bindingSource3.DataSource = this.fdtDataSet1;
			// 
			// HistEmpIdCheckBox
			// 
			this.HistEmpIdCheckBox.AutoSize = true;
			this.HistEmpIdCheckBox.Location = new System.Drawing.Point(524, 54);
			this.HistEmpIdCheckBox.Name = "HistEmpIdCheckBox";
			this.HistEmpIdCheckBox.Size = new System.Drawing.Size(15, 14);
			this.HistEmpIdCheckBox.TabIndex = 14;
			this.HistEmpIdCheckBox.UseVisualStyleBackColor = true;
			// 
			// HistEmpIdLabel
			// 
			this.HistEmpIdLabel.AutoSize = true;
			this.HistEmpIdLabel.Location = new System.Drawing.Point(542, 32);
			this.HistEmpIdLabel.Name = "HistEmpIdLabel";
			this.HistEmpIdLabel.Size = new System.Drawing.Size(103, 13);
			this.HistEmpIdLabel.TabIndex = 12;
			this.HistEmpIdLabel.Text = "Identifiant d\'employé";
			// 
			// HistResetButton
			// 
			this.HistResetButton.Location = new System.Drawing.Point(110, 89);
			this.HistResetButton.Name = "HistResetButton";
			this.HistResetButton.Size = new System.Drawing.Size(75, 23);
			this.HistResetButton.TabIndex = 11;
			this.HistResetButton.Text = "Réinitialiser";
			this.HistResetButton.UseVisualStyleBackColor = true;
			this.HistResetButton.Click += new System.EventHandler(this.HistResetButton_Click);
			// 
			// HistSearchButton
			// 
			this.HistSearchButton.Location = new System.Drawing.Point(28, 89);
			this.HistSearchButton.Name = "HistSearchButton";
			this.HistSearchButton.Size = new System.Drawing.Size(75, 23);
			this.HistSearchButton.TabIndex = 10;
			this.HistSearchButton.Text = "Rechercher";
			this.HistSearchButton.UseVisualStyleBackColor = true;
			this.HistSearchButton.Click += new System.EventHandler(this.HistSearchButton_Click);
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
			// HistStartDateCheckBox
			// 
			this.HistStartDateCheckBox.AutoSize = true;
			this.HistStartDateCheckBox.Location = new System.Drawing.Point(170, 53);
			this.HistStartDateCheckBox.Name = "HistStartDateCheckBox";
			this.HistStartDateCheckBox.Size = new System.Drawing.Size(15, 14);
			this.HistStartDateCheckBox.TabIndex = 8;
			this.HistStartDateCheckBox.UseVisualStyleBackColor = true;
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
			// HistProjetIdLabel
			// 
			this.HistProjetIdLabel.AutoSize = true;
			this.HistProjetIdLabel.Location = new System.Drawing.Point(29, 32);
			this.HistProjetIdLabel.Name = "HistProjetIdLabel";
			this.HistProjetIdLabel.Size = new System.Drawing.Size(97, 13);
			this.HistProjetIdLabel.TabIndex = 1;
			this.HistProjetIdLabel.Text = "Identifiant de projet";
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
			// bindingSource2
			// 
			this.bindingSource2.DataMember = "Employes";
			this.bindingSource2.DataSource = this.fdtDataSet1;
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
			this.LogoutButton.Location = new System.Drawing.Point(719, 12);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(120, 30);
			this.LogoutButton.TabIndex = 1;
			this.LogoutButton.Text = "Déconnection";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// entreesHeuresBindingSource1
			// 
			this.entreesHeuresBindingSource1.DataMember = "EntreesHeures";
			this.entreesHeuresBindingSource1.DataSource = this.fdtDataSet1;
			// 
			// horodateurTableAdapter
			// 
			this.horodateurTableAdapter.ClearBeforeFill = true;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 523);
			this.Controls.Add(this.rechercheGroupBox);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.MainScreenTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainScreen";
			this.Text = "Feuille De Temps";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.MainScreenTabControl.ResumeLayout(false);
			this.AddDeleteTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AddModifDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.horodateurBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet1)).EndInit();
			this.HistTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HistDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource)).EndInit();
			this.rechercheGroupBox.ResumeLayout(false);
			this.rechercheGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entreesHeuresBindingSource1)).EndInit();
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
		private System.Windows.Forms.TabPage HistTabPage;
		private System.Windows.Forms.TabPage AddDeleteTabPage;
		private fdtDataSet fdtDataSet;
		private fdtDataSet fdtDataSet1;
		private System.Windows.Forms.BindingSource entreesHeuresBindingSource;
		private fdtDataSetTableAdapters.EntreesHeuresTableAdapter entreesHeuresTableAdapter;
		private System.Windows.Forms.DataGridView HistDGV;
		private System.Windows.Forms.BindingSource bindingSource1;
		private fdtDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
		private System.Windows.Forms.GroupBox rechercheGroupBox;
		private System.Windows.Forms.ComboBox HistProjetIdComboBox;
		private System.Windows.Forms.BindingSource projetsBindingSource;
		private fdtDataSetTableAdapters.ProjetsTableAdapter projetsTableAdapter;
		private System.Windows.Forms.Label HistStartDatePickerLabel;
		private System.Windows.Forms.Label HistProjetIdLabel;
		private System.Windows.Forms.DateTimePicker HistStartDatePicker;
		private System.Windows.Forms.DateTimePicker HistEndDatePicker;
		private System.Windows.Forms.Label HistEndDatePickerLabel;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.CheckBox HistProjetIdCheckBox;
		private System.Windows.Forms.CheckBox HistEndDateCheckBox;
		private System.Windows.Forms.CheckBox HistStartDateCheckBox;
		private System.Windows.Forms.Button HistSearchButton;
		private System.Windows.Forms.Button HistResetButton;
		private System.Windows.Forms.CheckBox HistEmpIdCheckBox;
		private System.Windows.Forms.Label HistEmpIdLabel;
		private System.Windows.Forms.ComboBox HistEmpIdComboBox;
		private System.Windows.Forms.BindingSource bindingSource2;
		private System.Windows.Forms.BindingSource bindingSource3;
		private System.Windows.Forms.DataGridViewTextBoxColumn projetIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cliNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn journeeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn heuresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn minsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn soumis;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateModifDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modifParDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView AddModifDGV;
		private System.Windows.Forms.BindingSource entreesHeuresBindingSource1;
		private System.Windows.Forms.BindingSource horodateurBindingSource;
		private fdtDataSetTableAdapters.HorodateurTableAdapter horodateurTableAdapter;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
	}
}