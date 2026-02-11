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

        public async Task UploadAsync(string container, string name, Stream stream, CancellationToken cancellationToken)
        {
            var blob = new BlobContainerClient(_connectionString, container)
                .GetBlobClient(name);

            stream.Position = 0;
            await blob.UploadAsync(stream, overwrite: true, cancellationToken);
        }

        public async Task<byte[]> DownloadAsync(string container, string name, CancellationToken cancellationToken)
        {
            var blob = new BlobClient(_connectionString, container, name);

            using var stream = new MemoryStream();
            await blob.DownloadToAsync(stream, cancellationToken);
            return stream.ToArray();
        }
    }

}
