using MosaicoSolutions.Blog.Domain.Core;
using MosaicoSolutions.Blog.Domain.Core.Models;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity: class, IEntity
    {
        Task<IPage<TEntity>> Page(PagingParameter<TEntity> pagingParameter);
    }
}
