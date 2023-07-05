using CrossCuting.DTO;
using Service.Interfaces;

namespace Service.Implementations
{
	public class ImageArtistService : IImageService<ArtistDto>
	{
		readonly string pathBase = "C:\\Users\\Usuario\\Desktop\\ServerMusicApp\\Images\\Artist";
		
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

		public string GuardarComoJpg(byte[] imagenBytes, ArtistDto name)
		{
			string nombreArchivo = $"{name.Name}.jpg";
			string rutaCompleta = ObtenerUrlCompleta(pathBase, nombreArchivo);

			using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
			{
				fs.Write(imagenBytes, 0, imagenBytes.Length);
			}

			return rutaCompleta;
		}

		public string ActualizarFoto(byte[] nuevaImagenBytes, ArtistDto name)
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

		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo)
		{
			return Path.Combine(pathBase, nombreArchivo);
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
	}
}
