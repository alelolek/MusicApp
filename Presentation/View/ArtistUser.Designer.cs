namespace Presentation.View
{
	partial class ArtistUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistUser));
			label1 = new Label();
			textBox1 = new TextBox();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(272, 35);
			label1.Name = "label1";
			label1.Size = new Size(131, 37);
			label1.TabIndex = 0;
			label1.Text = "ARTIST";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.AppWorkspace;
			textBox1.Location = new Point(399, 119);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(253, 33);
			textBox1.TabIndex = 1;
			textBox1.Text = "Buscar";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// panel1
			// 
			panel1.Location = new Point(69, 209);
			panel1.Name = "panel1";
			panel1.Size = new Size(118, 100);
			panel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(613, 119);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(39, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// ArtistUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ArtistUser";
			Size = new Size(705, 650);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Panel panel1;
		private PictureBox pictureBox1;
	}
}
