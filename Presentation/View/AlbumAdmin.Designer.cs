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
            pictureBoxImage = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            dataGridViewAlbums = new DataGridView();
            txtName = new TextBox();
            Buscar = new PictureBox();
            pictureBox3 = new PictureBox();
            btnEdit = new PictureBox();
            btnDelete = new PictureBox();
            txtId = new TextBox();
            txtUrl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
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
            // pictureBoxImage
            // 
            pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImage.Location = new Point(62, 95);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(216, 182);
            pictureBoxImage.TabIndex = 4;
            pictureBoxImage.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(110, 292);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 5;
            button1.Text = "upload Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += UploadImage_Click;
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
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(388, 258);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(256, 33);
            txtBuscar.TabIndex = 7;
            // 
            // dataGridViewAlbums
            // 
            dataGridViewAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbums.Location = new Point(62, 331);
            dataGridViewAlbums.Name = "dataGridViewAlbums";
            dataGridViewAlbums.RowTemplate.Height = 25;
            dataGridViewAlbums.Size = new Size(582, 238);
            dataGridViewAlbums.TabIndex = 8;
            dataGridViewAlbums.SelectionChanged += dataGridViewAlbums_SelectionChanged;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(388, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 33);
            txtName.TabIndex = 9;
            // 
            // Buscar
            // 
            Buscar.BorderStyle = BorderStyle.FixedSingle;
            Buscar.Image = Properties.Resources.busqueda__1_;
            Buscar.Location = new Point(597, 258);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(47, 33);
            Buscar.SizeMode = PictureBoxSizeMode.CenterImage;
            Buscar.TabIndex = 10;
            Buscar.TabStop = false;
            Buscar.Click += Buscar_Click;
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
            pictureBox3.Click += Save_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderStyle = BorderStyle.FixedSingle;
            btnEdit.Image = Properties.Resources.editar;
            btnEdit.Location = new Point(485, 182);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(67, 50);
            btnEdit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEdit.TabIndex = 12;
            btnEdit.TabStop = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderStyle = BorderStyle.FixedSingle;
            btnDelete.Image = Properties.Resources.borrar;
            btnDelete.Location = new Point(577, 182);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 50);
            btnDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDelete.TabIndex = 13;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(560, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 16);
            txtId.TabIndex = 14;
            // 
            // txtUrl
            // 
            txtUrl.AutoSize = true;
            txtUrl.ForeColor = Color.White;
            txtUrl.Location = new Point(440, 52);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(0, 15);
            txtUrl.TabIndex = 15;
            // 
            // AlbumAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtUrl);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox3);
            Controls.Add(Buscar);
            Controls.Add(txtName);
            Controls.Add(dataGridViewAlbums);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBoxImage);
            Controls.Add(label1);
            Name = "AlbumAdmin";
            Size = new Size(705, 650);
            Load += AlbumAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)Buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxImage;
        private Button button1;
        private Label label2;
        private TextBox txtBuscar;
        private TextBox txtName;
        private PictureBox Buscar;
        private PictureBox pictureBox3;
        private PictureBox btnEdit;
        private PictureBox btnDelete;
        public DataGridView dataGridViewAlbums;
        private TextBox txtId;
        private Label txtUrl;
        private TextBox hhhhh;
    }
}
