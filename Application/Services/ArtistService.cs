
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Interface;
using Infraestructure.Repositories;

namespace Business.Services
{
	public class ArtistService
	{
		private readonly IRepository<ArtistDto> artistRepository;

		public ArtistService()
		{
			artistRepository = new ArtistRepository();
		}

		public ResponseDto CreateAlbum(ArtistDto artistDto)
		{
			var response = new ResponseDto();
			try
			{
				response = artistRepository.Save(artistDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto EditAlbum(ArtistDto artistDto)
		{
			var response = new ResponseDto();
			try
			{
				response = artistRepository.Update(artistDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto DeleteAlbum(ArtistDto artistDto)
		{
			var response = new ResponseDto();
			try
			{
				response = artistRepository.Delete(artistDto.id);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}
	}
}
