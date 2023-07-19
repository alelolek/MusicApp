
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class ForYouUser : UserControl
	{
		private readonly IFavoriteService favoriteService;
		private readonly IArtistService artistService;
		private readonly IAlbumService albumService;
		private readonly ISongService songService;
		private bool estadoActual = false;
		public ForYouUser()
		{
			InitializeComponent();
			songService = new SongService();
			favoriteService = new FavoriteService();
			artistService = new ArtistService();
			albumService = new AlbumService();
		}

		private void RecargarCanciones()
		{
			int numero = 0;
			var idAccount = Convert.ToInt32(lbId.Text);
			var listaCanciones = favoriteService.GetAllFavorite();

			var fav = favoriteService.GetAllFavorite().Where(a => a.Account.id == idAccount).ToList();
			
			foreach (var cancion in fav)
			{
				numero++;
				Panel panel = CrearPanelCancion(cancion, numero);
				flowLayoutPanel1.Controls.Add(panel);
			}
		}

		private Panel CrearPanelCancion(FavoriteDto cancion, int numero)
		{
			var songs = songService.GetAllSong();
			var song = songs.FirstOrDefault(a => a.Id == cancion.Song.Id);

			var artists = artistService.GetAllArtist();
			var artist = artists.FirstOrDefault(a => a.Id == song.Artist.Id);

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
			textoDerechoLabel.Text = song.Name;
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
			pictureBoxDerecho.Image = Properties.Resources.desLike;
			pictureBoxDerecho.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxDerecho.Width = 24;
			pictureBoxDerecho.Height = 24;
			pictureBoxDerecho.Location = new Point(500, 14);
			panel.Controls.Add(pictureBoxDerecho);

			panel.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(song);
			};

			pictureBoxDerecho.Click += (sender, e) =>
			{
				if (estadoActual)
				{
					pictureBoxDerecho.Image = Properties.Resources.desLike;
					estadoActual = false;
				}
				else
				{
					pictureBoxDerecho.Image = Properties.Resources.like;
					estadoActual = true;
					EliminarFavorito(cancion.Song);

				}
			};

			return panel;
		}

		private void EliminarFavorito(SongDto cancion)
		{
			var favorite = favoriteService.GetAllFavorite();
			var idfavorito = favorite.FirstOrDefault(a => a.Song.Id == cancion.Id);
			favoriteService.DeleteFavorite(idfavorito.Song.Id);
		}
		private void AbrirNuevaPestaña(SongDto cancion)
		{
			var albums = albumService.GetAllAlbums();
			var album = albums.FirstOrDefault(a => a.Id == cancion.Album.Id);

			var idAccount = Convert.ToInt32(lbId.Text);
			var fav = favoriteService.GetAllFavorite().Where(a => a.Account.id == idAccount).ToList();
			var favoritos = fav.Select(a => a.Song).ToList();

			
			MusicPlayer hu = new MusicPlayer(favoritos);
			Label label = hu.lbSong;
			label.Text = cancion.Id.ToString();

			var imagen = ConvertirBytesAImagen(album.Photo);

			PictureBox pic = hu.pbxImageSong;
			pic.Image = imagen;
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

		private void ForYouUser_Load(object sender, EventArgs e)
		{
			RecargarCanciones();
		}
	}
}
