
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Repositories;

namespace Business.Interface
{
	public interface IAlbumService
	{
		public ResponseDto CreateAlbum(AlbumDto albumDto);

		public ResponseDto EditAlbum(AlbumDto albumDto);

		public ResponseDto DeleteAlbum(int albumId);

		public AlbumDto? GetAlbumById(int id);

		public List<AlbumDto> GetAllAlbums();
	}
}
