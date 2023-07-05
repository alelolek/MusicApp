
using Business.Interface;
using Business.Services;
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Presentation.Validators;
using Infraestructure.Entities;
using System.Windows.Forms;
using System.Linq;

namespace Presentation.View
{
	public partial class ArtistAdmin : UserControl
	{
		private IArtistService artistService;
		private byte[] imagenBytes;
		public ArtistAdmin()
		{
			InitializeComponent();
			artistService = new ArtistService();
			pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
		}

		public byte[] ConvertImageToBytes(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return ms.ToArray();
			}
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
				Image image = pictureBoxImage.Image;
				var imageByte = ConvertImageToBytes(image);
				var artist = new ArtistDto
				{
					Id = int.Parse(txtId.Text),
					Name = txtName.Text,
					Photo = imageByte,
				};
				response = artistService.EditArtist(artist);
				MessageBox.Show("El Artista fue editado");
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
				Photo = imagenBytes
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
			dataGridViewArtists.Columns.Add("name", "Name");

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
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string rutaImagen = openFileDialog.FileName;

				Image imagen = Image.FromFile(rutaImagen);
				pictureBoxImage.Image = imagen;
				pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;

				imagenBytes = ConvertImageToBytes(imagen);
			}
		}

		private void dataGridViewArtists_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewArtists.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewArtists.SelectedRows[0];

				string id = selectedRow.Cells["Id"].Value.ToString();
				string name = selectedRow.Cells["Name"].Value.ToString();

				txtName.Text = name;
				txtId.Text = id;

				var intId = int.Parse(id);

				var objeto = artistService.GetArtistById(intId);

				Image imagenArtist = ConvertirBytesAImagen(objeto.Photo);
				pictureBoxImage.Image = imagenArtist;
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

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			string nombreArtista = txtBuscar.Text;

			var artis = artistService.GetAllArtist();
			var artistaencontrado = artis.FirstOrDefault(a => a.Name.Contains(nombreArtista));

			if (artistaencontrado != null)
			{
				dataGridViewArtists.Rows.Clear();
				dataGridViewArtists.Rows.Add(artistaencontrado.Id, artistaencontrado.Name);

			}
			else
			{
				MessageBox.Show("No se encontró ningún artista con ese nombre.");
				dataGridViewArtists.Rows.Clear();
				RecargarGrid();
				txtBuscar.Clear();
			}

		}
	}
}
