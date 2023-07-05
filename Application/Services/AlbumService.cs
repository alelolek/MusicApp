
using System.Security.Policy;
using Business.Interface;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Repositories;
using Service.Images;
using Service.Interfaces;

namespace Business.Services
{
	public class AlbumService : IAlbumService
	{
		private readonly IRepository<AlbumDto> albumRepository;
		private readonly IImageService<AlbumDto> imageService;

		public AlbumService()
		{
			albumRepository = new AlbumRepository();
			imageService = new ImageService();
		}

		public ResponseDto CreateAlbum(AlbumDto albumDto)
		{
			var url = imageService.GuardarComoJpg(albumDto.Photo,albumDto);
			albumDto.UrlImage = url;
			var response = albumRepository.Save(albumDto);
			return response;
		}

		public ResponseDto EditAlbum(AlbumDto albumDto)
		{
			var url = imageService.ActualizarFoto(albumDto.Photo, albumDto);
			albumDto.UrlImage = url;
			var response = albumRepository.Update(albumDto);
			return response;
		}

		public ResponseDto DeleteAlbum(int albumId)
		{
			var objeto  = GetAlbumById(albumId);
			var url = objeto.UrlImage;
			imageService.EliminarImagenPorUrl(url);
			var response = albumRepository.Delete(albumId);

			return response;
		}
	
		public AlbumDto GetAlbumById(int id)
		{
			try
			{
				List<AlbumDto> albums = albumRepository.Get();
				AlbumDto album = albums.FirstOrDefault(a => a.Id == id);
				if (album != null)
				{
					string url = album.UrlImage;
					byte[] otroByte = imageService.ConvertirJpgABytes(url);
					album.Photo = otroByte;
				}
				return album;
			}
			catch
			{
				throw;
			}
		}

		public List<AlbumDto> GetAllAlbums()
		{
			List<AlbumDto> albums;
			try
			{
				albums = albumRepository.Get();
                foreach (var item in albums)
                {
					string url = item.UrlImage;
					var otroByte = imageService.ConvertirJpgABytes(url);
					item.Photo = otroByte;
                }
            }
			catch 
			{
				throw;
			}
			return albums;
		}
		
	}
}










//public AlbumDto? GetAlbumById(int id)
//{
//	Func<AlbumDto, bool>? filter = x => x.Id == id;
//	var album = albumRepository.Get(filter).FirstOrDefault();
//	return album;
//}