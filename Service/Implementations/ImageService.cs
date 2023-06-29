
using System.Xml.Linq;
using CrossCuting.DTO;
using Service.Interfaces;

namespace Service.Images
{
	public class ImageService : IImageService
	{
		readonly string pathBase = "C:\\Users\\Usuario\\Desktop\\ServerMusicApp\\Images";
		

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
	}
}
