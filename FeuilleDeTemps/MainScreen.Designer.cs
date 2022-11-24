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
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.employesDataSet = new FeuilleDeTemps.EmployesDataSet();
			this.MainScreenTopToolStrip = new System.Windows.Forms.ToolStrip();
			this.Menu1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Menu3 = new System.Windows.Forms.ToolStripLabel();
			this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employesTableAdapter = new FeuilleDeTemps.EmployesDataSetTableAdapters.EmployesTableAdapter();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employesDataSet)).BeginInit();
			this.MainScreenTopToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.MainScreenTopToolStrip);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.employesBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 199);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(776, 214);
			this.dataGridView1.TabIndex = 0;
			// 
			// empIdDataGridViewTextBoxColumn
			// 
			this.empIdDataGridViewTextBoxColumn.DataPropertyName = "empId";
			this.empIdDataGridViewTextBoxColumn.HeaderText = "Identifiant";
			this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
			this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fnameDataGridViewTextBoxColumn
			// 
			this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
			this.fnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
			this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
			this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lnameDataGridViewTextBoxColumn
			// 
			this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
			this.lnameDataGridViewTextBoxColumn.HeaderText = "Nom de famille";
			this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
			this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// jobDataGridViewTextBoxColumn
			// 
			this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
			this.jobDataGridViewTextBoxColumn.HeaderText = "Poste / Fonction";
			this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
			this.jobDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telDataGridViewTextBoxColumn
			// 
			this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
			this.telDataGridViewTextBoxColumn.HeaderText = "Téléphone";
			this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
			this.telDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// employesBindingSource1
			// 
			this.employesBindingSource1.DataMember = "Employes";
			this.employesBindingSource1.DataSource = this.employesDataSet;
			// 
			// employesDataSet
			// 
			this.employesDataSet.DataSetName = "EmployesDataSet";
			this.employesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// MainScreenTopToolStrip
			// 
			this.MainScreenTopToolStrip.AllowMerge = false;
			this.MainScreenTopToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainScreenTopToolStrip.BackColor = System.Drawing.SystemColors.Control;
			this.MainScreenTopToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.MainScreenTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1,
            this.toolStripSeparator2,
            this.Menu2,
            this.toolStripSeparator3,
            this.Menu3});
			this.MainScreenTopToolStrip.Location = new System.Drawing.Point(3, 0);
			this.MainScreenTopToolStrip.Name = "MainScreenTopToolStrip";
			this.MainScreenTopToolStrip.Size = new System.Drawing.Size(247, 25);
			this.MainScreenTopToolStrip.TabIndex = 0;
			// 
			// Menu1
			// 
			this.Menu1.BackColor = System.Drawing.SystemColors.Control;
			this.Menu1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Menu1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.Menu1.Name = "Menu1";
			this.Menu1.Size = new System.Drawing.Size(44, 22);
			this.Menu1.Text = "Menu1";
			this.Menu1.Click += new System.EventHandler(this.Menu1_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// Menu2
			// 
			this.Menu2.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.Menu2.Name = "Menu2";
			this.Menu2.Size = new System.Drawing.Size(44, 22);
			this.Menu2.Text = "Menu2";
			this.Menu2.Click += new System.EventHandler(this.Menu2_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// Menu3
			// 
			this.Menu3.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.Menu3.Name = "Menu3";
			this.Menu3.Size = new System.Drawing.Size(44, 22);
			this.Menu3.Text = "Menu3";
			this.Menu3.Click += new System.EventHandler(this.Menu3_Click);
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
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "MainScreen";
			this.Text = "MainScreen";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employesDataSet)).EndInit();
			this.MainScreenTopToolStrip.ResumeLayout(false);
			this.MainScreenTopToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip MainScreenTopToolStrip;
		private System.Windows.Forms.ToolStripLabel Menu1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel Menu2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripLabel Menu3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private EmployesDataSet employesDataSet;
		private System.Windows.Forms.BindingSource employesBindingSource;
		private EmployesDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource employesBindingSource1;
	}
}