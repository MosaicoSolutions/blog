using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options;

namespace MosaicoSolutions.Blog.Infra.Data.Contexts.Options
{
    public class BlogContextOptions : IMongoDBConnectionOptions
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
