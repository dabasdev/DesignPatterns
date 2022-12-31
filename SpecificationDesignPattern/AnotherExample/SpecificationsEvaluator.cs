using Microsoft.EntityFrameworkCore;
using SpecificationDesignPattern.Model;

namespace SpecificationDesignPattern.AnotherExample;

public class SpecificationsEvaluator
{
    public static IQueryable<TEntity> GetQuery<TEntity>(IQueryable<TEntity> query , 
        Specifications<TEntity> specification) where TEntity : Entity
    {
        var queryable = query;

        if(specification.Criteria is not null)
            queryable = queryable.Where(specification.Criteria);

        queryable = specification.IncludeExpressions.Aggregate(queryable,
            (entities, expression) => queryable.Include(expression));

        if (specification.OrderByExpression is not null)
        {
            queryable = queryable.OrderBy(specification.OrderByExpression);
        }
        else if (specification.OrderByDescendingExpression is not null)
        {
            queryable = queryable.OrderByDescending(specification.OrderByDescendingExpression);
        }

        if (specification.IsSplitQuery)
            queryable = queryable.AsSplitQuery();

        return queryable;
    }
}