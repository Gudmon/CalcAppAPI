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
        public async Task<ActionResult<IEnumerable<Stanchion>>> GetStanchions()
        {
            var trailers = await _dbContext.Stanchion.ToListAsync();

            return Ok(trailers);
        }
    }
}
