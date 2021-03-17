using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Core.Specifications
{
    public interface ISpecification<T> 
    {
         Expression<Func<T, bool>> Criteria{get;}
        List<Expression<Func<T, Object>>> Includes {get;}
        Expression<Func<T, object>> OrderByDescending {get;}

        Expression<Func<T, object>> OrderBy {get;}

        int Take {get;}
        int Skip {get;}
        bool IsPagingEnabled {get;}
        
    }
}