using CalcAppAPI.Data;
using CalcAppAPI.Infrastructure.KeyVault;
using CalcAppAPI.Infrastructure.Options;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static async Task AddInfrastructureAsync(
        this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddSingleton<ISecretProvider, AzureKeyVaultSecretProvider>();

            var provider = services.BuildServiceProvider();
            var secretProvider = provider.GetRequiredService<ISecretProvider>();

            var dbConnection = await secretProvider.GetSecretAsync("DBConnection");
            var blobConnection = await secretProvider.GetSecretAsync("BlobConnection");

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(dbConnection);
            });

            services.Configure<BlobOptions>(opt =>
            {
                opt.ConnectionString = blobConnection;
            });
        }
    }
}
