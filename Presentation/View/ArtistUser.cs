using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class ArtistUser : UserControl
	{
		private IArtistService artistService;
		public ArtistUser()
		{
			InitializeComponent();
			artistService = new ArtistService();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void ArtistUser_Load(object sender, EventArgs e)
		{
			var listaArtistas = artistService.GetAllArtist();   // Obtén tu lista de objetos de canciones

			foreach (var cancion in listaArtistas)
			{
				Panel panel = CrearPanelCancion(cancion); // Crea un panel para cada canción
				flowLayoutPanel1.Controls.Add(panel); // Agrega el panel al FlowLayoutPanel
			}
		}

		private Panel CrearPanelCancion(ArtistDto artists)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.Beige;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Padding = new Padding(20);

			Label lblNombre = new Label();
			lblNombre.Text = artists.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 16, FontStyle.Bold); // Tamaño de fuente y estilo
			lblNombre.TextAlign = ContentAlignment.MiddleCenter;



			// Agrega más controles o información de la canción según tus necesidades

			panel.Controls.Add(lblNombre);

			return panel;
		}
	}
}
