using ByteBlog.Service.Services.Abstractions;
using ByteBlog.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ByteBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
