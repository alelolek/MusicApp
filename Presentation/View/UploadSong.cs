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
using Infraestructure.Entities;
using NAudio.Wave;

namespace Presentation.View
{
	public partial class UploadSong : Form
	{
		private readonly IArtistService artistService;
		private readonly IAlbumService albumService;
		private readonly ICategoryService categoryService;
		
		
		public UploadSong()
		{
			InitializeComponent();
			artistService = new ArtistService();
			albumService = new AlbumService();
			categoryService = new CategoryService();


			var artists = artistService.GetAllArtist();
			cbxArtist.DataSource = artists.Select(a => a.Name).ToList();

			var albums = albumService.GetAllAlbums();
			cbxAlbum.DataSource = albums.Select(album => album.Name).ToList();

			var categories = categoryService.GetAllCategory();
			cbxCategories.DataSource = categories.Select(category => category.Name).ToList();



		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbxAlbum_SelectedIndexChanged(object sender, EventArgs e)
		{
			string opcionSeleccionada = cbxAlbum.SelectedItem.ToString();

			var albums = albumService.GetAllAlbums();
			var albumSeleccionado = albums.FirstOrDefault(a => a.Name == opcionSeleccionada);

			if (albumSeleccionado != null)
			{
				pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
				Image imagenAlbum = ConvertirBytesAImagen(albumSeleccionado.Photo);
				pictureBoxImage.Image = imagenAlbum;
			}
			else
			{
				pictureBoxImage.BackgroundImage = null;
			}
		}
		public Image ConvertirBytesAImagen(byte[] imagenBytes)
		{
			using (MemoryStream ms = new MemoryStream(imagenBytes))
			{
				Image imagen = Image.FromStream(ms);
				return imagen;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var rutaCancion = "C:\\Users\\Usuario\\Documents\\music\\aaaaa.mp3";
			ReproducirCancionDesdeRuta( rutaCancion);
		}
		private void ReproducirCancionDesdeRuta(string rutaCancion)
		{
			using (var audioFile = new AudioFileReader(rutaCancion))
			using (var outputDevice = new WaveOutEvent())
			{
				outputDevice.Init(audioFile);
				outputDevice.Play();

				// Opcional: Puedes esperar a que la canción termine de reproducirse antes de finalizar el método
				while (outputDevice.PlaybackState == PlaybackState.Playing)
				{
					System.Threading.Thread.Sleep(100);
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void panel1_Click(object sender, EventArgs e)
		{

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Archivos de audio|*.mp3"; // Filtro de archivos de audio MP3
			openFileDialog.Title = "Seleccionar canción";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string rutaCancion = openFileDialog.FileName;
				ReproducirCancion(rutaCancion); // Llamada al método de reproducción de canciones
			}
			//if (!string.IsNullOrEmpty(rutaCancion))
			//{
			//	using (var audioFile = new AudioFileReader(rutaCancion))
			//	using (var outputDevice = new WaveOutEvent())
			//	{
			//		outputDevice.Init(audioFile);
			//		outputDevice.Play();
			//	}
			//	panel1.Visible = true; // Mostrar la imagen en el panel
			//}
			//else
			//{
			//	MessageBox.Show("No se ha seleccionado ninguna canción.");
			//	panel1.Visible = false; // Ocultar la imagen en el panel
			//}
		}
		private void ReproducirCancion(string rutaCancion)
		{
			using (var audioFileReader = new AudioFileReader(rutaCancion))
			using (var outputDevice = new WaveOutEvent())
			{
				outputDevice.Init(audioFileReader);
				outputDevice.Play();
			}
		}
	}
}
