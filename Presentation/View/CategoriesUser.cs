using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class CategoriesUser : UserControl
	{
		private ICategoryService categoryService;
		public CategoriesUser()
		{
			InitializeComponent();
			categoryService = new CategoryService();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
		private void AbrirNuevaPestaña(CategoryDto category)
		{
			MusicPlayer hu = new MusicPlayer();
			hu.ShowDialog();
		}

		private void CategoriesUser_Load(object sender, EventArgs e)
		{
			var listaCanciones = categoryService.GetAllCategory(); // Obtén tu lista de objetos de canciones

			foreach (var cancion in listaCanciones)
			{
				Panel panel = CrearPanelCancion(cancion); // Crea un panel para cada canción
				flowLayoutPanel1.Controls.Add(panel); // Agrega el panel al FlowLayoutPanel
			}
		}

		private Panel CrearPanelCancion(CategoryDto category)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.Beige;
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Padding = new Padding(10);


			Label lblNombre = new Label();
			lblNombre.Text = category.Name;
			lblNombre.Dock = DockStyle.Fill;
			lblNombre.Font = new Font(lblNombre.Font.FontFamily, 12, FontStyle.Bold); // Tamaño de fuente y estilo
			lblNombre.TextAlign = ContentAlignment.MiddleCenter;

			lblNombre.Click += (sender, e) =>
			{
				AbrirNuevaPestaña(category); // Método para abrir la nueva pestaña con la información de la canción
			};

			// Agrega más controles o información de la canción según tus necesidades

			panel.Controls.Add(lblNombre);

			return panel;
		}
	}
}
