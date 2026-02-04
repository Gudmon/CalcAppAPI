using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace CalcAppAPI.Infrastructure.KeyVault
{
    public class AzureKeyVaultSecretProvider : ISecretProvider
    {
        private readonly SecretClient _client;

        public AzureKeyVaultSecretProvider(IConfiguration config)
        {
            var uri = config["KeyVault:Uri"];
            _client = new SecretClient(new Uri(uri!), new DefaultAzureCredential());
        }

        public async Task<string> GetSecretAsync(string name)
        {
            var secret = await _client.GetSecretAsync(name);
            return secret.Value.Value.Trim('"');
        }
    }
}
