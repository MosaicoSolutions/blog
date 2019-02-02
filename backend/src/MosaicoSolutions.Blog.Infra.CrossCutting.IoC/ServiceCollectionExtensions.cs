using Microsoft.Extensions.DependencyInjection;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Infra.Data.Contexts;
using MosaicoSolutions.Blog.Infra.Data.Repositories;

namespace MosaicoSolutions.Blog.Infra.CrossCutting.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<BlogContext>();

            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
    }
}
