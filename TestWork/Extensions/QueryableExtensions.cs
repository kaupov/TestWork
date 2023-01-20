using TestWork.Controllers;
using TestWork.DTOs;

namespace TestWork.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<T> Apply<T>(this IQueryable<T> queryable, PagingParameters pagingParameters)
    {
        return queryable.Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
            .Take(pagingParameters.PageSize);
    }
}