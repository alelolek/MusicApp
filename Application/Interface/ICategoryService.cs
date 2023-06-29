using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Repositories;

namespace Business.Interface
{
	public interface ICategoryService
	{
		public ResponseDto CreateCategory(CategoryDto categoryDto);

		public ResponseDto EditCategory(CategoryDto categoryDto);

		public ResponseDto DeleteCategory(int categoryId);
		public List<CategoryDto> GetAllCategory();
	}
}
