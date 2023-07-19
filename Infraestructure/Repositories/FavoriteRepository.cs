using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class FavoriteRepository : IRepository<FavoriteDto>
	{
		private readonly SqlConnection connection;
		private readonly IMapper<Favorite,FavoriteDto> mapper;

        public FavoriteRepository()
        {
            connection = DatabaseConnection.GetInstance().GetConnection();
			mapper = new FavoriteMapper();
        }

		private void ReadFavorite(SqlCommand command, List<FavoriteDto> favoritesDto)
		{
			connection.Open();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Favorite favorite = new Favorite();
					favorite.Account = new Account { id = reader.GetInt32(0) };
					favorite.Song = new Song { Id = reader.GetInt32(1) };
					
					var favoriteDto = mapper.MapEntityToDto(favorite);
					favoritesDto.Add(favoriteDto);
				}
			}
			connection.Close();
		}

		public ResponseDto Delete(int favoriteId)
		{
			var response = new ResponseDto();
			try
			{
				var query = "DELETE FROM Favorite WHERE Song_id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", favoriteId);
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public List<FavoriteDto> Get(Func<FavoriteDto, bool>? filter = null)
		{
			List<FavoriteDto> favoriteDtos = new List<FavoriteDto>();
			try
			{
				var query = "SELECT * FROM Favorite";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					ReadFavorite(command, favoriteDtos);
				}
			}
			catch (Exception ex)
			{
				throw;
			}

			if (filter != null)
				favoriteDtos = favoriteDtos.Where(filter).ToList();

			return favoriteDtos;
		}

		public ResponseDto Save(FavoriteDto entity)
		{
			var response = new ResponseDto();
			var favorite = mapper.MapDtoToEntity(entity);
			try
			{
				var query = "INSERT INTO Favorite(Account_Id,Song_Id) VALUES(@account,@song)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@account", favorite.Account.id);
					command.Parameters.AddWithValue("@song", favorite.Song.Id);
					
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
			catch (Exception ex)
			{
				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto Update(FavoriteDto entity)
		{
			throw new NotImplementedException();
		}
	}
}
