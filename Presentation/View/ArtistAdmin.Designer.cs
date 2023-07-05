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
			txtBuscar = new TextBox();
			txtName = new TextBox();
			label2 = new Label();
			btnbuscar = new PictureBox();
			dataGridViewArtists = new DataGridView();
			btnUploadImage = new Button();
			txtId = new TextBox();
			pictureBoxImage = new PictureBox();
			((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnbuscar).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewArtists).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
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
			// txtBuscar
			// 
			txtBuscar.BorderStyle = BorderStyle.FixedSingle;
			txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBuscar.ForeColor = Color.Black;
			txtBuscar.Location = new Point(393, 286);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(258, 33);
			txtBuscar.TabIndex = 8;
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
			// btnbuscar
			// 
			btnbuscar.BorderStyle = BorderStyle.FixedSingle;
			btnbuscar.Image = (Image)resources.GetObject("btnbuscar.Image");
			btnbuscar.Location = new Point(612, 286);
			btnbuscar.Name = "btnbuscar";
			btnbuscar.Size = new Size(39, 33);
			btnbuscar.SizeMode = PictureBoxSizeMode.CenterImage;
			btnbuscar.TabIndex = 11;
			btnbuscar.TabStop = false;
			btnbuscar.Click += btnbuscar_Click;
			// 
			// dataGridViewArtists
			// 
			dataGridViewArtists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewArtists.BackgroundColor = Color.White;
			dataGridViewArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewArtists.Location = new Point(55, 346);
			dataGridViewArtists.Name = "dataGridViewArtists";
			dataGridViewArtists.RowTemplate.Height = 25;
			dataGridViewArtists.Size = new Size(596, 220);
			dataGridViewArtists.TabIndex = 12;
			dataGridViewArtists.SelectionChanged += dataGridViewArtists_SelectionChanged;
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
			// pictureBoxImage
			// 
			pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxImage.Location = new Point(72, 90);
			pictureBoxImage.Name = "pictureBoxImage";
			pictureBoxImage.Size = new Size(211, 185);
			pictureBoxImage.TabIndex = 16;
			pictureBoxImage.TabStop = false;
			// 
			// ArtistAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pictureBoxImage);
			Controls.Add(txtId);
			Controls.Add(btnUploadImage);
			Controls.Add(dataGridViewArtists);
			Controls.Add(btnbuscar);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(txtBuscar);
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
			((System.ComponentModel.ISupportInitialize)btnbuscar).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewArtists).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox btnSave;
		private PictureBox btnDelete;
		private PictureBox btnEdit;
		private TextBox txtBuscar;
		private TextBox txtName;
		private Label label2;
		private PictureBox btnbuscar;
		private DataGridView dataGridViewArtists;
		private Button btnUploadImage;
		private TextBox txtId;
		private PictureBox pictureBoxImage;
	}
}
