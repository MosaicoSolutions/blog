using MongoDB.Driver;
using System;
using System.Linq.Expressions;

namespace MosaicoSolutions.Blog.Domain.Core.Models
{
    public class PagingParameter<TEntity> where TEntity : class, IEntity
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Expression<Func<TEntity, bool>> Filter { get; set; }
        public Expression<Func<TEntity, object>> OrderBy { get; set; }
        public SortDirection Sort { get; set; }
        public TEntity Parameters { get; set; }
    }
}
