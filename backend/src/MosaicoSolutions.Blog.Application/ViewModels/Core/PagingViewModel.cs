using MongoDB.Driver;
using MosaicoSolutions.Blog.Domain.Core;

namespace MosaicoSolutions.Blog.Application.ViewModels.Core
{
    public class PagingViewModel<TEntity> where TEntity : class, IEntity
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string OrderBy { get; set; }
        public SortDirection Sort { get; set; }
        public TEntity Parameters { get; set; }
    }
}
