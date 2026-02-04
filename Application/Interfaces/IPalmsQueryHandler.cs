using CalcAppAPI.Application.Dtos.Palms.Trailer;

namespace CalcAppAPI.Application.Interfaces
{
    public interface IPalmsQueryHandler
    {
        Task<TrailerDetailsDto?> GetTrailerAsync(int id);
    }
}
