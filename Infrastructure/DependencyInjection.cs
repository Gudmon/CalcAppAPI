using CalcAppAPI.Data;
using CalcAppAPI.Domain.Entities.Email;
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
            var fromEmailAddress = await secretProvider.GetSecretAsync("FromEmailAddress");
            var toEmailAddress = await secretProvider.GetSecretAsync("ToEmailAddress");
            var toEmailAddressTest = await secretProvider.GetSecretAsync("ToEmailAddressTest");
            var fromEmailPw = await secretProvider.GetSecretAsync("FromEmailPassword");

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(dbConnection);
            });

            services.Configure<BlobOptions>(opt =>
            {
                opt.ConnectionString = blobConnection;
            });
            services.Configure<EmailOptions>(options =>
            {
                options.FromEmailAddress = fromEmailAddress.Trim('"');
                options.ToEmailAddress = toEmailAddress.Trim('"');
                options.ToEmailAddressTest = toEmailAddressTest.Trim('"');
                options.FromEmailPw = fromEmailPw.Trim('"');
                options.SmtpHost = "smtp.gmail.com";
                options.SmtpPort = 587;
            });
        }
    }
}
