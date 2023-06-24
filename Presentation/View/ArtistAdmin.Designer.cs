namespace Presentation.View
{
	partial class ArtistAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistAdmin));
			label1 = new Label();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			pictureBox4 = new PictureBox();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(246, 29);
			label1.Name = "label1";
			label1.Size = new Size(152, 37);
			label1.TabIndex = 4;
			label1.Text = "ARTISTS";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(55, 143);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(55, 50);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.FixedSingle;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(258, 143);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(55, 50);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 6;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BorderStyle = BorderStyle.FixedSingle;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(156, 143);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(55, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 7;
			pictureBox3.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.AppWorkspace;
			textBox1.Location = new Point(426, 199);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(225, 33);
			textBox1.TabIndex = 8;
			textBox1.Text = "Search";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(428, 123);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(223, 33);
			textBox2.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(439, 114);
			label2.Name = "label2";
			label2.Size = new Size(82, 17);
			label2.TabIndex = 10;
			label2.Text = "Artist Name";
			// 
			// pictureBox4
			// 
			pictureBox4.BorderStyle = BorderStyle.FixedSingle;
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(612, 199);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(39, 33);
			pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox4.TabIndex = 11;
			pictureBox4.TabStop = false;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(55, 279);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(596, 220);
			dataGridView1.TabIndex = 12;
			// 
			// ArtistAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(dataGridView1);
			Controls.Add(pictureBox4);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Name = "ArtistAdmin";
			Size = new Size(705, 650);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private PictureBox pictureBox4;
		private DataGridView dataGridView1;
	}
}
