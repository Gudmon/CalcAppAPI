using CalcAppAPI.Application.Dtos.Krpan.Crane;
using CalcAppAPI.Application.Dtos.Krpan.Trailer;
using CalcAppAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KrpanController : ControllerBase
    {
        private readonly ILogger<KrpanController> _logger;
        private readonly IKrpanQueryHandler _queryHandler;

        public KrpanController(ILogger<KrpanController> logger, IKrpanQueryHandler queryHandler)
        {
            _logger = logger;
            _queryHandler = queryHandler;
        }

        [HttpGet("trailers")]
        public async Task<ActionResult<IEnumerable<KrpanTrailerCardOverviewDto>>> GetAllTrailers(CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetTrailersAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("cranes")]
        public async Task<ActionResult<IEnumerable<KrpanCraneCardOverviewDto>>> GetAllCranes(CancellationToken cancellationToken)
        {
            var result = await _queryHandler.GetCranesAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("trailers/{id}")]
        public async Task<ActionResult<KrpanTrailerDetailsDto>> GetTrailer(int id, CancellationToken cancellationToken)
        {
            _logger.LogDebug("Querying trailer started for {Id}", id);
            var result = await _queryHandler.GetTrailerAsync(id, cancellationToken);
            return Ok(result);
        }

        [HttpGet("cranes/{id}")]
        public async Task<ActionResult<KrpanCraneDetailsDto>> GetCrane(int id, CancellationToken cancellationToken)
        {
            _logger.LogDebug("Querying crane started for {Id}", id);
            var result = await _queryHandler.GetCraneAsync(id, cancellationToken);
            return Ok(result);
        }
    }
}
