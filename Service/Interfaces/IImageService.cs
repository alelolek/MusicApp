using CrossCuting.DTO;

namespace Service.Interfaces
{
	public interface IImageService<TEntity>
	{
		public string GuardarComoJpg(byte[] imagenBytes, TEntity name);
		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo);
		public byte[] ConvertirJpgABytes(string rutaArchivoJpg);
		public void EliminarImagenPorUrl(string urlImagen);

		public string ActualizarFoto(byte[] nuevaImagenBytes, TEntity name);
	}
}
