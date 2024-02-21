using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PalmsCraneConfigController : ControllerBase
    {
        private readonly ILogger<PalmsCraneConfigController> _logger;
        private readonly DataContext _dbContext;

        public PalmsCraneConfigController(ILogger<PalmsCraneConfigController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("cranes/{id}/frametypes")]
        public async Task<ActionResult<IEnumerable<FrameType>>> GetFrameTypes(int id)
        {
            var frameTypes = await _dbContext.FrameType
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(frameTypes);
        }

        [HttpGet("{trailerId}/cranes/{craneId}/availableFrameTypes")]
        public ActionResult<IEnumerable<FrameType>> GetAvailableFrameTypes(int trailerId, int craneId)
        {
            var trailer = _dbContext.Trailer
                .Include(t => t.CraneConfigurations)
                    .ThenInclude(tc => tc.Crane)
                .FirstOrDefault(t => t.Id == trailerId);

            if (trailer == null)
            {
                return NotFound();
            }

            var craneConfigurations = trailer.CraneConfigurations.Where(tc => tc.CraneId == craneId).Select(tc => tc.Crane).ToList();

            var frameTypes = craneConfigurations.SelectMany(crane =>
                _dbContext.TrailerCraneConfigurations
                    .Where(tc => tc.CraneId == crane.Id && tc.TrailerId == trailerId)
                    .Select(tc => tc.SelectedFrameType)
            ).Distinct().ToList();

            return Ok(frameTypes);
        }
    }
}
