namespace Presentation.View
{
	partial class SongUser
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongUser));
			label1 = new Label();
			panel1 = new Panel();
			pictureBox3 = new PictureBox();
			label4 = new Label();
			label3 = new Label();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(280, 30);
			label1.Name = "label1";
			label1.Size = new Size(130, 37);
			label1.TabIndex = 1;
			label1.Text = "SONGS";
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(81, 197);
			panel1.Name = "panel1";
			panel1.Size = new Size(557, 71);
			panel1.TabIndex = 2;
			// 
			// pictureBox3
			// 
			pictureBox3.BorderStyle = BorderStyle.Fixed3D;
			pictureBox3.Location = new Point(510, 22);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(30, 28);
			pictureBox3.TabIndex = 4;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(98, 43);
			label4.Name = "label4";
			label4.Size = new Size(35, 15);
			label4.TabIndex = 3;
			label4.Text = "Artist";
			label4.Click += label4_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(98, 22);
			label3.Name = "label3";
			label3.Size = new Size(81, 16);
			label3.TabIndex = 2;
			label3.Text = "Name Song";
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.FixedSingle;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(38, 16);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(46, 42);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(12, 25);
			label2.Name = "label2";
			label2.Size = new Size(20, 22);
			label2.TabIndex = 0;
			label2.Text = "1";
			label2.Click += label2_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.AppWorkspace;
			textBox1.Location = new Point(385, 114);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(253, 33);
			textBox1.TabIndex = 3;
			textBox1.Text = "Buscar";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(592, 114);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(46, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// SongUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(panel1);
			Controls.Add(label1);
			Name = "SongUser";
			Size = new Size(705, 650);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private TextBox textBox1;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label4;
		private Label label3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
	}
}
