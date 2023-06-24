using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO.Standar;

namespace Infraestructure.Interface
{
	public interface IRepository<TEntity>
	{
		List<TEntity> GetAll();
		ResponseDto Save(TEntity entity);
		ResponseDto Delete(int entityId);
		ResponseDto Update(TEntity entity);
	}
}
