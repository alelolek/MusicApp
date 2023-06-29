
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Interface;
using Infraestructure.Repositories;
using Business.Interface;

namespace Business.Services
{
	public class ArtistService :IArtistService
	{
		private readonly IRepository<ArtistDto> artistRepository;

		public ArtistService()
		{
			artistRepository = new ArtistRepository();
		}

		public ResponseDto CreateArtist(ArtistDto artistDto)
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

		public ResponseDto EditArtist(ArtistDto artistDto)
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

		public ResponseDto DeleteArtist(int artistId)
		{
			var response = new ResponseDto();
			try
			{
				response = artistRepository.Delete(artistId);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public List<ArtistDto> GetAllArtist()
		{
			List<ArtistDto> artist;
			try
			{
				artist = artistRepository.Get();
			}
			catch
			{
				throw;
			}
			return artist;
		}
	}
}
