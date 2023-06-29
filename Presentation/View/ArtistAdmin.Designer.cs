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
			btnSave = new PictureBox();
			btnDelete = new PictureBox();
			btnEdit = new PictureBox();
			textBox1 = new TextBox();
			txtName = new TextBox();
			label2 = new Label();
			pictureBox4 = new PictureBox();
			dataGridViewArtists = new DataGridView();
			panel1 = new Panel();
			btnUploadImage = new Button();
			txtId = new TextBox();
			((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewArtists).BeginInit();
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
			// btnSave
			// 
			btnSave.BorderStyle = BorderStyle.FixedSingle;
			btnSave.Image = (Image)resources.GetObject("btnSave.Image");
			btnSave.Location = new Point(393, 194);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(55, 50);
			btnSave.SizeMode = PictureBoxSizeMode.CenterImage;
			btnSave.TabIndex = 5;
			btnSave.TabStop = false;
			btnSave.Click += btnSave_Click;
			// 
			// btnDelete
			// 
			btnDelete.BorderStyle = BorderStyle.FixedSingle;
			btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
			btnDelete.Location = new Point(596, 194);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(55, 50);
			btnDelete.SizeMode = PictureBoxSizeMode.CenterImage;
			btnDelete.TabIndex = 6;
			btnDelete.TabStop = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.BorderStyle = BorderStyle.FixedSingle;
			btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
			btnEdit.Location = new Point(499, 194);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(55, 50);
			btnEdit.SizeMode = PictureBoxSizeMode.CenterImage;
			btnEdit.TabIndex = 7;
			btnEdit.TabStop = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.AppWorkspace;
			textBox1.Location = new Point(393, 286);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(258, 33);
			textBox1.TabIndex = 8;
			// 
			// txtName
			// 
			txtName.BorderStyle = BorderStyle.FixedSingle;
			txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtName.Location = new Point(393, 122);
			txtName.Name = "txtName";
			txtName.Size = new Size(258, 33);
			txtName.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(393, 90);
			label2.Name = "label2";
			label2.Size = new Size(82, 17);
			label2.TabIndex = 10;
			label2.Text = "Artist Name";
			// 
			// pictureBox4
			// 
			pictureBox4.BorderStyle = BorderStyle.FixedSingle;
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(612, 286);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(39, 33);
			pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox4.TabIndex = 11;
			pictureBox4.TabStop = false;
			// 
			// dataGridViewArtists
			// 
			dataGridViewArtists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewArtists.Location = new Point(55, 346);
			dataGridViewArtists.Name = "dataGridViewArtists";
			dataGridViewArtists.RowTemplate.Height = 25;
			dataGridViewArtists.Size = new Size(596, 220);
			dataGridViewArtists.TabIndex = 12;
			dataGridViewArtists.SelectionChanged += dataGridViewArtists_SelectionChanged;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Location = new Point(83, 102);
			panel1.Name = "panel1";
			panel1.Size = new Size(200, 178);
			panel1.TabIndex = 13;
			// 
			// btnUploadImage
			// 
			btnUploadImage.Location = new Point(117, 296);
			btnUploadImage.Name = "btnUploadImage";
			btnUploadImage.Size = new Size(129, 23);
			btnUploadImage.TabIndex = 14;
			btnUploadImage.Text = "Upload Image";
			btnUploadImage.UseVisualStyleBackColor = true;
			btnUploadImage.Click += btnUploadImage_Click;
			// 
			// txtId
			// 
			txtId.BorderStyle = BorderStyle.None;
			txtId.ForeColor = Color.White;
			txtId.Location = new Point(546, 60);
			txtId.Name = "txtId";
			txtId.Size = new Size(100, 16);
			txtId.TabIndex = 15;
			// 
			// ArtistAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(txtId);
			Controls.Add(btnUploadImage);
			Controls.Add(panel1);
			Controls.Add(dataGridViewArtists);
			Controls.Add(pictureBox4);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(textBox1);
			Controls.Add(btnEdit);
			Controls.Add(btnDelete);
			Controls.Add(btnSave);
			Controls.Add(label1);
			Name = "ArtistAdmin";
			Size = new Size(705, 650);
			Load += ArtistAdmin_Load;
			((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
			((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
			((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewArtists).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox btnSave;
		private PictureBox btnDelete;
		private PictureBox btnEdit;
		private TextBox textBox1;
		private TextBox txtName;
		private Label label2;
		private PictureBox pictureBox4;
		private DataGridView dataGridViewArtists;
		private Panel panel1;
		private Button btnUploadImage;
		private TextBox txtId;
	}
}
