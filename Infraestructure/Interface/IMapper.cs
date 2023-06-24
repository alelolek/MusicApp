using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Interface
{
	public  interface IMapper<TEntity, TDto>
	{
		TDto MapEntityToDto(TEntity entity);

		TEntity MapDtoToEntity(TDto dto);
	}
}
