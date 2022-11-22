namespace FeuilleDeTemps
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.LoginGroupBox = new System.Windows.Forms.GroupBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.pwdTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LoginGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginGroupBox
			// 
			this.LoginGroupBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.LoginGroupBox.Controls.Add(this.loginButton);
			this.LoginGroupBox.Controls.Add(this.pwdTextBox);
			this.LoginGroupBox.Controls.Add(this.label2);
			this.LoginGroupBox.Controls.Add(this.idTextBox);
			this.LoginGroupBox.Controls.Add(this.label1);
			this.LoginGroupBox.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
			this.LoginGroupBox.Location = new System.Drawing.Point(297, 12);
			this.LoginGroupBox.Name = "LoginGroupBox";
			this.LoginGroupBox.Size = new System.Drawing.Size(270, 270);
			this.LoginGroupBox.TabIndex = 1;
			this.LoginGroupBox.TabStop = false;
			this.LoginGroupBox.Text = "LOGIN";
			// 
			// loginButton
			// 
			this.loginButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.Location = new System.Drawing.Point(57, 215);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(154, 37);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Connection";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// pwdTextBox
			// 
			this.pwdTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.pwdTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwdTextBox.Location = new System.Drawing.Point(6, 161);
			this.pwdTextBox.Name = "pwdTextBox";
			this.pwdTextBox.PasswordChar = '*';
			this.pwdTextBox.Size = new System.Drawing.Size(205, 27);
			this.pwdTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mot de passe";
			// 
			// idTextBox
			// 
			this.idTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.idTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idTextBox.Location = new System.Drawing.Point(6, 89);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(205, 27);
			this.idTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identifiant";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pictureBox1.Image = global::FeuilleDeTemps.Properties.Resources.PMI_logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(270, 270);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
			this.ClientSize = new System.Drawing.Size(580, 294);
			this.Controls.Add(this.LoginGroupBox);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Feuille De Temps";
			this.LoginGroupBox.ResumeLayout(false);
			this.LoginGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox LoginGroupBox;
		private System.Windows.Forms.TextBox pwdTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button loginButton;
	}
}

