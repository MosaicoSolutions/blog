using MosaicoSolutions.Blog.Domain.Core.Types;
using System;
using System.Linq.Expressions;

namespace MosaicoSolutions.Blog.Domain.Core.Models
{
    public class PagingParameter<TEntity> where TEntity : class
    {
        public int Start { get; set; }
        public int Length { get; set; }
        public Expression<Func<TEntity, bool>> Filter { get; set; }
        public Expression<Func<TEntity, object>> OrderBy { get; set; }
        public Sort Sort { get; set; }
    }
}
