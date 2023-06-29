using System.Data.SqlClient;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class ArtistRepository : IRepository<ArtistDto>
	{
		private readonly SqlConnection connection;
		private readonly IMapper<Artist, ArtistDto> mapper;

        public ArtistRepository()
        {
			connection = DatabaseConnection.GetInstance().GetConnection();
			mapper = new ArtistMapper();
		}

		private void ReadArtist(SqlCommand command, List<ArtistDto> artistsDto)
		{
			connection.Open();
			using(SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Artist artist = new Artist();
					artist.Id = reader.GetInt32(0);
					artist.Name = reader.GetString(1);
					artist.UrlImage = reader.GetString(2);
					var artistDto = mapper.MapEntityToDto(artist);
					artistsDto.Add(artistDto);
				}
			}
			connection.Close();
		}


        public ResponseDto Delete(int artistId)
		{
			var response = new ResponseDto();

			try
			{
				var query = "DELETE FROM Artist WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", artistId);
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

		public List<ArtistDto> Get(Func<ArtistDto, bool>? filter = null)
		{
			List<ArtistDto> artistsDto = new List<ArtistDto>();

			try
			{
				var query = "SELECT * FROM Artist";
				using(SqlCommand command = new SqlCommand(query, connection))
				{
					ReadArtist(command, artistsDto);
				}
			}
			catch (Exception ex)
			{
				throw;
			}

			if (filter != null)
				artistsDto = artistsDto.Where(filter).ToList();

			return artistsDto;			
		}

		public ResponseDto Save(ArtistDto artistsDto)
		{
			var response = new ResponseDto();
			var artist = mapper.MapDtoToEntity(artistsDto);
			try
			{
				var query = "INSERT INTO Artists(name,urlImage) VALUES(@name,@urlImage)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", artist.Name);
					command.Parameters.AddWithValue("@urlImage", artist.UrlImage);
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

		public ResponseDto Update(ArtistDto artistsDto)
		{
			var response = new ResponseDto();
			var artist = mapper.MapDtoToEntity(artistsDto);
			try
			{
				var query = "UPDATE Artist SET name = @name,urlImage = @urlImage WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", artist.Name);
					command.Parameters.AddWithValue("@urlImage", artist.UrlImage);
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
	}
}
