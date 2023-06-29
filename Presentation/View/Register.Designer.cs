namespace Presentation.View
{
	partial class Register
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
			panel1 = new Panel();
			label6 = new Label();
			txtPassPrueba = new TextBox();
			label5 = new Label();
			label4 = new Label();
			button1 = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tbPassword = new TextBox();
			tbEmail = new TextBox();
			tbUser = new TextBox();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label6);
			panel1.Controls.Add(txtPassPrueba);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(tbPassword);
			panel1.Controls.Add(tbEmail);
			panel1.Controls.Add(tbUser);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(238, 62);
			panel1.Name = "panel1";
			panel1.Size = new Size(460, 498);
			panel1.TabIndex = 0;
			// 
			// label6
			// 
			label6.BackColor = Color.FromArgb(17, 0, 118);
			label6.Location = new Point(161, 381);
			label6.Name = "label6";
			label6.Size = new Size(150, 1);
			label6.TabIndex = 11;
			label6.Text = "label6";
			// 
			// txtPassPrueba
			// 
			txtPassPrueba.BorderStyle = BorderStyle.None;
			txtPassPrueba.ForeColor = SystemColors.AppWorkspace;
			txtPassPrueba.Location = new Point(161, 362);
			txtPassPrueba.Name = "txtPassPrueba";
			txtPassPrueba.Size = new Size(143, 16);
			txtPassPrueba.TabIndex = 10;
			txtPassPrueba.Text = "Repeat Password";
			txtPassPrueba.Enter += txtPassPrueba_Enter;
			txtPassPrueba.Leave += txtPassPrueba_Leave;
			// 
			// label5
			// 
			label5.BackColor = Color.Black;
			label5.Location = new Point(222, 477);
			label5.Name = "label5";
			label5.Size = new Size(52, 1);
			label5.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(220, 457);
			label4.Name = "label4";
			label4.RightToLeft = RightToLeft.Yes;
			label4.Size = new Size(54, 20);
			label4.TabIndex = 8;
			label4.Text = "Sign in";
			label4.Click += label4_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 0, 118);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.Blue;
			button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
			button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(148, 411);
			button1.Name = "button1";
			button1.Size = new Size(191, 43);
			button1.TabIndex = 7;
			button1.Text = "Sign up";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.BackColor = Color.FromArgb(17, 0, 118);
			label3.Location = new Point(161, 332);
			label3.Name = "label3";
			label3.Size = new Size(150, 1);
			label3.TabIndex = 6;
			label3.Text = "label3";
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(17, 0, 118);
			label2.Location = new Point(161, 283);
			label2.Name = "label2";
			label2.Size = new Size(150, 1);
			label2.TabIndex = 5;
			label2.Text = "label2";
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(17, 0, 118);
			label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(161, 235);
			label1.Name = "label1";
			label1.Size = new Size(150, 1);
			label1.TabIndex = 4;
			label1.Text = "label1";
			// 
			// tbPassword
			// 
			tbPassword.BorderStyle = BorderStyle.None;
			tbPassword.ForeColor = SystemColors.AppWorkspace;
			tbPassword.Location = new Point(161, 313);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(143, 16);
			tbPassword.TabIndex = 3;
			tbPassword.Text = "Password";
			tbPassword.Enter += tbPassword_Enter;
			tbPassword.Leave += tbPassword_Leave;
			// 
			// tbEmail
			// 
			tbEmail.BorderStyle = BorderStyle.None;
			tbEmail.ForeColor = SystemColors.AppWorkspace;
			tbEmail.Location = new Point(161, 264);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(143, 16);
			tbEmail.TabIndex = 2;
			tbEmail.Text = "Email";
			tbEmail.Enter += tbEmail_Enter;
			tbEmail.Leave += tbEmail_Leave;
			// 
			// tbUser
			// 
			tbUser.BorderStyle = BorderStyle.None;
			tbUser.ForeColor = SystemColors.AppWorkspace;
			tbUser.Location = new Point(161, 216);
			tbUser.Name = "tbUser";
			tbUser.Size = new Size(143, 16);
			tbUser.TabIndex = 1;
			tbUser.Text = "Username";
			tbUser.Enter += tbUser_Enter;
			tbUser.Leave += tbUser_Leave;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(148, 42);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(173, 149);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.eliminar_simbolo;
			pictureBox2.Location = new Point(889, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(33, 35);
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 0, 118);
			ClientSize = new Size(934, 611);
			Controls.Add(pictureBox2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Register";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Register";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label5;
		private Label label4;
		private Button button1;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox tbPassword;
		private TextBox tbEmail;
		private TextBox tbUser;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label6;
		private TextBox txtPassPrueba;
	}
}