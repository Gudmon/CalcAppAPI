using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KrpanTrailerConfigController : ControllerBase
    {
        private readonly ILogger<KrpanTrailerConfigController> _logger;
        private readonly DataContext _dbContext;

        public KrpanTrailerConfigController(ILogger<KrpanTrailerConfigController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("trailers/{id}/tyres")]
        public async Task<ActionResult<IEnumerable<KrpanTyre>>> GetKrpanTyres(int id)
        {
            var krpanTyres = await _dbContext.KrpanTyre
                .Where(s => s.KrpanTrailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(krpanTyres);
        }

        [HttpGet("trailers/{id}/brakes")]
        public async Task<ActionResult<IEnumerable<KrpanTyre>>> GetKrpanBrakes(int id)
        {
            var krpanBrakes = await _dbContext.KrpanBrake
                .Where(s => s.KrpanTrailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(krpanBrakes);
        }
    }
}
