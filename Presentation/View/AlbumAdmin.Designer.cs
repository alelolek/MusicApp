namespace Presentation.View
{
	partial class AlbumAdmin
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
			label1 = new Label();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			label2 = new Label();
			textBox1 = new TextBox();
			dataGridViewAlbums = new DataGridView();
			textBox2 = new TextBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(250, 35);
			label1.Name = "label1";
			label1.Size = new Size(152, 37);
			label1.TabIndex = 3;
			label1.Text = "ALBUMS";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(62, 95);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(216, 182);
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(110, 292);
			button1.Name = "button1";
			button1.Size = new Size(124, 23);
			button1.TabIndex = 5;
			button1.Text = "upload Image";
			button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(388, 95);
			label2.Name = "label2";
			label2.Size = new Size(84, 17);
			label2.TabIndex = 6;
			label2.Text = "Album Name";
			label2.Click += label2_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(388, 258);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(256, 33);
			textBox1.TabIndex = 7;
			textBox1.Text = "Buscar";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// dataGridViewAlbums
			// 
			dataGridViewAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewAlbums.Location = new Point(62, 331);
			dataGridViewAlbums.Name = "dataGridViewAlbums";
			dataGridViewAlbums.RowTemplate.Height = 25;
			dataGridViewAlbums.Size = new Size(582, 169);
			dataGridViewAlbums.TabIndex = 8;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(388, 115);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(256, 33);
			textBox2.TabIndex = 9;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.FixedSingle;
			pictureBox2.Image = Properties.Resources.busqueda__1_;
			pictureBox2.Location = new Point(597, 258);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(47, 33);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 10;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.BorderStyle = BorderStyle.FixedSingle;
			pictureBox3.Image = Properties.Resources.boton_mas;
			pictureBox3.Location = new Point(388, 182);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(67, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 11;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BorderStyle = BorderStyle.FixedSingle;
			pictureBox4.Image = Properties.Resources.editar;
			pictureBox4.Location = new Point(485, 182);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(67, 50);
			pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox4.TabIndex = 12;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.BorderStyle = BorderStyle.FixedSingle;
			pictureBox5.Image = Properties.Resources.borrar;
			pictureBox5.Location = new Point(577, 182);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(67, 50);
			pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox5.TabIndex = 13;
			pictureBox5.TabStop = false;
			// 
			// AlbumAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(textBox2);
			Controls.Add(dataGridViewAlbums);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Name = "AlbumAdmin";
			Size = new Size(705, 650);
			Load += AlbumAdmin_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private Button button1;
		private Label label2;
		private TextBox textBox1;
		private TextBox textBox2;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		public DataGridView dataGridViewAlbums;
	}
}
