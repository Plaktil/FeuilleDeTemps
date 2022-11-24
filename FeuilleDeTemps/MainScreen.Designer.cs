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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.employesDataSet = new FeuilleDeTemps.EmployesDataSet();
			this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employesTableAdapter = new FeuilleDeTemps.EmployesDataSetTableAdapters.EmployesTableAdapter();
			this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employesDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.employesBindingSource;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.Location = new System.Drawing.Point(12, 130);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(776, 308);
			this.dataGridView1.TabIndex = 0;
			// 
			// employesDataSet
			// 
			this.employesDataSet.DataSetName = "EmployesDataSet";
			this.employesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// employesBindingSource
			// 
			this.employesBindingSource.DataMember = "Employes";
			this.employesBindingSource.DataSource = this.employesDataSet;
			// 
			// employesTableAdapter
			// 
			this.employesTableAdapter.ClearBeforeFill = true;
			// 
			// empIdDataGridViewTextBoxColumn
			// 
			this.empIdDataGridViewTextBoxColumn.DataPropertyName = "empId";
			this.empIdDataGridViewTextBoxColumn.HeaderText = "Identifiant";
			this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
			// 
			// fnameDataGridViewTextBoxColumn
			// 
			this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
			this.fnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
			this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
			// 
			// lnameDataGridViewTextBoxColumn
			// 
			this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
			this.lnameDataGridViewTextBoxColumn.HeaderText = "Nom de famille";
			this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
			// 
			// jobDataGridViewTextBoxColumn
			// 
			this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
			this.jobDataGridViewTextBoxColumn.HeaderText = "Poste / Fonction";
			this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
			// 
			// telDataGridViewTextBoxColumn
			// 
			this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
			this.telDataGridViewTextBoxColumn.HeaderText = "Téléphone";
			this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainScreen";
			this.Text = "Feuille De Temps";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employesDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private EmployesDataSet employesDataSet;
		private System.Windows.Forms.BindingSource employesBindingSource;
		private EmployesDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
	}
}