namespace Presentation.View
{
	partial class CategoryAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAdmin));
			label1 = new Label();
			dataGridViewCategory = new DataGridView();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			txtName = new TextBox();
			label2 = new Label();
			txtId = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(217, 42);
			label1.Name = "label1";
			label1.Size = new Size(223, 37);
			label1.TabIndex = 4;
			label1.Text = "CATEGORIES";
			// 
			// dataGridViewCategory
			// 
			dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCategory.BackgroundColor = Color.White;
			dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCategory.Location = new Point(38, 274);
			dataGridViewCategory.Name = "dataGridViewCategory";
			dataGridViewCategory.RowTemplate.Height = 25;
			dataGridViewCategory.Size = new Size(622, 297);
			dataGridViewCategory.TabIndex = 5;
			dataGridViewCategory.SelectionChanged += dataGridViewCategory_SelectionChanged;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.ActiveBorder;
			textBox1.Location = new Point(395, 220);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(265, 33);
			textBox1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(604, 220);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(56, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.FixedSingle;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(38, 203);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(64, 50);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.BorderStyle = BorderStyle.FixedSingle;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(141, 203);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(64, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 9;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.BorderStyle = BorderStyle.FixedSingle;
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(247, 203);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(64, 50);
			pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox4.TabIndex = 10;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click;
			// 
			// txtName
			// 
			txtName.BorderStyle = BorderStyle.FixedSingle;
			txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtName.Location = new Point(395, 174);
			txtName.Name = "txtName";
			txtName.Size = new Size(265, 27);
			txtName.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(395, 133);
			label2.Name = "label2";
			label2.Size = new Size(74, 25);
			label2.TabIndex = 12;
			label2.Text = "Name :";
			// 
			// txtId
			// 
			txtId.BorderStyle = BorderStyle.None;
			txtId.ForeColor = Color.White;
			txtId.Location = new Point(557, 83);
			txtId.Name = "txtId";
			txtId.Size = new Size(41, 16);
			txtId.TabIndex = 13;
			// 
			// CategoryAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(txtId);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(dataGridViewCategory);
			Controls.Add(label1);
			Name = "CategoryAdmin";
			Size = new Size(705, 650);
			Load += CategoryAdmin_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dataGridViewCategory;
		private TextBox textBox1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private TextBox txtName;
		private Label label2;
		private TextBox txtId;
	}
}
