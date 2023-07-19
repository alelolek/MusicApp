
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Interface;
using Infraestructure.Repositories;
using Business.Interface;
using Service.Images;
using Service.Interfaces;
using Service.Implementations;
using Infraestructure.Entities;

namespace Business.Services
{
	public class ArtistService :IArtistService
	{
		private readonly IRepository<ArtistDto> artistRepository;
		private IImageService<ArtistDto> imageService;

		public ArtistService()
		{
			artistRepository = new ArtistRepository();
			imageService = new ImageArtistService();
		}

		public ResponseDto CreateArtist(ArtistDto artistDto)
		{
			var url = imageService.GuardarComoJpg(artistDto.Photo, artistDto);
			artistDto.UrlImage = url;
			var response = artistRepository.Save(artistDto);
			return response;
		}
		public ResponseDto EditArtist(ArtistDto artistDto)
		{
			var url = imageService.ActualizarFoto(artistDto.Photo, artistDto);
			artistDto.UrlImage = url;
			var response = artistRepository.Update(artistDto);
			
			return response;
		}
		public ResponseDto DeleteArtist(int artistId)
		{
			var response = new ResponseDto();

			var objeto = GetArtistById(artistId);
			var url = objeto.UrlImage;
			imageService.EliminarImagenPorUrl(url);
			response = artistRepository.Delete(artistId);
			return response;
		}
		public List<ArtistDto> GetAllArtist()
		{
			List<ArtistDto> artist;
			try
			{
				artist = artistRepository.Get();
				foreach (var item in artist)
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
			return artist;
		}

		public ArtistDto GetArtistById(int id)
		{
			try
			{
				List<ArtistDto> artists = artistRepository.Get();
				ArtistDto artist = artists.FirstOrDefault(a => a.Id == id);
				if (artist != null)
				{
					string url = artist.UrlImage;
					byte[] otroByte = imageService.ConvertirJpgABytes(url);
					artist.Photo = otroByte;
				}
				return artist;
			}
			catch
			{
				throw;
			}
		}

	}
}
