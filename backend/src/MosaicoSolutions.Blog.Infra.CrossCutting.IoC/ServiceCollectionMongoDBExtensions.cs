using Microsoft.Extensions.DependencyInjection;
using MosaicoSolutions.Blog.Infra.Data.Contexts;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Options;

namespace MosaicoSolutions.Blog.Infra.CrossCutting.IoC
{
    public static class ServiceCollectionMongoDBExtensions
    {
        public static IServiceCollection AddMongoDB(this IServiceCollection services, IMongoDBConnectionOptions mongoDBConnectionOptions)
        {
            services.AddScoped(serviceProvider => new BlogContext(mongoDBConnectionOptions));
            return services;
        }
    }
}