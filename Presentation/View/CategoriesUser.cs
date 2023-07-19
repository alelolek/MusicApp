using System.Drawing.Printing;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presentation.View
{
	public partial class CategoriesUser : UserControl
	{
		private ICategoryService categoryService;
		private ISongService songService;
		public CategoriesUser()
		{
			InitializeComponent();
			categoryService = new CategoryService();
			songService = new SongService();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string nombreCategoria = txtBuscar.Text;
			var category = categoryService.GetAllCategory();
			var categoriaEncontrada = category.FirstOrDefault(a => a.Name.Contains(nombreCategoria));

			if (categoriaEncontrada != null)
			{
				flowLayoutPanel1.Controls.Clear();
				Panel panel = CrearPanelCancion(categoriaEncontrada);
				flowLayoutPanel1.Controls.Add(panel);
				txtBuscar.Clear();
			}
			else
			{
				MessageBox.Show("No se encontró ningún Artista con ese nombre.");
			}

		}
		private void AbrirNuevaPestaña(CategoryDto category)
		{
			var canciones = songService.GetAllSong();
			var cancion = canciones.FirstOrDefault(a => a.Category.Id == category.Id);
			var cancionesPorCategory = canciones.Where(a => a.Category.Id == category.Id).ToList();

			MusicPlayer hu = new MusicPlayer(cancionesPorCategory);
			Label label = hu.lbSong;
			label.Text = cancion.Id.ToString();
			hu.ShowDialog();
			flowLayoutPanel1.Controls.Clear();
			CargarCategory();
		}

		private void CategoriesUser_Load(object sender, EventArgs e)
		{
			CargarCategory();
		}

		private void CargarCategory()
		{
			var listaCanciones = categoryService.GetAllCategory();

			foreach (var cancion in listaCanciones)
			{
				Panel panel = CrearPanelCancion(cancion);
				flowLayoutPanel1.Controls.Add(panel);
			}
		}

		private Panel CrearPanelCancion(CategoryDto category)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.FromArgb(17, 0, 90);
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Padding = new Padding(10);


			Label lblNombre = new Label();
			lblNombre.Text = category.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 14, FontStyle.Bold);
			lblNombre.ForeColor = Color.White;
			lblNombre.TextAlign = ContentAlignment.MiddleCenter;

			lblNombre.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(category); 
			};

			panel.Controls.Add(lblNombre);

			return panel;
		}
	}
}
