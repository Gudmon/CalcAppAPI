using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalmsController : ControllerBase
    {
        private readonly IPalmsQueryHandler _queryHandler;

        public PalmsController(IPalmsQueryHandler queryHandler)
        {
            _queryHandler = queryHandler;
        }

        [HttpGet("trailers")]
        public async Task<ActionResult<IEnumerable<PalmsTrailerCardOverviewDto>>> GetAllTrailers(CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetTrailersAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("trailers/{id}")]
        public async Task<ActionResult<PalmsTrailerDetailsDto>> GetTrailer(int id, CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetTrailerAsync(id, cancellationToken);
            return Ok(result);
        }

        [HttpGet("trailers/{id}/configs")]
        public async Task<ActionResult<PalmsTrailerConfigurationsDto>> GetConfigs(int id, CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetTrailerConfigurationsAsync(id, cancellationToken);
            return Ok(result);
        }

        [HttpGet("cranes")]
        public async Task<ActionResult<IEnumerable<PalmsCraneCardOverviewDto>>> GetAllCranes(CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetCranesAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("cranes/{id}")]
        public async Task<ActionResult<Crane>> GetCrane(int id, CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetCraneAsync(id, cancellationToken);
            return Ok(result);
        }
    }
}
