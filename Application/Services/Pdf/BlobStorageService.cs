using Azure.Storage.Blobs;
using CalcAppAPI.Infrastructure.Options;
using Microsoft.Extensions.Options;

namespace CalcAppAPI.Application.Services.Pdf
{
    public class BlobStorageService : IBlobStorageService
    {
        private readonly string _connectionString;

        public BlobStorageService(IOptions<BlobOptions> options)
        {
            _connectionString = options.Value.ConnectionString;
        }

        public async Task UploadAsync(string container, string name, Stream stream)
        {
            var blob = new BlobContainerClient(_connectionString, container)
                .GetBlobClient(name);

            stream.Position = 0;
            await blob.UploadAsync(stream, overwrite: true);
        }

        public async Task<byte[]> DownloadAsync(string container, string name)
        {
            var blob = new BlobClient(_connectionString, container, name);

            using var stream = new MemoryStream();
            await blob.DownloadToAsync(stream);
            return stream.ToArray();
        }
    }

}
