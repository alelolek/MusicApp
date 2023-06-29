using Business.Interface;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Interface;
using Infraestructure.Repositories;

namespace Business.Services
{
	public class SongService : ISongService
	{
		private readonly IRepository<SongDto> songRepository;

        public SongService()
        {
			songRepository = new SongRepository();
        }

		public ResponseDto CreateSong(SongDto songDto)
		{
			var response = new ResponseDto();
			try
			{
				response = songRepository.Save(songDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto DeleteSong(int songId)
		{
			var response = new ResponseDto();
			try
			{
				response = songRepository.Delete(songId);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto EditSong(SongDto songDto)
		{
			var response = new ResponseDto();
			try
			{
				response = songRepository.Update(songDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public List<SongDto> GetAllSong()
		{
			List<SongDto> song;
			try
			{
				song = songRepository.Get();
			}
			catch
			{
				throw;
			}
			return song;
		}
	}
}
