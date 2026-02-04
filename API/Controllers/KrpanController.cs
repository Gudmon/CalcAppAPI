using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Krpan.Cranes;
using CalcAppAPI.Models.Machine.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using CalcAppAPI.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KrpanController : ControllerBase
    {
        private readonly ILogger<KrpanController> _logger;
        private readonly DataContext _dbContext;

        public KrpanController(ILogger<KrpanController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("trailers")]
        public async Task<ActionResult<IEnumerable<KrpanTrailerOverview>>> GetAllTrailers()
        {
            var desiredOrder = new List<string> {
                "PALMS 6S", "PALMS 8SX", "PALMS 8D", "PALMS 8DWD",
                "PALMS 9SC", "PALMS 10D", "PALMS 10DWD", "PALMS 12D", "PALMS 12DWD",
                "PALMS 14D", "PALMS 14DWD", "PALMS 10U", "PALMS 10UWD", "PALMS 12U",
                "PALMS 12UWD", "PALMS 12UAWD", "PALMS 15U", "PALMS 15UWD", "PALMS 15UAWD",
                "PALMS MWD 3.2", "PALMS HMWD 3.2"
            };

            var allTrailers = await _dbContext.KrpanTrailer.ToListAsync();

            var orderedTrailers = allTrailers
                //.OrderBy(t => desiredOrder.IndexOf(t.Name))
                .Select(t => new KrpanTrailerOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    LoadCapacity = t.LoadCapacity,
                    LoadingLength = t.LoadingLength,
                    LoadingLengthWithExtension = t.LoadingLengthWithExtension,
                    Weight = t.Weight
                });

            return Ok(orderedTrailers);
        }

        [HttpGet("cranes")]
        public async Task<ActionResult<IEnumerable<KrpanCraneOverview>>> GetAllCranes()
        {
            var desiredOrder = new List<string> {
                "PALMS 1.42", "PALMS 2.42", "PALMS 2.54", "PALMS 3.63",
                "PALMS 3.67", "PALMS 4.71", "PALMS 5.72", "PALMS 5.85", "PALMS 5.87Z",
                "PALMS 7.75", "PALMS 7.86", "PALMS 7.94", "PALMS X100"
            };

            var allCranes = await _dbContext.KrpanCrane.ToListAsync();

            var orderedCranes = allCranes
                //.OrderBy(t => desiredOrder.IndexOf(t.Name))
                .Select(t => new KrpanCraneOverview
                {
                    Id = t.Id,
                    Name = t.Name,
                    MaxReach = t.MaxReach,
                    MaxReachWithGrabOpen = t.MaxReachWithGrabOpen,
                    NetLiftingTorque = t.NetLiftingTorque,
                    LiftCapacityAtFourMeters = t.LiftCapacityAtFourMeters,
                });

            return Ok(orderedCranes);
        }

        [HttpGet("trailers/{id}")]
        public async Task<ActionResult<KrpanTrailer>> GetTrailer(int id)
        {
            _logger.LogDebug("Querying trailer started for {}", id);
            var trailer = await _dbContext.KrpanTrailer
                .Include(trailer => trailer.KrpanCrane)
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
        public async Task<ActionResult<KrpanCrane>> GetCrane(int id)
        {
            _logger.LogDebug("Querying crane started for {}", id);
            var crane = await _dbContext.KrpanCrane
                .Include(crane => crane.KrpanTrailer)
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
