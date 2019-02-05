using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using MosaicoSolutions.Blog.Application;
using MosaicoSolutions.Blog.Infra.CrossCutting.IoC;
using MosaicoSolutions.Blog.Infra.Data.Contexts.Options;
using Newtonsoft.Json;
using System.IO;

namespace MosaicoSolutions.Blog.WebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                    .AddJsonOptions(options => options.SerializerSettings.Formatting = Formatting.Indented)
                    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ApplicationAssembly>());

            services.Configure<BlogContextOptions>(Configuration.GetSection(nameof(BlogContextOptions)));

            services.RegisterNativeServices();

            services.AddCors();

            services.AddAutoMapper(typeof(ApplicationAssembly));

            services.AddMediatR(typeof(ApplicationAssembly));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "posts")),
                RequestPath = "/posts"
            });
        }
    }
}
