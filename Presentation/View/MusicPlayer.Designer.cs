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
			((System.ComponentModel.ISupportInitialize)pbxImageSong).BeginInit();
			SuspendLayout();
			// 
			// pbxImageSong
			// 
			pbxImageSong.Location = new Point(156, 55);
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
			// 
			// button2
			// 
			button2.Location = new Point(236, 345);
			button2.Name = "button2";
			button2.Size = new Size(76, 59);
			button2.TabIndex = 2;
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Image = Properties.Resources.atras;
			button3.Location = new Point(141, 345);
			button3.Name = "button3";
			button3.Size = new Size(76, 55);
			button3.TabIndex = 3;
			button3.UseVisualStyleBackColor = true;
			// 
			// btnMenosVol
			// 
			btnMenosVol.Image = Properties.Resources.volumen_apagado;
			btnMenosVol.Location = new Point(40, 345);
			btnMenosVol.Name = "btnMenosVol";
			btnMenosVol.Size = new Size(76, 57);
			btnMenosVol.TabIndex = 4;
			btnMenosVol.UseVisualStyleBackColor = true;
			// 
			// btnMoreVol
			// 
			btnMoreVol.Image = Properties.Resources.volumen;
			btnMoreVol.Location = new Point(432, 346);
			btnMoreVol.Name = "btnMoreVol";
			btnMoreVol.Size = new Size(76, 57);
			btnMoreVol.TabIndex = 5;
			btnMoreVol.UseVisualStyleBackColor = true;
			// 
			// MusicPlayer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(581, 450);
			Controls.Add(btnMoreVol);
			Controls.Add(btnMenosVol);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pbxImageSong);
			Name = "MusicPlayer";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MusicPlayer";
			((System.ComponentModel.ISupportInitialize)pbxImageSong).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbxImageSong;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button btnMenosVol;
		private Button btnMoreVol;
	}
}