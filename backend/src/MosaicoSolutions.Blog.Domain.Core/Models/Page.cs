using System.Collections.Generic;
using System.Linq;

namespace MosaicoSolutions.Blog.Domain.Core.Models
{
    public class Page<TEntity> : IPage<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Data { get; set; }
        public long RecordsTotal { get; set; }
        public long RecordsFiltered { get; set; }
    }
}
