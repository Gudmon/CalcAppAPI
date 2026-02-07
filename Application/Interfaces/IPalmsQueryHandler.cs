using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;

namespace CalcAppAPI.Application.Interfaces
{
    public interface IPalmsQueryHandler
    {
        Task<IEnumerable<PalmsTrailerCardOverviewDto>> GetTrailersAsync();
        Task<PalmsTrailerDetailsDto> GetTrailerAsync(int id);
        Task<IEnumerable<PalmsCraneCardOverviewDto>> GetCranesAsync();
        Task<PalmsCraneDetailsDto> GetCraneAsync(int id);
        Task<PalmsTrailerConfigurationsDto> GetTrailerConfigurationsAsync(int trailerId);
    }
}
