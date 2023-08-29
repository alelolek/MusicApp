namespace Presentation.View
{
    partial class SongAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongAdmin));
            label1 = new Label();
            txtBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            dgvSongs = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnAddSong = new PictureBox();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddSong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(17, 0, 118);
            label1.Location = new Point(269, 33);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 2;
            label1.Text = "SONGS";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(403, 124);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(245, 33);
            txtBuscar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(615, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dgvSongs
            // 
            dgvSongs.BackgroundColor = Color.White;
            dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongs.Location = new Point(61, 192);
            dgvSongs.Name = "dgvSongs";
            dgvSongs.RowTemplate.Height = 25;
            dgvSongs.Size = new Size(587, 300);
            dgvSongs.TabIndex = 5;
            dgvSongs.SelectionChanged += dgvSongs_SelectionChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(227, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(145, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnAddSong
            // 
            btnAddSong.BorderStyle = BorderStyle.FixedSingle;
            btnAddSong.Image = (Image)resources.GetObject("btnAddSong.Image");
            btnAddSong.Location = new Point(61, 124);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(53, 43);
            btnAddSong.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAddSong.TabIndex = 8;
            btnAddSong.TabStop = false;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(362, 558);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 16);
            txtId.TabIndex = 9;
            // 
            // SongAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtId);
            Controls.Add(btnAddSong);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(dgvSongs);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Name = "SongAdmin";
            Size = new Size(705, 650);
            Load += SongAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddSong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox btnAddSong;
        public DataGridView dgvSongs;
        private TextBox txtBuscar;
        private TextBox txtId;
    }
}
