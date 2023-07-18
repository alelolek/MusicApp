using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;
using Service.Interfaces;

namespace Service.Implementations
{
	public class SongsService : ISongsService
	{
		readonly string pathBase = "C:\\Users\\Usuario\\Desktop\\ServerMusicApp\\Songs";

		public string GuardarComoMp3(byte[] archivoBytes, SongDto nombre)
		{
			string nombreArchivo = $"{nombre.Name}.mp3";
			string rutaCompleta = ObtenerUrlCompleta(pathBase, nombreArchivo);

			using (FileStream fs = new FileStream(rutaCompleta, FileMode.Create))
			{
				fs.Write(archivoBytes, 0, archivoBytes.Length);
			}

			return rutaCompleta;
		}

		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo)
		{
			return Path.Combine(pathBase, nombreArchivo);
		}
	}
}
