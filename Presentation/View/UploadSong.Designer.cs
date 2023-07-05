namespace Presentation.View
{
	partial class UploadSong
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button2 = new Button();
			pictureBoxImage = new PictureBox();
			cbxCategories = new ComboBox();
			cbxAlbum = new ComboBox();
			category = new Label();
			Album = new Label();
			cbxArtist = new ComboBox();
			artist = new Label();
			name = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			pictureBox2 = new PictureBox();
			button1 = new Button();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(17, 0, 118);
			button2.FlatStyle = FlatStyle.Popup;
			button2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(272, 469);
			button2.Name = "button2";
			button2.Size = new Size(239, 48);
			button2.TabIndex = 26;
			button2.Text = "Save Song";
			button2.UseVisualStyleBackColor = false;
			// 
			// pictureBoxImage
			// 
			pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxImage.Location = new Point(76, 110);
			pictureBoxImage.Name = "pictureBoxImage";
			pictureBoxImage.Size = new Size(268, 227);
			pictureBoxImage.TabIndex = 24;
			pictureBoxImage.TabStop = false;
			// 
			// cbxCategories
			// 
			cbxCategories.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cbxCategories.FormattingEnabled = true;
			cbxCategories.Location = new Point(386, 386);
			cbxCategories.Name = "cbxCategories";
			cbxCategories.Size = new Size(246, 33);
			cbxCategories.TabIndex = 23;
			// 
			// cbxAlbum
			// 
			cbxAlbum.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cbxAlbum.FormattingEnabled = true;
			cbxAlbum.Location = new Point(386, 300);
			cbxAlbum.Name = "cbxAlbum";
			cbxAlbum.Size = new Size(246, 33);
			cbxAlbum.TabIndex = 22;
			cbxAlbum.SelectedIndexChanged += cbxAlbum_SelectedIndexChanged;
			// 
			// category
			// 
			category.AutoSize = true;
			category.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			category.Location = new Point(386, 358);
			category.Name = "category";
			category.Size = new Size(94, 25);
			category.TabIndex = 21;
			category.Text = "Category";
			// 
			// Album
			// 
			Album.AutoSize = true;
			Album.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			Album.Location = new Point(386, 272);
			Album.Name = "Album";
			Album.Size = new Size(71, 25);
			Album.TabIndex = 20;
			Album.Text = "Album";
			Album.Click += label4_Click;
			// 
			// cbxArtist
			// 
			cbxArtist.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cbxArtist.FormattingEnabled = true;
			cbxArtist.Location = new Point(386, 219);
			cbxArtist.Name = "cbxArtist";
			cbxArtist.Size = new Size(246, 33);
			cbxArtist.TabIndex = 19;
			// 
			// artist
			// 
			artist.AutoSize = true;
			artist.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			artist.Location = new Point(386, 191);
			artist.Name = "artist";
			artist.Size = new Size(61, 25);
			artist.TabIndex = 18;
			artist.Text = "Artist";
			// 
			// name
			// 
			name.AutoSize = true;
			name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			name.Location = new Point(386, 100);
			name.Name = "name";
			name.Size = new Size(116, 25);
			name.TabIndex = 17;
			name.Text = "Song Name";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = Color.Black;
			textBox1.Location = new Point(386, 138);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(246, 33);
			textBox1.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(289, 36);
			label1.Name = "label1";
			label1.Size = new Size(149, 37);
			label1.TabIndex = 15;
			label1.Text = "UPLOAD";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.eliminar_simbolo__1_;
			pictureBox2.Location = new Point(687, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(35, 32);
			pictureBox2.TabIndex = 27;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 0, 100);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(201, 367);
			button1.Name = "button1";
			button1.Size = new Size(143, 40);
			button1.TabIndex = 25;
			button1.Text = "Upload Song";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// panel1
			// 
			panel1.Location = new Point(76, 367);
			panel1.Name = "panel1";
			panel1.Size = new Size(51, 40);
			panel1.TabIndex = 28;
			panel1.Click += panel1_Click;
			panel1.Paint += panel1_Paint;
			// 
			// UploadSong
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(734, 561);
			Controls.Add(panel1);
			Controls.Add(pictureBox2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBoxImage);
			Controls.Add(cbxCategories);
			Controls.Add(cbxAlbum);
			Controls.Add(category);
			Controls.Add(Album);
			Controls.Add(cbxArtist);
			Controls.Add(artist);
			Controls.Add(name);
			Controls.Add(textBox1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "UploadSong";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UploadSong";
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private PictureBox pictureBoxImage;
		private ComboBox cbxCategories;
		private ComboBox cbxAlbum;
		private Label category;
		private Label Album;
		private ComboBox cbxArtist;
		private Label artist;
		private Label name;
		private TextBox textBox1;
		private Label label1;
		private PictureBox pictureBox2;
		private Button button1;
		private Panel panel1;
	}
}