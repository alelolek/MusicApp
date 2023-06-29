using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;

namespace Service.Interfaces
{
	public interface IImageService
	{
		public string GuardarComoJpg(byte[] imagenBytes, AlbumDto name);
		public string ObtenerUrlCompleta(string pathBase, string nombreArchivo);
		public byte[] ConvertirJpgABytes(string rutaArchivoJpg);

	}
}
