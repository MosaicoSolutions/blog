using MosaicoSolutions.Blog.Domain.Core.Models;

namespace MosaicoSolutions.Blog.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IPage<TEntity> Page(PagingParameter pagingParameter);
    }
}
