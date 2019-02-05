using Microsoft.Extensions.DependencyInjection;
using MosaicoSolutions.Blog.Application.Services;
using MosaicoSolutions.Blog.Application.Services.Interfaces;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Infra.Data.Contexts;
using MosaicoSolutions.Blog.Infra.Data.Repositories;

namespace MosaicoSolutions.Blog.Infra.CrossCutting.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterNativeServices(this IServiceCollection services)
        {
            services.AddScoped<BlogContext>();

            services.AddScoped<IPostRepository, PostRepository>();

            services.AddScoped<IPostAppService, PostAppService>();

            return services;
        }
    }
}
