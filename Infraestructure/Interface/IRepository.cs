using CrossCuting.DTO.Standar;

namespace Infraestructure.Interface
{
	public interface IRepository<TEntity>
	{
		List<TEntity> Get(Func<TEntity, bool>? filter = null);
		ResponseDto Save(TEntity entity);
		ResponseDto Delete(int entityId);
		ResponseDto Update(TEntity entity);
	}
}
