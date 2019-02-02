using MongoDB.Driver;
using System.Threading;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Extensions
{
    public static class MongoCollectionExtensions
    {
        public static Task<long> CountDocumentsAsync<TDocument>(this IMongoCollection<TDocument> collection, CancellationToken cancellationToken = default(CancellationToken))
            => collection.CountDocumentsAsync(filter: _ => true, cancellationToken: cancellationToken);
    }
}
