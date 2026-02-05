namespace CalcAppAPI.Application.Services.Pdf
{
    public interface IBlobStorageService
    {
        Task UploadAsync(string container, string name, Stream stream);
        Task<byte[]> DownloadAsync(string container, string name);
    }
}
