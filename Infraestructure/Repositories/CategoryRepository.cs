﻿using System.Data.SqlClient;
using System.Security.Principal;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class CategoryRepository : IRepository<CategoryDto>
	{
		private readonly SqlConnection connection;
		private readonly IMapper<Category, CategoryDto> mapper;

        public CategoryRepository()
        {
            connection = DatabaseConnection.GetInstance().GetConnection();
			mapper = new CategoryMapper();
        }

		private void ReadCategory(SqlCommand command,List<CategoryDto> categoriesDto)
		{
			connection.Open();
			using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Category category = new Category();
						category.Id = reader.GetInt32(0);
						category.Name = reader.GetString(1);
						var categoryDto = mapper.MapEntityToDto(category);
						categoriesDto.Add(categoryDto);
					}
				}
			connection.Close();
		}

        public ResponseDto Delete(int categoryId)
		{
			var response = new ResponseDto();

			try
			{
				var query = "DELETE FROM Category WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", categoryId);
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

		public List<CategoryDto> Get(Func<CategoryDto, bool>? filter = null)
		{
			List<CategoryDto> categoryDto = new List<CategoryDto>();

			try
			{
				var query = "SELECT * FROM Category";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					ReadCategory(command, categoryDto);
				}
			}
			catch (Exception)
			{
				throw;
			}
			if (filter != null)
				categoryDto = categoryDto.Where(filter).ToList();

			return categoryDto;
		}

		public ResponseDto Save(CategoryDto categoryDto)
		{
			var response = new ResponseDto();
			var category = mapper.MapDtoToEntity(categoryDto);

			try
			{
				var query = "INSERT INTO Category(name) VALUES(@name)";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@name", category.Name);
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

		public ResponseDto Update(CategoryDto categoryDto)
		{
			var response = new ResponseDto();
			var category = mapper.MapDtoToEntity(categoryDto);

			try
			{
				var query = "UPDATE Category SET name = @name  WHERE id = @id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@id", category.Id);
					command.Parameters.AddWithValue("@name", category.Name);
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
