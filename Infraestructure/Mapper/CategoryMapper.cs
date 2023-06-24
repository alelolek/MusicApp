using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Interface;

namespace Infraestructure.Mapper
{
	public class CategoryMapper : IMapper<Category, CategoryDto>
	{
		public Category MapDtoToEntity(CategoryDto dto)
		{
			return new Category
			{
				id =dto.id,
				name = dto.name,
			};
		}

		public CategoryDto MapEntityToDto(Category category)
		{
			return new CategoryDto
			{
				id = category.id,
				name = category.name,
			};
		}
	}
}
