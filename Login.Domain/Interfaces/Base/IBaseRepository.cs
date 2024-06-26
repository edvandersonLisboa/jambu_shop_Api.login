using System.Linq.Expressions;

namespace Login.Domain.Interfaces.Base;

public interface IBaseRepository<TEntity>
{
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entities);
    IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);
        //IList<TEntity> BulkInsert(IList<TEntity> entities);
    Task<TEntity> AddAsync(TEntity entity);//create post async
    Task<List<TEntity>> GetAllLisAsync();
    Task<TEntity> Update(TEntity entity);
    IEnumerable<TEntity> GetAll();
    TEntity Remove(TEntity entity);
    TEntity Add(TEntity entity);
    TEntity Get(int id);
}
