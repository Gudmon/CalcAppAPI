using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
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
    }
}
