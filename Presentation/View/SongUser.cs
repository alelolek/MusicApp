using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View
{
	public partial class SongUser : UserControl
	{
		public SongUser()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		////private void RecargarCanciones()
		////{
		////	int numero = 0;
		////	var listaCanciones = songService.GetAllSong();
		////	foreach (var cancion in listaCanciones)
		////	{
		////		numero++;
		////		Panel panel = CrearPanelCancion(cancion, numero);
		////		flowLayoutPanel1.Controls.Add(panel);
		////	}
		////}

		//private Panel CrearPanelCancion(SongDto cancion, int numero)
		//{
		//	Panel panel = new Panel();
		//	panel.BackColor = Color.White;
		//	panel.BorderStyle = BorderStyle.FixedSingle;
		//	panel.Width = 500;
		//	panel.Height = 100;

		//	// Texto izquierdo (número)
		//	Label numeroLabel = new Label();
		//	numeroLabel.Text = numero.ToString();
		//	numeroLabel.Font = new Font("Arial", 12, FontStyle.Bold);
		//	numeroLabel.Location = new Point(10, 10);
		//	numeroLabel.AutoSize = true;
		//	panel.Controls.Add(numeroLabel);

		//	// PictureBox izquierdo
		//	PictureBox pictureBoxIzquierdo = new PictureBox();
		//	//pictureBoxIzquierdo.Image = Properties.Resources.play;
		//	pictureBoxIzquierdo.SizeMode = PictureBoxSizeMode.Zoom;
		//	pictureBoxIzquierdo.Width = 80;
		//	pictureBoxIzquierdo.Height = 80;
		//	pictureBoxIzquierdo.Location = new Point(100, 10);
		//	panel.Controls.Add(pictureBoxIzquierdo);

		//	// Texto derecho
		//	Label textoDerechoLabel = new Label();
		//	textoDerechoLabel.Text = cancion.Name;
		//	textoDerechoLabel.Font = new Font("Arial", 14, FontStyle.Bold);
		//	textoDerechoLabel.Location = new Point(200, 10);
		//	textoDerechoLabel.AutoSize = true;
		//	panel.Controls.Add(textoDerechoLabel);

		//	// PictureBox derecho
		//	PictureBox pictureBoxDerecho = new PictureBox();
		//	//pictureBoxDerecho.Image = ObtenerImagenArtista(cancion); // Obtén la imagen del artista desde algún lugar
		//	pictureBoxDerecho.SizeMode = PictureBoxSizeMode.Zoom;
		//	pictureBoxDerecho.Width = 80;
		//	pictureBoxDerecho.Height = 80;
		//	pictureBoxDerecho.Location = new Point(300, 10);
		//	panel.Controls.Add(pictureBoxDerecho);

		//	return panel;
		//}
	}
}
