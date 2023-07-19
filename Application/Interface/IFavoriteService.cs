
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;

namespace Business.Interface
{
	public interface IFavoriteService
	{
		public ResponseDto CreateFavorite(FavoriteDto favoriteDto);
		public ResponseDto DeleteFavorite(int favoriteId);
		public List<FavoriteDto> GetAllFavorite();
	}
}
