
using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Interface;

namespace Infraestructure.Mapper
{
	public class FavoriteMapper : IMapper<Favorite,FavoriteDto>
	{
		public Favorite MapDtoToEntity(FavoriteDto dto)
		{
			return new Favorite
			{
				Account = new Account { id = dto.Account.id},
				Song = new Song { Id = dto.Song.Id }
			};
		}

		public FavoriteDto MapEntityToDto(Favorite favorite)
		{
			return new FavoriteDto
			{
				Account = new AccountDto { id = favorite.Account.id },
				Song = new SongDto {  Id = favorite.Song.Id }
			};
		}

	}
}
