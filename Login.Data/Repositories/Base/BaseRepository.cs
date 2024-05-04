using System.Linq.Expressions;
using Login.Data.Contexts;
using Login.Domain.Interfaces.Base;
using Microsoft.EntityFrameworkCore;

namespace Login.Data.Repositories.Base;

public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDBContext _context;
    protected DbSet<TEntity> DbSet;

    public BaseRepository(AppDBContext context)
    {
        _context = context;
        DbSet = context.Set<TEntity>();
    }


    public virtual TEntity Add(TEntity entity)
    {
        var result = DbSet.Add(entity);
        SaveChanges();
        return result.Entity;
    }
    public virtual IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
    {
        DbSet.AddRange(entities);
        SaveChanges();
        return entities;
    }

    public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {

        return DbSet.AsNoTracking().Where(predicate);
    }
    public virtual TEntity Get(int id)
    {
        return DbSet.Find(id);
    }
    public virtual IEnumerable<TEntity> GetAll()
    {
        return DbSet.AsNoTracking();
    }
    public virtual TEntity Remove(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Deleted;
        DbSet.Remove(entity);
        SaveChanges();
        return entity;
    }
    public virtual IEnumerable<TEntity> RemoveRange(IEnumerable<TEntity> entities)
    {
        DbSet.RemoveRange(entities);
        SaveChanges();
        return entities;
    }
    public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
    {
        return DbSet.AsNoTracking().SingleOrDefault(predicate);
    }
    public virtual async Task<TEntity> Update(TEntity entity)
    {
        var entry = _context.Entry(entity);
        DbSet.Attach(entity);
        entry.State = EntityState.Modified;
        SaveChanges();

        return entity;
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<TEntity> AddAsync(TEntity entity)
    {
        var result = DbSet.Add(entity);

        SaveChangesAsync().Wait();

        return result.Entity;
    }
    public virtual Task<List<TEntity>> GetAllLisAsync()
    {
        var result = DbSet.AsNoTracking().ToListAsync();

        return result;
    }
}
