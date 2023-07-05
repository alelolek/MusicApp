
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Presentation.Validators;

namespace Presentation.View
{
	public partial class CategoryAdmin : UserControl
	{
		private ICategoryService categoryService;
		public CategoryAdmin()
		{
			InitializeComponent();
			categoryService = new CategoryService();
		}

		public void Delete()
		{
			var response = new ResponseDto();
			var categoryId = int.Parse(txtId.Text);
			response = categoryService.DeleteCategory(categoryId);

			if (response.Errors.Any())
			{
				foreach (var error in response.Errors)
				{
					MessageBox.Show(error.Value);
				}
			}
			else
			{
				MessageBox.Show("Eliminado con éxito");
			}
		}

		public void Guardar()
		{
			bool camposVacios = Validation.CamposVacios(txtName);

			if (camposVacios)
			{
				MessageBox.Show("Por favor, complete todos los campos obligatorios.");
				return;
			}

			var category = new CategoryDto
			{
				Name = txtName.Text,
			};

			var response = categoryService.CreateCategory(category);
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

		private void CategoryAdmin_Load(object sender, EventArgs e)
		{
			dataGridViewCategory.Columns.Add("Id", "Id");
			dataGridViewCategory.Columns.Add("Name", "Name");

			RecargarGrid();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Guardar();
			LimpiarCampos();
			RecargarGrid();
		}
		private void RecargarGrid()
		{
			dataGridViewCategory.Rows.Clear();
			var response = categoryService.GetAllCategory();
			foreach (var data in response)
			{
				dataGridViewCategory.Rows.Add(data.Id, data.Name);
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Edit();
			LimpiarCampos();
			RecargarGrid();
		}

		public void Edit()
		{
			var response = new ResponseDto();
			try
			{
				var category = new CategoryDto
				{
					Id = int.Parse(txtId.Text),
					Name = txtName.Text,
				};
				response = categoryService.EditCategory(category);
			}
			catch (Exception)
			{
				if (response.Errors.Any())
				{
					foreach (var error in response.Errors)
					{
						MessageBox.Show(error.Value);
					}
				}
				else
				{
					MessageBox.Show("Actualizado con éxito");
				}
			}
		}

		private void dataGridViewCategory_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewCategory.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewCategory.SelectedRows[0];

				string id = selectedRow.Cells["Id"].Value.ToString();
				string name = selectedRow.Cells["Name"].Value.ToString();

				txtName.Text = name;
				txtId.Text = id;
			}
		}

		private void LimpiarCampos()
		{
			txtId.Clear();
			txtName.Clear();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Delete();
			LimpiarCampos();
			RecargarGrid();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string nombreCategoria = txtBuscar.Text;

			var categorias = categoryService.GetAllCategory();
			var categoriaEncontrado = categorias.FirstOrDefault(a => a.Name.Contains(nombreCategoria));

			if (categoriaEncontrado != null)
			{
				dataGridViewCategory.Rows.Clear();
				dataGridViewCategory.Rows.Add(categoriaEncontrado.Id, categoriaEncontrado.Name);
				Ejecutar();
			}
			else
			{
				MessageBox.Show("No se encontró ningún artista con ese nombre.");
				dataGridViewCategory.Rows.Clear();
				RecargarGrid();
				txtBuscar.Clear();
			}

		}
		private async void Ejecutar()
		{
			await Task.Delay(2000);
			RecargarGrid();
		}
	}
}
