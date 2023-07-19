namespace Presentation.View
{
	partial class MusicPlayer
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
			pbxImageSong = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			btnMenosVol = new Button();
			btnMoreVol = new Button();
			pictureBox1 = new PictureBox();
			lbSong = new Label();
			((System.ComponentModel.ISupportInitialize)pbxImageSong).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pbxImageSong
			// 
			pbxImageSong.Location = new Point(169, 73);
			pbxImageSong.Name = "pbxImageSong";
			pbxImageSong.Size = new Size(241, 207);
			pbxImageSong.TabIndex = 0;
			pbxImageSong.TabStop = false;
			// 
			// button1
			// 
			button1.Image = Properties.Resources.siguiente;
			button1.Location = new Point(334, 343);
			button1.Name = "button1";
			button1.Size = new Size(76, 59);
			button1.TabIndex = 1;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(236, 345);
			button2.Name = "button2";
			button2.Size = new Size(76, 59);
			button2.TabIndex = 2;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Image = Properties.Resources.atras;
			button3.Location = new Point(141, 345);
			button3.Name = "button3";
			button3.Size = new Size(76, 55);
			button3.TabIndex = 3;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// btnMenosVol
			// 
			btnMenosVol.Image = Properties.Resources.volumen_apagado;
			btnMenosVol.Location = new Point(40, 345);
			btnMenosVol.Name = "btnMenosVol";
			btnMenosVol.Size = new Size(76, 57);
			btnMenosVol.TabIndex = 4;
			btnMenosVol.UseVisualStyleBackColor = true;
			btnMenosVol.Click += btnMenosVol_Click;
			// 
			// btnMoreVol
			// 
			btnMoreVol.Image = Properties.Resources.volumen;
			btnMoreVol.Location = new Point(432, 346);
			btnMoreVol.Name = "btnMoreVol";
			btnMoreVol.Size = new Size(76, 57);
			btnMoreVol.TabIndex = 5;
			btnMoreVol.UseVisualStyleBackColor = true;
			btnMoreVol.Click += btnMoreVol_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.eliminar_simbolo__1_;
			pictureBox1.Location = new Point(532, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(48, 41);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// lbSong
			// 
			lbSong.AutoSize = true;
			lbSong.ForeColor = Color.FromArgb(192, 192, 255);
			lbSong.Location = new Point(44, 61);
			lbSong.Name = "lbSong";
			lbSong.Size = new Size(38, 15);
			lbSong.TabIndex = 7;
			lbSong.Text = "label1";
			// 
			// MusicPlayer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 192, 255);
			ClientSize = new Size(581, 450);
			Controls.Add(lbSong);
			Controls.Add(pictureBox1);
			Controls.Add(btnMoreVol);
			Controls.Add(btnMenosVol);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pbxImageSong);
			FormBorderStyle = FormBorderStyle.None;
			Name = "MusicPlayer";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MusicPlayer";
			Load += MusicPlayer_Load;
			((System.ComponentModel.ISupportInitialize)pbxImageSong).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button1;
		private Button button2;
		private Button button3;
		private Button btnMenosVol;
		private Button btnMoreVol;
		public PictureBox pbxImageSong;
		private PictureBox pictureBox1;
		public Label lbSong;
	}
}