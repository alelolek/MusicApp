
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class SongUser : UserControl
	{
		private readonly ISongService songService;
		private readonly IArtistService artistService;
		private readonly IAlbumService albumService;
		private readonly IFavoriteService favoriteService;
		private bool estadoActual = false;
		
		public SongUser()
		{
			InitializeComponent();
			songService = new SongService();
			artistService = new ArtistService();
			albumService = new AlbumService();
			favoriteService = new FavoriteService();
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

		private void RecargarCanciones()
		{
			int numero = 0;
			var listaCanciones = songService.GetAllSong();
			foreach (var cancion in listaCanciones)
			{
				numero++;
				Panel panel = CrearPanelCancion(cancion, numero);
				flowLayoutPanel1.Controls.Add(panel);
			}
		}

		private Panel CrearPanelCancion(SongDto cancion, int numero)
		{
			var artists = artistService.GetAllArtist();
			var artist = artists.FirstOrDefault(a => a.Id == cancion.Artist.Id);

			Panel panel = new Panel();
			panel.BackColor = Color.White;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Size = new Size(550, 60);

			// Texto izquierdo (número)
			Label numeroLabel = new Label();
			numeroLabel.Text = numero.ToString();
			numeroLabel.Font = new Font("Arial", 12, FontStyle.Bold);
			numeroLabel.Location = new Point(10, 18);
			numeroLabel.AutoSize = true;
			panel.Controls.Add(numeroLabel);

			// PictureBox izquierdo
			PictureBox pictureBoxIzquierdo = new PictureBox();
			pictureBoxIzquierdo.Image = Properties.Resources.play;
			pictureBoxIzquierdo.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxIzquierdo.Size = new Size(28, 28);
			pictureBoxIzquierdo.Location = new Point(40, 14);
			pictureBoxIzquierdo.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxIzquierdo.Padding = new Padding(3);
			panel.Controls.Add(pictureBoxIzquierdo);

			// Texto nombresong
			Label textoDerechoLabel = new Label();
			textoDerechoLabel.Text = cancion.Name;
			textoDerechoLabel.Font = new Font("Arial", 11, FontStyle.Bold);
			textoDerechoLabel.Location = new Point(80, 12);
			//textoDerechoLabel.AutoSize = true;
			panel.Controls.Add(textoDerechoLabel);

			// Texto nombre autor
			Label textoAutorLabel = new Label();
			textoAutorLabel.Text = artist.Name;
			textoAutorLabel.Font = new Font("Arial", 9, FontStyle.Regular);
			textoAutorLabel.Location = new Point(80, 35);
			//textoDerechoLabel.AutoSize = true;
			panel.Controls.Add(textoAutorLabel);

			// PictureBox derecho
			PictureBox pictureBoxDerecho = new PictureBox();
			pictureBoxDerecho.Image = Properties.Resources.like;
			pictureBoxDerecho.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxDerecho.Width = 24;
			pictureBoxDerecho.Height = 24;
			pictureBoxDerecho.Location = new Point(500, 14);
			panel.Controls.Add(pictureBoxDerecho);

			panel.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(cancion);
			};

			pictureBoxDerecho.Click += (sender, e) =>
			{
				if (estadoActual)
				{
					pictureBoxDerecho.Image = Properties.Resources.like;
					estadoActual = false;
					EliminarFavorito(cancion);
				}
				else
				{
					pictureBoxDerecho.Image = Properties.Resources.desLike;
					estadoActual = true;
					HacerFavorito(cancion);
				}
			};

			return panel;
		}

		private void HacerFavorito(SongDto cancion)
		{
			var favorite = new FavoriteDto
			{
				Account = new AccountDto() { id = Convert.ToInt32(lbId.Text) },
				Song = new SongDto() { Id = cancion.Id }
			};
			favoriteService.CreateFavorite(favorite);
		}
		private void EliminarFavorito(SongDto cancion)
		{
			var favorite = favoriteService.GetAllFavorite();
			var idfavorito = favorite.FirstOrDefault(a => a.Song.Id == cancion.Id);
			favoriteService.DeleteFavorite(idfavorito.Song.Id);

		}

		private void PictureBoxDerecho_Click(object? sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void AbrirNuevaPestaña(SongDto cancion)
		{
			var albums = albumService.GetAllAlbums();
			var album = albums.FirstOrDefault(a => a.Id == cancion.Album.Id);
			var listaCanciones = songService.GetAllSong();

			MusicPlayer hu = new MusicPlayer(listaCanciones);
			Label label = hu.lbSong;
			label.Text = cancion.Id.ToString();

			var imagen = ConvertirBytesAImagen(album.Photo);

			PictureBox pic = hu.pbxImageSong;
			pic.Image = imagen;
			pic.SizeMode = PictureBoxSizeMode.Zoom;
            hu.ShowDialog();
		}

		public Image ConvertirBytesAImagen(byte[] imagenBytes)
		{
			using (MemoryStream ms = new MemoryStream(imagenBytes))
			{
				Image imagen = Image.FromStream(ms);
				return imagen;
			}
		}
		private void SongUser_Load(object sender, EventArgs e)
		{
			RecargarCanciones();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string nombreCancion = txtBuscar.Text;

			var song = songService.GetAllSong().Where(a => a.Name.Contains(nombreCancion)).ToList();
			int numero = 0;
			if (song.Any())
			{
				flowLayoutPanel1.Controls.Clear();
				foreach (var cancion in song)
				{
					numero++;
					Panel panel = CrearPanelCancion(cancion, numero);
					flowLayoutPanel1.Controls.Add(panel);
				}
				
				txtBuscar.Clear();
			}
			else
			{
				MessageBox.Show("No se encontró ningún Artista con ese nombre.");
			}
		}
	}
}
