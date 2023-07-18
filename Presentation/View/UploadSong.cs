using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;
using NAudio.Wave;
using Presentation.Validators;

namespace Presentation.View
{
	public partial class UploadSong : Form
	{
		private readonly IArtistService artistService;
		private readonly IAlbumService albumService;
		private readonly ICategoryService categoryService;
		private readonly ISongService songService;
		private byte[] bytesMusica;


		public UploadSong()
		{
			InitializeComponent();
			artistService = new ArtistService();
			albumService = new AlbumService();
			categoryService = new CategoryService();
			songService = new SongService();


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
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Archivos de música (*.mp3)|*.mp3";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string rutaArchivo = openFileDialog.FileName;
				bytesMusica = ConvertirMusicaABytes(rutaArchivo);

			}
		}


		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public byte[] ConvertirMusicaABytes(string rutaArchivo)
		{
			using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
			{
				bytesMusica = new byte[fs.Length];
				fs.Read(bytesMusica, 0, (int)fs.Length);
			}

			return bytesMusica;
		}

		private void panel1_Click(object sender, EventArgs e)
		{


		}
		public void Guardar()
		{
			bool camposVacios = Validation.CamposVacios(txtName);

			if (camposVacios)
			{
				MessageBox.Show("Por favor, complete todos los campos obligatorios.");
				return;
			}

			var artists = artistService.GetAllArtist();
			var artist = artists.FirstOrDefault(a => a.Name == cbxArtist.SelectedItem.ToString());

			var albums = albumService.GetAllAlbums();
			var album = albums.FirstOrDefault(a => a.Name == cbxAlbum.SelectedItem.ToString());

			var categories = categoryService.GetAllCategory();
			var category = categories.FirstOrDefault(a => a.Name == cbxCategories.SelectedItem.ToString());

			var song = new SongDto()
			{
				Name = txtName.Text,
				Artist = artist,
				Album = album,
				Category = category,
				Song = bytesMusica
			};
			var response = songService.CreateSong(song);
			txtName.Clear();

			if (response.Errors.Any())
			{
				foreach (var error in response.Errors)
				{
					MessageBox.Show(error.Value);
				}
			}
			else
			{
				MessageBox.Show("Registrado con éxito");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Guardar();
		}
	}
}
