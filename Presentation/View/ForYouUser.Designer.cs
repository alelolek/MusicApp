namespace Presentation.View
{
	partial class ForYouUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForYouUser));
			label12 = new Label();
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label3 = new Label();
			label2 = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.FromArgb(17, 0, 118);
			label12.Location = new Point(261, 34);
			label12.Name = "label12";
			label12.Size = new Size(157, 37);
			label12.TabIndex = 3;
			label12.Text = "FOR YOU";
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(83, 154);
			panel1.Name = "panel1";
			panel1.Size = new Size(535, 61);
			panel1.TabIndex = 4;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(485, 19);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(36, 30);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(80, 34);
			label3.Name = "label3";
			label3.Size = new Size(35, 15);
			label3.TabIndex = 3;
			label3.Text = "Artist";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(80, 12);
			label2.Name = "label2";
			label2.Size = new Size(87, 20);
			label2.TabIndex = 2;
			label2.Text = "Song Name";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(34, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(40, 37);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(16, 18);
			label1.TabIndex = 0;
			label1.Text = "1";
			// 
			// ForYouUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel1);
			Controls.Add(label12);
			Name = "ForYouUser";
			Size = new Size(705, 650);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label12;
		private Panel panel1;
		private Label label1;
		private PictureBox pictureBox2;
		private Label label3;
		private Label label2;
		private PictureBox pictureBox1;
	}
}
