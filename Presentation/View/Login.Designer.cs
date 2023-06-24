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
			label4 = new Label();
			label3 = new Label();
			button1 = new Button();
			label2 = new Label();
			tbPassword = new TextBox();
			label1 = new Label();
			tbUser = new TextBox();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(tbPassword);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(tbUser);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(238, 62);
			panel1.Name = "panel1";
			panel1.Size = new Size(460, 498);
			panel1.TabIndex = 0;
			// 
			// label4
			// 
			label4.BackColor = Color.Black;
			label4.Location = new Point(186, 469);
			label4.Name = "label4";
			label4.Size = new Size(60, 1);
			label4.TabIndex = 7;
			label4.Text = "label4";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(186, 449);
			label3.Name = "label3";
			label3.Size = new Size(63, 21);
			label3.TabIndex = 6;
			label3.Text = "Sign up";
			label3.Click += label3_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 0, 118);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(149, 397);
			button1.Name = "button1";
			button1.Size = new Size(151, 40);
			button1.TabIndex = 5;
			button1.Text = "Sign in";
			button1.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(17, 0, 118);
			label2.Location = new Point(149, 369);
			label2.Name = "label2";
			label2.Size = new Size(150, 1);
			label2.TabIndex = 4;
			label2.Text = "label2";
			// 
			// tbPassword
			// 
			tbPassword.BorderStyle = BorderStyle.None;
			tbPassword.ForeColor = SystemColors.AppWorkspace;
			tbPassword.Location = new Point(149, 350);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(100, 16);
			tbPassword.TabIndex = 3;
			tbPassword.Text = "Password";
			tbPassword.MouseEnter += textBox2_MouseEnter;
			tbPassword.MouseLeave += textBox2_MouseLeave;
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(149, 311);
			label1.Name = "label1";
			label1.Size = new Size(151, 1);
			label1.TabIndex = 2;
			label1.Text = "fgegeg";
			// 
			// tbUser
			// 
			tbUser.BorderStyle = BorderStyle.None;
			tbUser.ForeColor = SystemColors.AppWorkspace;
			tbUser.Location = new Point(149, 292);
			tbUser.Name = "tbUser";
			tbUser.Size = new Size(151, 16);
			tbUser.TabIndex = 1;
			tbUser.Text = "Username";
			tbUser.MouseEnter += tbUser_MouseEnter;
			tbUser.MouseLeave += textBox1_MouseLeave;
			// 
			// pictureBox1
			// 
			pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(163, 85);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(151, 142);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 0, 118);
			ClientSize = new Size(934, 611);
			Controls.Add(panel1);
			Name = "Login";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private TextBox tbUser;
		private PictureBox pictureBox1;
		private Button button1;
		private Label label2;
		private TextBox tbPassword;
		private Label label4;
		private Label label3;
	}
}