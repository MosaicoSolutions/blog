using Microsoft.Extensions.Options;
using MosaicoSolutions.Blog.Infra.Data.Contexts.Options;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Contexts;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options;

namespace MosaicoSolutions.Blog.Infra.Data.Contexts
{
    public class BlogContext : MongoDBContext
    {
        public BlogContext(IOptions<BlogContextOptions> options) : base(options.Value)
        { }
    }
}
