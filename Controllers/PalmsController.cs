using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Trailers;
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
        public async Task<ActionResult<IEnumerable<TrailerOverview>>> GetAllTrailers()
        {
            var desiredOrder = new List<string> {
                "PALMS 6S", "PALMS 8SX", "PALMS 8D", "PALMS 8DWD",
                "PALMS 9SC", "PALMS 10D", "PALMS 10DWD", "PALMS 12D", "PALMS 12DWD",
                "PALMS 14D", "PALMS 14DWD", "PALMS 10U", "PALMS 10UWD", "PALMS 12U",
                "PALMS 12UWD", "PALMS 12UAWD", "PALMS 15U", "PALMS 15UWD", "PALMS 15UAWD",
                "PALMS MWD 3.2", "PALMS HMWD 3.2"
            };

            var allTrailers = await _dbContext.Trailer.ToListAsync();

            var orderedTrailers = allTrailers
                .OrderBy(t => desiredOrder.IndexOf(t.Name))
                .Select(t => new TrailerOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    GrossWeight = t.GrossWeight,
                    Frame = t.Frame,
                    LoadingAreaCross = t.LoadingAreaCross,
                    MaxCraneSize = t.MaxCraneSize,
                    DrawbarControlCylinders = t.DrawbarControlCylinders,
                    BeamType = t.BeamType
                });

            return Ok(orderedTrailers);
        }

        [HttpGet("cranes")]
        public async Task<ActionResult<IEnumerable<CraneOverview>>> GetAllCranes()
        {
            var desiredOrder = new List<string> {
                "PALMS 1.42", "PALMS 2.42", "PALMS 2.54", "PALMS 3.63",
                "PALMS 3.67", "PALMS 4.71", "PALMS 5.72", "PALMS 5.85", "PALMS 5.87Z",
                "PALMS 7.75", "PALMS 7.86", "PALMS 7.94", "PALMS X100"
            };

            var allCranes = await _dbContext.Crane.ToListAsync();

            var orderedCranes = allCranes
                .OrderBy(t => desiredOrder.IndexOf(t.Name))
                .Select(t => new CraneOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    MaxReach = t.MaxReach,
                    BrutLiftingTorque190Bar = t.BrutLiftingTorque190Bar,
                    BrutLiftingTorque215Bar = t.BrutLiftingTorque215Bar,
                    TelescopeLength = t.TelescopeLength,
                    SlewingCylinder = t.SlewingCylinder,
                    SlewingTorque = t.SlewingTorque
                });

            return Ok(orderedCranes);
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
