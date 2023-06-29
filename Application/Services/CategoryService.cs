using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Interface;
using Infraestructure.Repositories;
using Business.Interface;

namespace Business.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IRepository<CategoryDto> categoryRepository;

		public CategoryService()
		{
			categoryRepository = new CategoryRepository();
		}

		public ResponseDto CreateCategory(CategoryDto categoryDto)
		{
			var response = new ResponseDto();
			try
			{
				response = categoryRepository.Save(categoryDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto EditCategory(CategoryDto categoryDto)
		{
			var response = new ResponseDto();
			try
			{
				response = categoryRepository.Update(categoryDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto DeleteCategory(int categoryId)
		{
			var response = new ResponseDto();
			try
			{
				response = categoryRepository.Delete(categoryId);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public List<CategoryDto> GetAllCategory()
		{
			List<CategoryDto> category;
			try
			{
				category = categoryRepository.Get();
			}
			catch
			{
				throw;
			}
			return category;
		}
	}
}
