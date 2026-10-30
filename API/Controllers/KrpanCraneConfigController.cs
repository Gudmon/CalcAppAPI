using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KrpanCraneConfigController : ControllerBase
    {
        private readonly ILogger<KrpanCraneConfigController> _logger;
        private readonly DataContext _dbContext;
        public KrpanCraneConfigController(ILogger<KrpanCraneConfigController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("cranes/{id}/slewingdrive")]
        public async Task<ActionResult<KrpanCraneSlewingDrive>> GetSlewingDrive(int id)
        {
            var slewingDrive = await _dbContext.KrpanCraneSlewingDrive
                .Include(s => s.KrpanCranes)
                .Where(s => s.KrpanCranes.Any(t => t.Id == id))
                .FirstOrDefaultAsync();

            return Ok(slewingDrive);
        }

        [HttpGet("cranes/{id}/cranecontrols")]
        public async Task<ActionResult<IEnumerable<KrpanCraneControl>>> GetKrpanCraneControls(int id)
        {
            var craneControls = await _dbContext.KrpanCraneControl
                .Where(b => b.KrpanCrane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(craneControls);
        }

        [HttpGet("cranes/{id}/controllevelprotection")]
        public async Task<ActionResult<KrpanCraneControlLeverProtection>> GetControlLevelProection(int id)
        {
            var controllevelprotection = await _dbContext.KrpanCraneControlLeverProtection
                .Include(c => c.KrpanCranes)
                .Where(c => c.KrpanCranes.Any(t => t.Id == id))
                .FirstOrDefaultAsync();

            return Ok(controllevelprotection);
        }

        [HttpGet("cranes/{id}/tractorhydraulics")]
        public async Task<ActionResult<KrpanCraneTractorHydraulics>> GetTractorHydraulics(int id)
        {
            var tractorHydraulics = await _dbContext.KrpanCraneTractorHydraulics
                .Include(t => t.KrpanCranes)
                .Where(t => t.KrpanCranes.Any(v => v.Id == id))
                .FirstOrDefaultAsync();

            return Ok(tractorHydraulics);
        }

        [HttpGet("cranes/{id}/rotators")]
        public async Task<ActionResult<IEnumerable<KrpanCraneRotator>>> GetKrpanCraneRotators(int id)
        {
            var craneRotators = await _dbContext.KrpanCraneRotator
                .Where(r => r.KrpanCranes.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(craneRotators);
        }
    }
}
