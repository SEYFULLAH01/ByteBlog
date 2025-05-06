using ByteBlog.Service.Services.Abstractions;
using ByteBlog.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ByteBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
