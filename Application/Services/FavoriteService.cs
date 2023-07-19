
using Business.Interface;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Repositories;

namespace Business.Services
{
	public class FavoriteService : IFavoriteService
	{
		private readonly IRepository<FavoriteDto> favoriteRepository;
        public FavoriteService()
        {
			favoriteRepository = new FavoriteRepository();
        }
        public ResponseDto CreateFavorite(FavoriteDto favoriteDto)
		{
			var response  = favoriteRepository.Save(favoriteDto);
			return response;
		}

		public ResponseDto DeleteFavorite(int favoriteId)
		{
			var response = favoriteRepository.Delete(favoriteId);	
			return response;
		}

		public List<FavoriteDto> GetAllFavorite()
		{
			List<FavoriteDto> favorite= favoriteRepository.Get();
			return favorite;
		}
	}
}
