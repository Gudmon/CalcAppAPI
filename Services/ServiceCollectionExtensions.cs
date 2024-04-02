using Microsoft.Extensions.DependencyInjection;

namespace CalcAppAPI.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddScopedWithName<TService, TImplementation>(
            this IServiceCollection services, string name)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddScoped<TImplementation>();
            services.AddScoped(provider =>
            {
                var instance = provider.GetRequiredService<TImplementation>();
                return instance;
            });
            services.AddScoped<TService>(provider => provider.GetRequiredService<TImplementation>());
            services.AddScoped(provider =>
            {
                var instance = provider.GetRequiredService<TImplementation>();
                return instance;
            });
            services.AddScoped<TService>(provider => provider.GetRequiredService<TImplementation>());

            return services;
        }
    }
}
