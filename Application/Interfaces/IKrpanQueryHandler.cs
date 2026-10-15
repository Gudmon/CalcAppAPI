using CalcAppAPI.Application.Dtos.Krpan.Crane;
using CalcAppAPI.Application.Dtos.Krpan.Trailer;

namespace CalcAppAPI.Application.Interfaces
{
    public interface IKrpanQueryHandler
    {
        Task<IEnumerable<KrpanTrailerCardOverviewDto>> GetTrailersAsync(CancellationToken cancellationToken);
        Task<KrpanTrailerDetailsDto> GetTrailerAsync(int id, CancellationToken cancellationToken);
        Task<IEnumerable<KrpanCraneCardOverviewDto>> GetCranesAsync(CancellationToken cancellationToken);
        Task<KrpanCraneDetailsDto> GetCraneAsync(int id, CancellationToken cancellationToken);
    }
}
