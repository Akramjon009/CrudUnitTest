using MarketPlace.Application.Abstractions;
using MarketPlace.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MarketPlace.Application
{
    public static class AppDepInjection
    {
        public static IServiceCollection AddAppLication(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
