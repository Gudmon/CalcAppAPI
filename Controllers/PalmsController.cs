using CalcAppAPI.Data;
using CalcAppAPI.Models;
using CalcAppAPI.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalmsController : ControllerBase
    {
        private readonly ILogger<PalmsController> _logger;
        private readonly DataContext _dbContext;

        public PalmsController(ILogger<PalmsController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("trailers")]
        public async Task<ActionResult<IEnumerable<PalmsTrailerOverview>>> GetAllTrailers()
        {
            var trailers = await _dbContext.Trailer
                .Select(t => new PalmsTrailerOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    GrossWeight = t.GrossWeight,
                    Frame = t.Frame,
                    LoadingAreaCross = t.LoadingAreaCross,
                    MaxCraneSize = t.MaxCraneSize,
                    DrawbarControlCylinders = t.DrawbarControlCylinders,
                    BeamType = t.BeamType
                }).ToListAsync();

            return Ok(trailers);
        }

        [HttpGet("cranes")]
        public async Task<ActionResult<IEnumerable<PalmsCraneOverview>>> GetAllCranes()
        {
            var cranes = await _dbContext.Crane
                .Select(t => new PalmsCraneOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    MaxReach = t.MaxReach,
                    BrutLiftingTorque190Bar = t.BrutLiftingTorque190Bar,
                    BrutLiftingTorque215Bar = t.BrutLiftingTorque215Bar,
                    TelescopeLength = t.TelescopeLength,
                    SlewingCylinder = t.SlewingCylinder,
                    SlewingTorque = t.SlewingTorque
                }).ToListAsync();

            return Ok(cranes);
        }

        [HttpGet("trailers/{id}")]
        public async Task<ActionResult<Trailer>> GetTrailer(int id)
        {
            _logger.LogDebug("Querying trailer started for {}", id);
            var trailer = await _dbContext.Trailer
                .Include(trailer => trailer.Crane)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (trailer == null)
            {
                _logger.LogError("trailer not found with {}", id);
                return NotFound();
            }

            _logger.LogDebug("Querying trailer finished for {}", id);
            return Ok(trailer);
        }

        [HttpGet("cranes/{id}")]
        public async Task<ActionResult<Crane>> GetCrane(int id)
        {
            _logger.LogDebug("Querying crane started for {}", id);
            var crane = await _dbContext.Crane
                .Include(crane => crane.Trailer)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (crane == null)
            {
                _logger.LogError("crane not found with {}", id);
                return NotFound();
            }

            _logger.LogDebug("Querying crane finished for {}", id);
            return Ok(crane);
        }
    }
}
