

using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Presentation.View;

namespace Presentation.Controller
{
	public class LoginController : ContainerControl
	{
		private IAlbumService _albumService;
		private Login _vista;

        public LoginController()
        {
			_albumService = new AlbumService();
			_vista = new Login();
			_vista.ShowDialog();
		}
        public void Mostrar()
		{
			var user = _vista.txtUser.Text;
			var album = new AlbumDto
			{
				Name = "name",
				UrlImage = "ddda"
			};
			var response = _albumService.CreateAlbum(album);
			if(response.Errors.Any())
			{
                foreach (var error in response.Errors)
                {
					MessageBox.Show(error.Value);
                }
            }
			else
				MessageBox.Show("Registrado con exito");
		}

		private void Formulario_ButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("Hola");
		}
	}
}
