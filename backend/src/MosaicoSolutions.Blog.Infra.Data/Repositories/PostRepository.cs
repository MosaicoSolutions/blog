using MosaicoSolutions.Blog.Domain.Models;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Infra.Data.Contexts;

namespace MosaicoSolutions.Blog.Infra.Data.Repositories
{
    public class PostRepository : MongoDBRepository<Post>, IPostRepository
    {
        public PostRepository(BlogContext mongoDBContext) : base(mongoDBContext)
        {}
    }
}
