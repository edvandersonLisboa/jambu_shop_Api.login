using System.Linq.Expressions;

namespace Login.Application.Sevices.Interfaces.Base;

public  interface IBaseService<TDTO>
{

    Task<IEnumerable<TDTO>> Find(Expression<Func<TDTO, bool>> predicate);
    Task<TDTO> SingleOrDefault(Expression<Func<TDTO, bool>> predicate);
    Task<IEnumerable<TDTO>> RemoveRange(IEnumerable<TDTO> entities);
    Task<IEnumerable<TDTO>> AddRange(IEnumerable<TDTO> entities);
        //IList<TEntity> BulkInsert(IList<TEntity> entities);
    Task<TDTO> AddAsync(TDTO entity);//create post async
    Task<IEnumerable<TDTO>> GetAllLisAsync();
    Task<TDTO> Update(TDTO entity);
    IEnumerable<TDTO> GetAll();
    TDTO Remove(TDTO entity);
    TDTO Add(TDTO entity);
    TDTO Get(int id);
}
