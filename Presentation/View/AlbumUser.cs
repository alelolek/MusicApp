using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;

namespace Presentation.View
{
	public partial class AlbumUser : UserControl
	{
		private IAlbumService albumService;
		private ISongService songService;
		public AlbumUser()
		{
			InitializeComponent();
			albumService = new AlbumService();
			songService = new SongService();
		}


		private void AlbumUser_Load(object sender, EventArgs e)
		{
			CargarAlbum();
		}

		private void CargarAlbum()
		{
			var listaCanciones = albumService.GetAllAlbums();

			foreach (var cancion in listaCanciones)
			{
				Panel panel = CrearPanelCancion(cancion);
				flowLayoutPanel1.Controls.Add(panel);
			}
		}

		private void AbrirNuevaPestaña(AlbumDto cancion)
		{
			var canciones = songService.GetAllSong().Where(a => a.Album.Id==cancion.Id).ToList();
			var cancionId = songService.GetAllSong().FirstOrDefault(a => a.Album.Id == cancion.Id);

			MusicPlayer hu = new MusicPlayer(canciones);

			Label label = hu.lbSong;
			label.Text = cancionId.Id.ToString();

			

			var album = albumService.GetAllAlbums().FirstOrDefault(a => a.Id == cancionId.Album.Id);

            var imagen = ConvertirBytesAImagen(album.Photo);

            PictureBox pic = hu.pbxImageSong;
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            hu.ShowDialog();

            flowLayoutPanel1.Controls.Clear();
            CargarAlbum();
		}
   

        private Panel CrearPanelCancion(AlbumDto cancion)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.White;
			panel.Padding = new Padding(10);
			panel.Size = new Size(200, 200);

			Label lblNombre = new Label();
			lblNombre.Text = cancion.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 12, FontStyle.Bold);
			lblNombre.TextAlign = ContentAlignment.BottomCenter;

			PictureBox pictureBox = new PictureBox();
			pictureBox.Dock = DockStyle.Top;
			pictureBox.Size = new Size(200, 150);
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


			string nombreAlbum = cancion.Name;
			Image imagenAlbum = ConvertirBytesAImagen(cancion.Photo);
			pictureBox.Image = imagenAlbum;

			lblNombre.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(cancion);
				flowLayoutPanel1.Controls.Clear();
				CargarAlbum();
			};

			panel.Controls.Add(pictureBox);
			panel.Controls.Add(lblNombre);

			return panel;
		}

		public Image ConvertirBytesAImagen(byte[] imagenBytes)
		{
			using (MemoryStream ms = new MemoryStream(imagenBytes))
			{
				Image imagen = Image.FromStream(ms);
				return imagen;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Buscar();
		}

		public void Buscar()
		{
			string nombreAlbum = txtBuscar.Text;

			var albums = albumService.GetAllAlbums();
			var albumEncontrado = albums.FirstOrDefault(album => album.Name.Contains(nombreAlbum));

			if (albumEncontrado != null)
			{
				flowLayoutPanel1.Controls.Clear();
				Panel panel = CrearPanelCancion(albumEncontrado);
				flowLayoutPanel1.Controls.Add(panel);
				txtBuscar.Clear();
				//flowLayoutPanel1.Controls.Clear();
			}
			else
			{
				MessageBox.Show("No se encontró ningún álbum con ese nombre.");
			}
		}

	}
}
