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
			label5 = new Label();
			label4 = new Label();
			button1 = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(textBox3);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(232, 49);
			panel1.Name = "panel1";
			panel1.Size = new Size(460, 498);
			panel1.TabIndex = 0;
			// 
			// label5
			// 
			label5.BackColor = Color.Black;
			label5.Location = new Point(205, 467);
			label5.Name = "label5";
			label5.Size = new Size(52, 1);
			label5.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(203, 447);
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
			button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(161, 401);
			button1.Name = "button1";
			button1.Size = new Size(143, 43);
			button1.TabIndex = 7;
			button1.Text = "Sign up";
			button1.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.BackColor = Color.FromArgb(17, 0, 118);
			label3.Location = new Point(161, 375);
			label3.Name = "label3";
			label3.Size = new Size(150, 1);
			label3.TabIndex = 6;
			label3.Text = "label3";
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(17, 0, 118);
			label2.Location = new Point(161, 320);
			label2.Name = "label2";
			label2.Size = new Size(150, 1);
			label2.TabIndex = 5;
			label2.Text = "label2";
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(17, 0, 118);
			label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(161, 272);
			label1.Name = "label1";
			label1.Size = new Size(150, 1);
			label1.TabIndex = 4;
			label1.Text = "label1";
			// 
			// textBox3
			// 
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.ForeColor = SystemColors.AppWorkspace;
			textBox3.Location = new Point(161, 356);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(143, 16);
			textBox3.TabIndex = 3;
			textBox3.Text = "Password";
			// 
			// textBox2
			// 
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.ForeColor = SystemColors.AppWorkspace;
			textBox2.Location = new Point(161, 301);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(143, 16);
			textBox2.TabIndex = 2;
			textBox2.Text = "Email";
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.ForeColor = SystemColors.AppWorkspace;
			textBox1.Location = new Point(161, 253);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(143, 16);
			textBox1.TabIndex = 1;
			textBox1.Text = "Username";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(178, 52);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(143, 136);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(17, 0, 118);
			ClientSize = new Size(934, 611);
			Controls.Add(panel1);
			Name = "Register";
			Text = "Register";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private PictureBox pictureBox1;
	}
}