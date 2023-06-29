namespace Presentation.View
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			panel1 = new Panel();
			txtPassword = new TextBox();
			label4 = new Label();
			label3 = new Label();
			button1 = new Button();
			label2 = new Label();
			label1 = new Label();
			txtUser = new TextBox();
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
			panel1.Controls.Add(txtPassword);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(txtUser);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(238, 62);
			panel1.Name = "panel1";
			panel1.Size = new Size(460, 498);
			panel1.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = BorderStyle.None;
			txtPassword.ForeColor = SystemColors.AppWorkspace;
			txtPassword.Location = new Point(160, 342);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(151, 16);
			txtPassword.TabIndex = 8;
			txtPassword.Text = "Password";
			txtPassword.Enter += txtPassword_Enter;
			txtPassword.Leave += txtPassword_Leave;
			// 
			// label4
			// 
			label4.BackColor = Color.Black;
			label4.Location = new Point(205, 469);
			label4.Name = "label4";
			label4.Size = new Size(60, 1);
			label4.TabIndex = 7;
			label4.Text = "label4";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(205, 449);
			label3.Name = "label3";
			label3.Size = new Size(63, 21);
			label3.TabIndex = 6;
			label3.Text = "Sign up";
			label3.Click += label3_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 0, 118);
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderColor = Color.Navy;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.Blue;
			button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(149, 395);
			button1.Name = "button1";
			button1.Size = new Size(183, 40);
			button1.TabIndex = 5;
			button1.Text = "Sign in";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(17, 0, 118);
			label2.Location = new Point(160, 361);
			label2.Name = "label2";
			label2.Size = new Size(150, 1);
			label2.TabIndex = 4;
			label2.Text = "label2";
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(160, 303);
			label1.Name = "label1";
			label1.Size = new Size(151, 1);
			label1.TabIndex = 2;
			label1.Text = "fgegeg";
			// 
			// txtUser
			// 
			txtUser.BorderStyle = BorderStyle.None;
			txtUser.ForeColor = SystemColors.AppWorkspace;
			txtUser.Location = new Point(160, 284);
			txtUser.Name = "txtUser";
			txtUser.Size = new Size(151, 16);
			txtUser.TabIndex = 1;
			txtUser.Text = "Username";
			txtUser.Enter += tbUser_Enter;
			txtUser.Leave += txtUser_Leave;
			// 
			// pictureBox1
			// 
			pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(149, 76);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(174, 152);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.eliminar_simbolo;
			pictureBox2.Location = new Point(891, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(31, 31);
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 0, 118);
			ClientSize = new Size(934, 611);
			Controls.Add(pictureBox2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Login_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		public TextBox txtUser;
		private PictureBox pictureBox1;
		public Button button1;
		private Label label2;
		private TextBox tbPassword;
		private Label label4;
		private Label label3;
		public TextBox txtPassword;
		private PictureBox pictureBox2;
	}
}