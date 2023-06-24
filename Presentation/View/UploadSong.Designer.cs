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
			button1 = new Button();
			pictureBox1 = new PictureBox();
			comboBox3 = new ComboBox();
			comboBox2 = new ComboBox();
			category = new Label();
			Album = new Label();
			comboBox1 = new ComboBox();
			artist = new Label();
			name = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
			// button1
			// 
			button1.BackColor = Color.FromArgb(17, 0, 100);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(139, 352);
			button1.Name = "button1";
			button1.Size = new Size(143, 40);
			button1.TabIndex = 25;
			button1.Text = "Upload Image";
			button1.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(76, 110);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(268, 227);
			pictureBox1.TabIndex = 24;
			pictureBox1.TabStop = false;
			// 
			// comboBox3
			// 
			comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(386, 386);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(246, 33);
			comboBox3.TabIndex = 23;
			// 
			// comboBox2
			// 
			comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(386, 300);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(246, 33);
			comboBox2.TabIndex = 22;
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
			// comboBox1
			// 
			comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(386, 219);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(246, 33);
			comboBox1.TabIndex = 19;
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
			name.Location = new Point(386, 110);
			name.Name = "name";
			name.Size = new Size(116, 25);
			name.TabIndex = 17;
			name.Text = "Song Name";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.ForeColor = SystemColors.AppWorkspace;
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
			// UploadSong
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(734, 561);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Controls.Add(comboBox3);
			Controls.Add(comboBox2);
			Controls.Add(category);
			Controls.Add(Album);
			Controls.Add(comboBox1);
			Controls.Add(artist);
			Controls.Add(name);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "UploadSong";
			Text = "UploadSong";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private PictureBox pictureBox1;
		private ComboBox comboBox3;
		private ComboBox comboBox2;
		private Label category;
		private Label Album;
		private ComboBox comboBox1;
		private Label artist;
		private Label name;
		private TextBox textBox1;
		private Label label1;
	}
}