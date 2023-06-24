using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Interface;
using Infraestructure.Repositories;

namespace Business.Services
{
	public class CategoryService
	{
		private readonly IRepository<CategoryDto> categoryRepository;

		public CategoryService()
		{
			categoryRepository = new CategoryRepository();
		}

		public ResponseDto CreateAlbum(CategoryDto categoryDto)
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

		public ResponseDto EditAlbum(CategoryDto categoryDto)
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

		public ResponseDto DeleteAlbum(CategoryDto categoryDto)
		{
			var response = new ResponseDto();
			try
			{
				response = categoryRepository.Delete(categoryDto.id);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}
	}
}
