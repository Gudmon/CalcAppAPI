using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using CalcAppAPI.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalmsTrailerConfigController : ControllerBase
    {
        private readonly ILogger<PalmsController> _logger;
        private readonly DataContext _dbContext;

        public PalmsTrailerConfigController(ILogger<PalmsController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("trailers/{id}/stanchions")]
        public async Task<ActionResult<IEnumerable<Stanchion>>> GetStanchions(int id)
        {
            var stanchions = await _dbContext.Stanchion
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(stanchions);
        }

        [HttpGet("trailers/{id}/brakes")]
        public async Task<ActionResult<IEnumerable<Brake>>> GetBrakes(int id)
        {
            var brakes = await _dbContext.Brake
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(brakes);
        }

        [HttpGet("trailers/{id}/propulsions")]
        public async Task<ActionResult<IEnumerable<Propulsion>>> GetPropulsions(int id)
        {
            var propulsions = await _dbContext.Propulsion
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(propulsions);
        }

        [HttpGet("trailers/{id}/drawbars")]
        public async Task<ActionResult<IEnumerable<Drawbar>>> GetDrawbars(int id)
        {
            var drawbars = await _dbContext.Drawbar
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(drawbars);
        }
    }
}
