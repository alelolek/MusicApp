using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;

namespace Service.Interfaces
{
	public interface ISongsService
	{
		public string GuardarComoMp3(byte[] archivoBytes, SongDto nombre);
		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo);
	}
}
