using System.Collections.Generic;

namespace MosaicoSolutions.Blog.Domain.Core.Models
{
    public interface IPage<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Data { get; }
        long RecordsTotal { get; }
        long RecordsFiltered { get; }
    }
}
