
using System.Data.SqlClient;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class SongRepository : IRepository<SongDto>
	{
		private readonly SqlConnection connection;
		private readonly IMapper<Song, SongDto> mapper;

		public SongRepository()
        {
			connection = DatabaseConnection.GetInstance().GetConnection();
			mapper = new SongMapper();
		}

		private void ReadSong(SqlCommand command, List<SongDto> songsDto)
		{
			connection.Open();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					Song song = new Song();
					song.Id = reader.GetInt32(0);
					song.Name = reader.GetString(1);
					song.Artist = new Artist
					{
						Id = reader.GetInt32(2),
						UrlImage = reader.GetString(3),
					};
					song.Album = new Album
					{
						Id = reader.GetInt32(4),
						UrlImage = reader.GetString(5),
					};
					song.Category = new Category
					{
						Id = reader.GetInt32(6),
						Name = reader.GetString(7),
					};
					var songDto = mapper.MapEntityToDto(song);
					songsDto.Add(songDto);
				}
			}
			connection.Close();
		}

		public ResponseDto Delete(int songId)
		{
			var response = new ResponseDto();
			try
			{
				var query = "DELETE FROM Song WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", songId);
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

		public List<SongDto> Get(Func<SongDto, bool>? filter = null)
		{
			List<SongDto> songsDto = new List<SongDto>();

			try
			{
				var query = "SELECT * FROM Song";
				using(SqlCommand command = new SqlCommand(query, connection))
				{
					ReadSong(command, songsDto);
				}
			}
			catch (Exception ex)
			{
				throw;
			}

			if (filter != null)
				songsDto = songsDto.Where(filter).ToList();

			return songsDto;
		}

		public ResponseDto Save(SongDto songsDto)
		{
			var response = new ResponseDto();
			var song = mapper.MapDtoToEntity(songsDto);
			try
			{
				var query = "INSERT INTO Song(Name,Artist_Id,Album_Id,Category_Id) VALUES(@name,@artist,@album,@category)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", song.Name);
					command.Parameters.AddWithValue("@artist", song.Artist.Id);
					command.Parameters.AddWithValue("@album", song.Album.Id);
					command.Parameters.AddWithValue("@category", song.Category.Id);
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

		public ResponseDto Update(SongDto songsDto)
		{
			var response = new ResponseDto();
			var song = mapper.MapDtoToEntity(songsDto);
			try
			{
				var query = "UPDATE Song SET Name = @name,Artist_Id=@artist,Album_Id=@album, Category_Id=@category   WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", song.Name);
					command.Parameters.AddWithValue("@artist", song.Artist.Id);
					command.Parameters.AddWithValue("@album", song.Album.Id);
					command.Parameters.AddWithValue("@category", song.Category.Id);
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
