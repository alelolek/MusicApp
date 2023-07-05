
using System.Xml.Linq;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Service.Interfaces;

namespace Service.Images
{
	public class ImageService : IImageService<AlbumDto>
	{
		readonly string pathBase = "C:\\Users\\Usuario\\Desktop\\ServerMusicApp\\Images\\Album";



		public string GuardarComoJpg(byte[] imagenBytes,AlbumDto name)
		{
			string nombreArchivo = $"{name.Name}.jpg";
			string rutaCompleta = ObtenerUrlCompleta(pathBase, nombreArchivo);

			using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
			{
				fs.Write(imagenBytes, 0, imagenBytes.Length);
			}

			return rutaCompleta;
		}

		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo)
		{
			return Path.Combine(pathBase, nombreArchivo);
		}

		

		public byte[] ConvertirJpgABytes(string rutaArchivoJpg)
		{
			if (File.Exists(rutaArchivoJpg))
			{
				byte[] imagenBytes = File.ReadAllBytes(rutaArchivoJpg);
				return imagenBytes;
			}
			else
			{
				Console.WriteLine("Imagen no encontrada");
				return null; 
			}
		}

		public void EliminarImagenPorUrl(string urlImagen)
		{
			try
			{
				if (File.Exists(urlImagen))
				{
					File.Delete(urlImagen);
					Console.WriteLine("Imagen eliminada con éxito.");
				}
				else
				{
					Console.WriteLine("La imagen no existe en la ruta especificada.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al eliminar la imagen: " + ex.Message);
			}
		}

		public string ActualizarFoto(byte[] nuevaImagenBytes, AlbumDto name)
		{
			string nombreArchivo = $"{name.Name}.jpg";
			string rutaCompleta = ObtenerUrlCompleta(pathBase, nombreArchivo);

			if (File.Exists(rutaCompleta))
			{
				File.Delete(rutaCompleta);
			}

			using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
			{
				fs.Write(nuevaImagenBytes, 0, nuevaImagenBytes.Length);
			}

			return rutaCompleta;
		}
	}
}
