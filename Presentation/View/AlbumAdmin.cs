using System.Windows.Forms;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Entities;
using Presentation.Validators;

namespace Presentation.View
{
	public partial class AlbumAdmin : UserControl
	{
		private IAlbumService albumService;
		private byte[] imagenBytes;
		public AlbumAdmin()
		{
			InitializeComponent();
			albumService = new AlbumService();
			
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
			dataGridViewAlbums.Rows.Clear();
			var response = albumService.GetAllAlbums();
			foreach (var data in response)
			{
				dataGridViewAlbums.Rows.Add(data.Id, data.Name);
			}
		}

		public void Edit()
		{
			var response = new ResponseDto();
			try
			{
				Image image = pictureBoxImage.Image;
				var imageByte = ConvertImageToBytes(image);
				var album = new AlbumDto
				{
					Id = int.Parse(txtId.Text),
					Name = txtName.Text,
					Photo = imageByte,
				};
				response = albumService.EditAlbum(album);
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
			var albumId = int.Parse(txtId.Text);
			response = albumService.DeleteAlbum(albumId);
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

			var album = new AlbumDto()
			{
				Name = txtName.Text,
				Photo = imagenBytes
			};

			var response = albumService.CreateAlbum(album);
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


		private void AlbumAdmin_Load(object sender, EventArgs e)
		{
			dataGridViewAlbums.Columns.Add("id", "Id");
			dataGridViewAlbums.Columns.Add("name", "Name");

			RecargarGrid();
		}


		private void UploadImage_Click(object sender, EventArgs e)
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

		private void Save_Click(object sender, EventArgs e)
		{
			Guardar();
			LimpiarCampos();
			RecargarGrid();
		}

		private void LimpiarCampos()
		{
			txtId.Clear();
			txtName.Clear();
			pictureBoxImage.Image = null;
		}

		private void dataGridViewAlbums_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewAlbums.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewAlbums.SelectedRows[0];

				string id = selectedRow.Cells["Id"].Value.ToString();
				string name = selectedRow.Cells["Name"].Value.ToString();
				txtName.Text = name;
				txtId.Text = id;
				var intId = int.Parse(id);

				var objeto = albumService.GetAlbumById(intId);

				Image imagenAlbum = ConvertirBytesAImagen(objeto.Photo);
				pictureBoxImage.Image = imagenAlbum;
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

		private void Buscar_Click(object sender, EventArgs e)
		{
			string nombreAlbum = txtBuscar.Text;

			var albums = albumService.GetAllAlbums();
			var albumEncontrado = albums.FirstOrDefault(album => album.Name.Contains(nombreAlbum));

			if (albumEncontrado != null)
			{
				
				dataGridViewAlbums.Rows.Clear();
				dataGridViewAlbums.Rows.Add(albumEncontrado.Id, albumEncontrado.Name);
			}
			else
			{
				MessageBox.Show("No se encontró ningún álbum con ese nombre.");
				dataGridViewAlbums.Rows.Clear();
				RecargarGrid();
			}
		}
	}
}
