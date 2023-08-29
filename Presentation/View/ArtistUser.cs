using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presentation.View
{
	public partial class ArtistUser : UserControl
	{
		private readonly ISongService songService;
		private IArtistService artistService;
		private IAlbumService albumService;
		public ArtistUser()
		{
			InitializeComponent();
			artistService = new ArtistService();
			songService = new SongService();
			albumService = new AlbumService();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string nombreArtista = txtBuscar.Text;

			var artists = artistService.GetAllArtist();
			var artistaEncontrado = artists.FirstOrDefault(a => a.Name.Contains(nombreArtista));

			if (artistaEncontrado != null)
			{
				flowLayoutPanel1.Controls.Clear();
				Panel panel = CrearPanelCancion(artistaEncontrado);
				flowLayoutPanel1.Controls.Add(panel);
				txtBuscar.Clear();
				//flowLayoutPanel1.Controls.Clear();
			}
			else
			{
				MessageBox.Show("No se encontró ningún Artista con ese nombre.");
			}
		}

		private void ArtistUser_Load(object sender, EventArgs e)
		{
			RecargarArtist();
		}

		private void RecargarArtist()
		{
			var listaArtistas = artistService.GetAllArtist();

			foreach (var cancion in listaArtistas)
			{
				Panel panel = CrearPanelCancion(cancion);
				flowLayoutPanel1.Controls.Add(panel);
			}
		}

		private Panel CrearPanelCancion(ArtistDto artists)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.White;
			//panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Padding = new Padding(10);
			panel.Size = new Size(200, 190);

			Label lblNombre = new Label();
			lblNombre.Text = artists.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 12, FontStyle.Bold);
			lblNombre.TextAlign = ContentAlignment.BottomCenter;

			PictureBox pictureBox = new PictureBox();
			pictureBox.Dock = DockStyle.Top;
			pictureBox.Size = new Size(160, 120);
			pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			//pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


			string nombreAlbum = artists.Name;
			Image imagenAlbum = ConvertirBytesAImagen(artists.Photo);
			pictureBox.Image = imagenAlbum;

			lblNombre.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(artists);
			};

			panel.Controls.Add(pictureBox);
			panel.Controls.Add(lblNombre);

			return panel;
		}

		private void AbrirNuevaPestaña(ArtistDto artists)
		{
			
			var canciones = songService.GetAllSong();
			var cancion = canciones.FirstOrDefault(a => a.Artist.Id == artists.Id);

			var cancionesPorArtista = canciones.Where(a => a.Artist.Id == artists.Id).ToList();

			MusicPlayer hu = new MusicPlayer(cancionesPorArtista);
			Label label = hu.lbSong;
			label.Text = cancion.Id.ToString();

            var album = albumService.GetAllAlbums().FirstOrDefault(a => a.Id == cancion.Album.Id);

            var imagen = ConvertirBytesAImagen(album.Photo);

            PictureBox pic = hu.pbxImageSong;
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.Zoom;


            hu.ShowDialog();
			flowLayoutPanel1.Controls.Clear();
			RecargarArtist();
		}

		public Image ConvertirBytesAImagen(byte[] imagenBytes)
		{
			using (MemoryStream ms = new MemoryStream(imagenBytes))
			{
				Image imagen = Image.FromStream(ms);
				return imagen;
			}
		}
	}
}
