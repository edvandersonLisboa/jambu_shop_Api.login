using System.Linq.Expressions;

namespace Login.Domain.DTOs.Mappings;

public class MappingExpression<TDTO,TEntity>
{
    /// <summary>
    /// Coverter Expressão DTO para Entity
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static Expression<Func<TEntity, bool>> Map(Expression<Func<TDTO, bool>> predicate)
    {
        var parameter = Expression.Parameter(typeof(TEntity));
        var visitor = new ParameterVisitor(predicate.Parameters[0], parameter);
        var body = visitor.Visit(predicate.Body);
        return Expression.Lambda<Func<TEntity, bool>>(body, parameter);
    }
    /// <summary>
    /// Converter Expressao Entity para DTO
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static Expression<Func<TDTO, bool>> Map(Expression<Func<TEntity, bool>> predicate)
    {
        var parameter = Expression.Parameter(typeof(TDTO));
        var visitor = new ParameterVisitor(predicate.Parameters[0], parameter);
        var body = visitor.Visit(predicate.Body);
        return Expression.Lambda<Func<TDTO, bool>>(body, parameter);
    }

    private class ParameterVisitor : ExpressionVisitor
    {
        private readonly ParameterExpression _oldParameter;
        private readonly ParameterExpression _newParameter;

        public ParameterVisitor(ParameterExpression oldParameter, ParameterExpression newParameter)
        {
            _oldParameter = oldParameter;
            _newParameter = newParameter;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return node == _oldParameter ? _newParameter : base.VisitParameter(node);
        }
    }
}