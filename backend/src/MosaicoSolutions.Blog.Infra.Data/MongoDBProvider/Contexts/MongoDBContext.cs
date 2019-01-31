using MongoDB.Driver;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options;

namespace MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Contexts
{
    public class MongoDBContext
    {
        protected readonly IMongoDatabase Database;

        public MongoDBContext(IMongoDBConnectionOptions mongoDBConnectionOptions)
        {
            var client = new MongoClient(mongoDBConnectionOptions.ConnectionString);
            Database = client.GetDatabase(mongoDBConnectionOptions.Database);
        }

        public IMongoCollection<T> GetCollection<T>()
            => Database.GetCollection<T>(typeof(T).Name);
    }
}
