namespace Presentation.View
{
	partial class CategoriesUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesUser));
			label12 = new Label();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.FromArgb(17, 0, 118);
			label12.Location = new Point(230, 24);
			label12.Name = "label12";
			label12.Size = new Size(223, 37);
			label12.TabIndex = 3;
			label12.Text = "CATEGORIES";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(399, 119);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(266, 33);
			textBox1.TabIndex = 4;
			textBox1.Text = "Buscar";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(613, 119);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(52, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// panel1
			// 
			panel1.Location = new Point(100, 227);
			panel1.Name = "panel1";
			panel1.Size = new Size(136, 111);
			panel1.TabIndex = 6;
			// 
			// CategoriesUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(label12);
			Name = "CategoriesUser";
			Size = new Size(705, 650);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label12;
		private TextBox textBox1;
		private PictureBox pictureBox1;
		private Panel panel1;
	}
}
