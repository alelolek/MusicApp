
using Business.Interface;
using Business.Services;
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Presentation.Validators;

namespace Presentation.View
{
	public partial class ArtistAdmin : UserControl
	{
		private IArtistService artistService;
		public ArtistAdmin()
		{
			InitializeComponent();
			artistService = new ArtistService();
		}

		private void RecargarGrid()
		{
			dataGridViewArtists.Rows.Clear();
			var response = artistService.GetAllArtist();
			foreach (var data in response)
			{
				dataGridViewArtists.Rows.Add(data.Id, data.Name);
			}
		}

		private void LimpiarCampos()
		{
			txtId.Clear();
			txtName.Clear();
		}

		public void Edit()
		{
			var response = new ResponseDto();
			try
			{
				var artist = new ArtistDto
				{
					Id = int.Parse(txtId.Text),
					Name = txtName.Text,
					//UrlImage
				};
				response = artistService.EditArtist(artist);
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

		public void Delete()
		{
			var response = new ResponseDto();
			var artistId = int.Parse(txtId.Text);
			response = artistService.DeleteArtist(artistId);

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

			var artist = new ArtistDto()
			{
				Name = txtName.Text,
				//UrlI
			};

			var response = artistService.CreateArtist(artist);
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

		private void ArtistAdmin_Load(object sender, EventArgs e)
		{
			dataGridViewArtists.Columns.Add("id", "Id");
			dataGridViewArtists.Columns.Add("userName", "Nombre");

			RecargarGrid();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Guardar();
			LimpiarCampos();
			RecargarGrid();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Edit();
			LimpiarCampos();
			RecargarGrid();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Delete();
			LimpiarCampos();
			RecargarGrid();
		}

		private void btnUploadImage_Click(object sender, EventArgs e)
		{

		}

		private void dataGridViewArtists_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewArtists.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewArtists.SelectedRows[0];

				string id = selectedRow.Cells["Id"].Value.ToString();
				string name = selectedRow.Cells["Name"].Value.ToString();
				//falta url

				txtName.Text = name;
				txtId.Text = id;
			}
		}
	}
}
