using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Contexts;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options;

namespace MosaicoSolutions.Blog.Infra.Data.Contexts
{
    public class BlogContext : MongoDBContext
    {
        public BlogContext(IMongoDBConnectionOptions mongoDbOptions) : base(mongoDbOptions)
        { }
    }
}
