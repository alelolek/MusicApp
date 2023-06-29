using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class AlbumUser : UserControl
	{
		private IAlbumService albumService;
		public AlbumUser()
		{
			InitializeComponent();
			albumService = new AlbumService();
		}


		private void AlbumUser_Load(object sender, EventArgs e)
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
			MusicPlayer hu = new MusicPlayer();
			hu.ShowDialog();
		}

		private Panel CrearPanelCancion(AlbumDto cancion)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.Beige;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Padding = new Padding(10);
			panel.Size = new Size(200, 150);

			Label lblNombre = new Label();
			lblNombre.Text = cancion.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 12, FontStyle.Bold);
			lblNombre.TextAlign = ContentAlignment.BottomCenter;

			PictureBox pictureBox = new PictureBox();
			pictureBox.Dock = DockStyle.Top;
			pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


			string nombreAlbum = cancion.Name; 
			Image imagenAlbum = ConvertirBytesAImagen(cancion.Photo); 
			pictureBox.Image = imagenAlbum;

			lblNombre.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(cancion);
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

		}
		//falta metodo buscar
	}
}
