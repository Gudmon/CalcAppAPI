using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;

namespace CalcAppAPI.Application.Interfaces
{
    public interface IPalmsQueryHandler
    {
        Task<IEnumerable<PalmsTrailerCardOverviewDto>> GetTrailersAsync(CancellationToken cancellationToken);
        Task<PalmsTrailerDetailsDto> GetTrailerAsync(int id, CancellationToken cancellationToken);
        Task<IEnumerable<PalmsCraneCardOverviewDto>> GetCranesAsync(CancellationToken cancellationToken);
        Task<PalmsCraneDetailsDto> GetCraneAsync(int id, CancellationToken cancellationToken);
        Task<PalmsTrailerConfigurationsDto> GetTrailerConfigurationsAsync(int trailerId, CancellationToken cancellationToken);
    }
}
