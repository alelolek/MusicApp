
using System.Data.SqlClient;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class AlbumRepository : IRepository<AlbumDto>
	{
		private readonly SqlConnection connection;
		private readonly IMapper<Album, AlbumDto> mapper;

		public AlbumRepository()
		{
			connection = DatabaseConnection.GetInstance().GetConnection();
			mapper = new AlbumMapper();
		}
		
		private void ReadAlbum(SqlCommand command, List<AlbumDto> albumsDto)
		{
			connection.Open();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Album album = new Album();
					album.id = reader.GetInt32(0);
					album.name = reader.GetString(1);
					album.urlImage = reader.GetString(2);
					var albumDto = mapper.MapEntityToDto(album);
					albumsDto.Add(albumDto);
				}
			}
			connection.Close();
		}

		public ResponseDto Delete(int albumId)
		{
			var response = new ResponseDto();

			try
			{
				var query = "DELETE FROM Album WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", albumId);
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

		public List<AlbumDto> GetAll()
		{
			List<AlbumDto> albumsDto = new List<AlbumDto>();

			try
			{
				var query = "SELECT * FROM Album";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					ReadAlbum(command, albumsDto);
				}
			}
			catch (Exception)
			{
				throw;
			}
			return albumsDto;
		}

		public ResponseDto Save(AlbumDto albumsDto)
		{
			var response = new ResponseDto();
			var album = mapper.MapDtoToEntity(albumsDto);

			try
			{
				var query = "INSERTE INTO Album(name,urlImage) VALUES(@name,@urlImage)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", album.name);
					command.Parameters.AddWithValue("@urlImage", album.urlImage);
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

		public ResponseDto Update(AlbumDto albumDto)
		{
			var response = new ResponseDto();
			var album = mapper.MapDtoToEntity(albumDto);

			try
			{
				var query = "UPDATE Album SET name = @name, urlImage = @urlImage WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", album.name);
					command.Parameters.AddWithValue("@urlImage", album.urlImage);
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
