namespace FeuilleDeTemps
{
	partial class AddModifPopUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifPopUp));
			this.AddModifGroupBox = new System.Windows.Forms.GroupBox();
			this.AddModifCancelButton = new System.Windows.Forms.Button();
			this.AddModifMinutesLabel = new System.Windows.Forms.Label();
			this.AddModifHourLabel = new System.Windows.Forms.Label();
			this.AddModifMinutesComboBox = new System.Windows.Forms.ComboBox();
			this.AddModifHoursComboBox = new System.Windows.Forms.ComboBox();
			this.AddModifEmpIdComboBox = new System.Windows.Forms.ComboBox();
			this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fdtDataSet = new FeuilleDeTemps.fdtDataSet();
			this.AddModifEmpIdLabel = new System.Windows.Forms.Label();
			this.SaveAndSubmitButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.AddModifWorkHoursLabel = new System.Windows.Forms.Label();
			this.AddModifDatePicker = new System.Windows.Forms.DateTimePicker();
			this.AddModifDateLabel = new System.Windows.Forms.Label();
			this.AddModifProjetIdLabel = new System.Windows.Forms.Label();
			this.AddModifProjetIdComboBox = new System.Windows.Forms.ComboBox();
			this.projetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.projetsTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.ProjetsTableAdapter();
			this.employesTableAdapter = new FeuilleDeTemps.fdtDataSetTableAdapters.EmployesTableAdapter();
			this.AddModifGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// AddModifGroupBox
			// 
			this.AddModifGroupBox.Controls.Add(this.AddModifCancelButton);
			this.AddModifGroupBox.Controls.Add(this.AddModifMinutesLabel);
			this.AddModifGroupBox.Controls.Add(this.AddModifHourLabel);
			this.AddModifGroupBox.Controls.Add(this.AddModifMinutesComboBox);
			this.AddModifGroupBox.Controls.Add(this.AddModifHoursComboBox);
			this.AddModifGroupBox.Controls.Add(this.AddModifEmpIdComboBox);
			this.AddModifGroupBox.Controls.Add(this.AddModifEmpIdLabel);
			this.AddModifGroupBox.Controls.Add(this.SaveAndSubmitButton);
			this.AddModifGroupBox.Controls.Add(this.SaveButton);
			this.AddModifGroupBox.Controls.Add(this.AddModifWorkHoursLabel);
			this.AddModifGroupBox.Controls.Add(this.AddModifDatePicker);
			this.AddModifGroupBox.Controls.Add(this.AddModifDateLabel);
			this.AddModifGroupBox.Controls.Add(this.AddModifProjetIdLabel);
			this.AddModifGroupBox.Controls.Add(this.AddModifProjetIdComboBox);
			this.AddModifGroupBox.Location = new System.Drawing.Point(23, 12);
			this.AddModifGroupBox.Name = "AddModifGroupBox";
			this.AddModifGroupBox.Size = new System.Drawing.Size(347, 210);
			this.AddModifGroupBox.TabIndex = 3;
			this.AddModifGroupBox.TabStop = false;
			this.AddModifGroupBox.Text = "Ajouter / Modifier";
			// 
			// AddModifCancelButton
			// 
			this.AddModifCancelButton.Location = new System.Drawing.Point(258, 181);
			this.AddModifCancelButton.Name = "AddModifCancelButton";
			this.AddModifCancelButton.Size = new System.Drawing.Size(83, 23);
			this.AddModifCancelButton.TabIndex = 20;
			this.AddModifCancelButton.Text = "Annuler";
			this.AddModifCancelButton.UseVisualStyleBackColor = true;
			this.AddModifCancelButton.Click += new System.EventHandler(this.AddModifCancelButton_Click);
			// 
			// AddModifMinutesLabel
			// 
			this.AddModifMinutesLabel.AutoSize = true;
			this.AddModifMinutesLabel.Location = new System.Drawing.Point(273, 106);
			this.AddModifMinutesLabel.Name = "AddModifMinutesLabel";
			this.AddModifMinutesLabel.Size = new System.Drawing.Size(15, 13);
			this.AddModifMinutesLabel.TabIndex = 19;
			this.AddModifMinutesLabel.Text = "m";
			// 
			// AddModifHourLabel
			// 
			this.AddModifHourLabel.AutoSize = true;
			this.AddModifHourLabel.Location = new System.Drawing.Point(211, 107);
			this.AddModifHourLabel.Name = "AddModifHourLabel";
			this.AddModifHourLabel.Size = new System.Drawing.Size(13, 13);
			this.AddModifHourLabel.TabIndex = 18;
			this.AddModifHourLabel.Text = "h";
			// 
			// AddModifMinutesComboBox
			// 
			this.AddModifMinutesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AddModifMinutesComboBox.FormattingEnabled = true;
			this.AddModifMinutesComboBox.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
			this.AddModifMinutesComboBox.Location = new System.Drawing.Point(230, 104);
			this.AddModifMinutesComboBox.Name = "AddModifMinutesComboBox";
			this.AddModifMinutesComboBox.Size = new System.Drawing.Size(37, 21);
			this.AddModifMinutesComboBox.TabIndex = 17;
			// 
			// AddModifHoursComboBox
			// 
			this.AddModifHoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AddModifHoursComboBox.FormattingEnabled = true;
			this.AddModifHoursComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.AddModifHoursComboBox.Location = new System.Drawing.Point(169, 103);
			this.AddModifHoursComboBox.Name = "AddModifHoursComboBox";
			this.AddModifHoursComboBox.Size = new System.Drawing.Size(36, 21);
			this.AddModifHoursComboBox.TabIndex = 16;
			// 
			// AddModifEmpIdComboBox
			// 
			this.AddModifEmpIdComboBox.DataSource = this.employesBindingSource;
			this.AddModifEmpIdComboBox.DisplayMember = "empId";
			this.AddModifEmpIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AddModifEmpIdComboBox.FormattingEnabled = true;
			this.AddModifEmpIdComboBox.Location = new System.Drawing.Point(28, 104);
			this.AddModifEmpIdComboBox.Name = "AddModifEmpIdComboBox";
			this.AddModifEmpIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.AddModifEmpIdComboBox.TabIndex = 15;
			// 
			// employesBindingSource
			// 
			this.employesBindingSource.DataMember = "Employes";
			this.employesBindingSource.DataSource = this.fdtDataSet;
			// 
			// fdtDataSet
			// 
			this.fdtDataSet.DataSetName = "fdtDataSet";
			this.fdtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// AddModifEmpIdLabel
			// 
			this.AddModifEmpIdLabel.AutoSize = true;
			this.AddModifEmpIdLabel.Location = new System.Drawing.Point(25, 84);
			this.AddModifEmpIdLabel.Name = "AddModifEmpIdLabel";
			this.AddModifEmpIdLabel.Size = new System.Drawing.Size(103, 13);
			this.AddModifEmpIdLabel.TabIndex = 12;
			this.AddModifEmpIdLabel.Text = "Identifiant d\'employé";
			// 
			// SaveAndSubmitButton
			// 
			this.SaveAndSubmitButton.Location = new System.Drawing.Point(106, 181);
			this.SaveAndSubmitButton.Name = "SaveAndSubmitButton";
			this.SaveAndSubmitButton.Size = new System.Drawing.Size(135, 23);
			this.SaveAndSubmitButton.TabIndex = 11;
			this.SaveAndSubmitButton.Text = "Enregistrer et soumettre";
			this.SaveAndSubmitButton.UseVisualStyleBackColor = true;
			this.SaveAndSubmitButton.Click += new System.EventHandler(this.SaveAndSubmitButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(6, 181);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(83, 23);
			this.SaveButton.TabIndex = 10;
			this.SaveButton.Text = "Enregistrer";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddModifWorkHoursLabel
			// 
			this.AddModifWorkHoursLabel.AutoSize = true;
			this.AddModifWorkHoursLabel.Location = new System.Drawing.Point(166, 84);
			this.AddModifWorkHoursLabel.Name = "AddModifWorkHoursLabel";
			this.AddModifWorkHoursLabel.Size = new System.Drawing.Size(95, 13);
			this.AddModifWorkHoursLabel.TabIndex = 5;
			this.AddModifWorkHoursLabel.Text = "Heures Travaillées";
			// 
			// AddModifDatePicker
			// 
			this.AddModifDatePicker.Location = new System.Drawing.Point(169, 51);
			this.AddModifDatePicker.Name = "AddModifDatePicker";
			this.AddModifDatePicker.Size = new System.Drawing.Size(134, 20);
			this.AddModifDatePicker.TabIndex = 4;
			this.AddModifDatePicker.Value = new System.DateTime(2022, 11, 29, 10, 59, 40, 0);
			this.AddModifDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddModifDatePicker_KeyDown);
			// 
			// AddModifDateLabel
			// 
			this.AddModifDateLabel.AutoSize = true;
			this.AddModifDateLabel.Location = new System.Drawing.Point(166, 31);
			this.AddModifDateLabel.Name = "AddModifDateLabel";
			this.AddModifDateLabel.Size = new System.Drawing.Size(30, 13);
			this.AddModifDateLabel.TabIndex = 3;
			this.AddModifDateLabel.Text = "Date";
			// 
			// AddModifProjetIdLabel
			// 
			this.AddModifProjetIdLabel.AutoSize = true;
			this.AddModifProjetIdLabel.Location = new System.Drawing.Point(29, 32);
			this.AddModifProjetIdLabel.Name = "AddModifProjetIdLabel";
			this.AddModifProjetIdLabel.Size = new System.Drawing.Size(97, 13);
			this.AddModifProjetIdLabel.TabIndex = 1;
			this.AddModifProjetIdLabel.Text = "Identifiant de projet";
			// 
			// AddModifProjetIdComboBox
			// 
			this.AddModifProjetIdComboBox.DataSource = this.projetsBindingSource;
			this.AddModifProjetIdComboBox.DisplayMember = "projetId";
			this.AddModifProjetIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AddModifProjetIdComboBox.FormattingEnabled = true;
			this.AddModifProjetIdComboBox.Location = new System.Drawing.Point(28, 51);
			this.AddModifProjetIdComboBox.Name = "AddModifProjetIdComboBox";
			this.AddModifProjetIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.AddModifProjetIdComboBox.TabIndex = 0;
			this.AddModifProjetIdComboBox.SelectedIndexChanged += new System.EventHandler(this.AddModifProjetIdComboBox_SelectedIndexChanged);
			// 
			// projetsBindingSource
			// 
			this.projetsBindingSource.DataMember = "Projets";
			this.projetsBindingSource.DataSource = this.fdtDataSet;
			// 
			// projetsTableAdapter
			// 
			this.projetsTableAdapter.ClearBeforeFill = true;
			// 
			// employesTableAdapter
			// 
			this.employesTableAdapter.ClearBeforeFill = true;
			// 
			// AddModifPopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 238);
			this.Controls.Add(this.AddModifGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "AddModifPopUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Feuille De Temps";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddModifPopUp_FormClosed);
			this.Load += new System.EventHandler(this.AddModifPopUp_Load);
			this.AddModifGroupBox.ResumeLayout(false);
			this.AddModifGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fdtDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.projetsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox AddModifGroupBox;
		private System.Windows.Forms.ComboBox AddModifEmpIdComboBox;
		private System.Windows.Forms.Label AddModifEmpIdLabel;
		private System.Windows.Forms.Button SaveAndSubmitButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Label AddModifWorkHoursLabel;
		private System.Windows.Forms.DateTimePicker AddModifDatePicker;
		private System.Windows.Forms.Label AddModifDateLabel;
		private System.Windows.Forms.Label AddModifProjetIdLabel;
		private System.Windows.Forms.ComboBox AddModifProjetIdComboBox;
		private System.Windows.Forms.ComboBox AddModifHoursComboBox;
		private System.Windows.Forms.Label AddModifMinutesLabel;
		private System.Windows.Forms.Label AddModifHourLabel;
		private System.Windows.Forms.ComboBox AddModifMinutesComboBox;
		private System.Windows.Forms.Button AddModifCancelButton;
		private fdtDataSet fdtDataSet;
		private System.Windows.Forms.BindingSource projetsBindingSource;
		private fdtDataSetTableAdapters.ProjetsTableAdapter projetsTableAdapter;
		private System.Windows.Forms.BindingSource employesBindingSource;
		private fdtDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
	}
}