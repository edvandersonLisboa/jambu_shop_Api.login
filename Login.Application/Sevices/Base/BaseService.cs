using System.Linq.Expressions;
using AutoMapper;
using Login.Application.Sevices.Interfaces.Base;
using Login.Domain.DTOs.Mappings;
using Login.Domain.Interfaces.Base;

namespace Login.Application.Sevices.Base;

public class BaseService<TDTO, TEntity> : IBaseService<TDTO>
{
    public readonly IBaseRepository<TEntity>  _repository;
    private readonly IMapper _mapper;
    public BaseService(IMapper mapper,IBaseRepository<TEntity>  repository )
    {
        _mapper = mapper;
        _repository = repository;
    }

    public TDTO Add(TDTO tdto)
    {
         try{
            var entities = _mapper.Map<TEntity>(tdto);
            var entitiesResult = _repository.Add(entities);
            return _mapper.Map<TDTO>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }

    }

    public async Task<TDTO> AddAsync(TDTO tdto)
    {
         try{
            var entities = _mapper.Map<TEntity>(tdto);
            var entitiesResult = await  _repository.AddAsync(entities);
            return _mapper.Map<TDTO>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
    }

    public async Task<IEnumerable<TDTO>> AddRange(IEnumerable<TDTO> tdto)
    {
        try{
            var entities = _mapper.Map<IEnumerable<TEntity>>(tdto);
            var entitiesResult = _repository.AddRange(entities);
            return _mapper.Map<IEnumerable<TDTO>>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
        
    }

    public async Task<IEnumerable<TDTO>> Find(Expression<Func<TDTO, bool>> predicate)
    {
        try{
            Expression<Func<TEntity, bool>> entityPredicate = MappingExpression<TDTO, TEntity>.Map(predicate);
            var entities = _repository.Find(entityPredicate);
            return _mapper.Map<IEnumerable<TDTO>>(entities);
        }
        catch(Exception err){
            throw new NotImplementedException(err.Message);
        }
;
    }

    public TDTO Get(int id)
    {
        try{
            var entitiesResult = _repository.Get(id);
            return _mapper.Map<TDTO>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
    }

    public virtual IEnumerable<TDTO> GetAll()
    {
        var val = _repository.GetAll();
        return  _mapper.Map<IEnumerable<TDTO>>(val);
    }

    public virtual async Task<IEnumerable<TDTO>> GetAllLisAsync()
    {
         var val = await _repository.GetAllLisAsync();
        return  _mapper.Map<IEnumerable<TDTO>>(val);
    }

    public TDTO Remove(TDTO tdto)
    {
        try{
            var entities = _mapper.Map<TEntity>(tdto);
            var entitiesResult =  _repository.Remove(entities);
            return _mapper.Map<TDTO>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
    }

    public async Task<IEnumerable<TDTO>> RemoveRange(IEnumerable<TDTO> tdtos)
    {
        try{
            var entities = _mapper.Map<IEnumerable<TEntity>>(tdtos);
            var entitiesResult =  _repository.RemoveRange(entities);
            return _mapper.Map<IEnumerable<TDTO>>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
    }

    public async Task<TDTO> SingleOrDefault(Expression<Func<TDTO, bool>> predicate)
    {
        try{
            Expression<Func<TEntity, bool>> entityPredicate = MappingExpression<TDTO, TEntity>.Map(predicate);
            var entities = _repository.Find(entityPredicate);
            return _mapper.Map<TDTO>(entities);
        }
        catch(Exception err){
            throw new NotImplementedException(err.Message);
        }
    }

    public async Task<TDTO> Update(TDTO tdto)
    {
       try{
            var entities = _mapper.Map<TEntity>(tdto);
            var entitiesResult =  _repository.Update(entities);
            return _mapper.Map<TDTO>(entitiesResult);
        }catch(Exception err){
            throw new Exception( err.Message);
        }
    }
}
