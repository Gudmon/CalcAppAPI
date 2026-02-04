namespace CalcAppAPI.Infrastructure.KeyVault
{
    public interface ISecretProvider
    {
        Task<string> GetSecretAsync(string name);
    }
}
