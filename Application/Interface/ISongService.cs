
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;

namespace Business.Interface
{
	public interface ISongService
	{
		public ResponseDto CreateSong(SongDto songDto);

		public ResponseDto DeleteSong(int songId);

		public ResponseDto EditSong(SongDto songDto);
		public List<SongDto> GetAllSong();
	}
}
