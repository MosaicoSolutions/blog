using System;
using System.Collections.Generic;
using System.Text;

namespace MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options
{
    public interface IMongoDBConnectionOptions
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
