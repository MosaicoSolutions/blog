using System;
using System.Linq;

namespace MosaicoSolutions.Blog.Domain.Core.Models.Extensions
{
    public static class PageExtensions
    {
        public static IPage<TResult> Map<TEntity, TResult>(this IPage<TEntity> @this, Func<TEntity, TResult> map) where TEntity: class 
                                                                                                                  where TResult : class
            => new Page<TResult>
            {
                RecordsTotal = @this.RecordsTotal,
                RecordsFiltered = @this.RecordsFiltered,
                Data = @this.Data.Select(map)
            };
    }
}
