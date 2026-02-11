namespace CalcAppAPI.Application.Services.Pdf
{
    public interface IBlobStorageService
    {
        Task UploadAsync(string container, string name, Stream stream, CancellationToken cancellationToken);
        Task<byte[]> DownloadAsync(string container, string name, CancellationToken cancellationToken);
    }
}
