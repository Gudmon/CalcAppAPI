using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
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

        [HttpGet("cranes/{trailerId}/{craneId}/availableFrameTypes")]
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

        [HttpGet("cranes/{craneId}/{frameTypeId}/controlblocks")]
        public IActionResult GetAvailableControlBlocks(int craneId, int frameTypeId)
        {
            var availableControlBlocks = _dbContext.CraneControlBlocks
                .Where(ccb => ccb.CraneId == craneId && ccb.FrameTypeId == frameTypeId)
                .Select(ccb => ccb.ControlBlock)
                .ToList();

            return Ok(availableControlBlocks);
        }

        //[HttpGet("cranes/{craneId}/{controlBlockId}/frametypes")]
        //public ActionResult<IEnumerable<FrameType>> GetFrameTypes(int craneId, int controlBlockId)
        //{
        //    var availableFrameTypes = _dbContext.FrameType
        //        .Join(
        //            _dbContext.CraneControlBlocks,
        //            ft => ft.Id,
        //            ccb => ccb.FrameTypeId,
        //            (ft, ccb) => new { FrameType = ft, CraneControlBlock = ccb })
        //        .Join(
        //            _dbContext.ControlBlocks,
        //            x => x.CraneControlBlock.ControlBlockId,
        //            cb => cb.Id,
        //            (x, cb) => new { x.FrameType, x.CraneControlBlock, ControlBlock = cb })
        //        .Where(x => x.CraneControlBlock.CraneId == craneId && x.CraneControlBlock.ControlBlockId == controlBlockId)
        //        .Select(x => x.FrameType)
        //        .OrderBy(ft => ft.Id)
        //        .ToList();

        //    if (availableFrameTypes == null || !availableFrameTypes.Any())
        //    {
        //        return NotFound();
        //    }

        //    return Ok(availableFrameTypes);
        //}

        [HttpGet("cranes/{id}/rotators")]
        public async Task<ActionResult<IEnumerable<Rotator>>> GetRotators(int id)
        {
            var rotators = await _dbContext.Rotator
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(rotators);
        }

        [HttpGet("cranes/{id}/grapples")]
        public async Task<ActionResult<IEnumerable<Grapple>>> GetGrapples(int id)
        {
            var grapples = await _dbContext.Grapple
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(grapples);
        }
    }
}
