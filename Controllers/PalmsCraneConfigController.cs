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

        [HttpGet("cranes/{id}/controlblocks")]
        public async Task<ActionResult<IEnumerable<ControlBlock>>> GetControlBlocks(int id)
        {
            var controlBlocks = await _dbContext.ControlBlocks
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(controlBlocks);
        }

        [HttpGet("cranes/{id}/frametypes")]
        public async Task<ActionResult<IEnumerable<FrameType>>> GetFrameTypes(int id)
        {
            var frameTypes = await _dbContext.FrameType
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(frameTypes);
        }

        //[HttpGet("cranes/{trailerId}/{craneId}/availableFrameTypes")]
        //public ActionResult<IEnumerable<FrameType>> GetAvailableFrameTypes(int trailerId, int craneId)
        //{
        //    var trailer = _dbContext.Trailer
        //        .Include(t => t.CraneConfigurations)
        //            .ThenInclude(tc => tc.Crane)
        //        .FirstOrDefault(t => t.Id == trailerId);

        //    if (trailer == null)
        //    {
        //        return NotFound();
        //    }

        //    var craneConfigurations = trailer.CraneConfigurations.Where(tc => tc.CraneId == craneId).Select(tc => tc.Crane).ToList();

        //    var frameTypes = craneConfigurations.SelectMany(crane =>
        //        _dbContext.TrailerCraneConfigurations
        //            .Where(tc => tc.CraneId == crane.Id && tc.TrailerId == trailerId)
        //            .Select(tc => tc.SelectedFrameType)
        //    ).Distinct().ToList();

        //    return Ok(frameTypes);
        //}

        //[HttpGet("cranes/{craneId}/{frameTypeId}/controlblocks")]
        //public IActionResult GetAvailableControlBlocks(int craneId, int frameTypeId)
        //{
        //    var availableControlBlocks = _dbContext.CraneControlBlocks
        //        .Where(ccb => ccb.CraneId == craneId && ccb.FrameTypeId == frameTypeId)
        //        .Select(ccb => ccb.ControlBlock)
        //        .ToList();

        //    return Ok(availableControlBlocks);
        //}

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

        [HttpGet("cranes/{id}/winches")]
        public async Task<ActionResult<IEnumerable<Winch>>> GetWinches(int id)
        {
            var winches = await _dbContext.Winch
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(winches);
        }

        [HttpGet("cranes/{id}/protectionsleeves")]
        public async Task<ActionResult<ProtectionSleeves>> GetProtectionSleeves(int id)
        {
            var protectionSleeves = await _dbContext.ProtectionSleeves
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(protectionSleeves);
        }

        [HttpGet("cranes/{id}/electricalfloating")]
        public async Task<ActionResult<ElectricalFloating>> GetElectricalFloating(int id)
        {
            var electricalFloating = await _dbContext.ElectricalFloating
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(electricalFloating);
        }

        [HttpGet("cranes/{id}/valveblock")]
        public async Task<ActionResult<ValveBlock>> GetValveBlock(int id)
        {
            var valveBlock = await _dbContext.ValveBlock
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(valveBlock);
        }

        [HttpGet("cranes/{id}/dampings")]
        public async Task<ActionResult<IEnumerable<Damping>>> GetDampings(int id)
        {
            var dampings = await _dbContext.Damping
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(dampings);
        }

        [HttpGet("cranes/{id}/light")]
        public async Task<ActionResult<CraneLight>> GetLight(int id)
        {
            var lights = await _dbContext.CraneLight
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(lights);
        }

        [HttpGet("cranes/{id}/operatorseat")]
        public async Task<ActionResult<OperatorSeat>> GetOperatorSeat(int id)
        {
            var operatorSeats = await _dbContext.OperatorSeat
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(operatorSeats);
        }

        [HttpGet("cranes/{id}/oilcooler")]
        public async Task<ActionResult<CraneOilCooler>> GetOilCooler(int id)
        {
            var oilCooler = await _dbContext.CraneOilCooler
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(oilCooler);
        }

        [HttpGet("cranes/{id}/rotatorbrakes")]
        public async Task<ActionResult<IEnumerable<RotatorBrake>>> GetRotatorBrakes(int id)
        {
            var rotatorBrakes = await _dbContext.RotatorBrake
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(rotatorBrakes);
        }

        [HttpGet("cranes/{id}/joystickholder")]
        public async Task<ActionResult<JoystickHolder>> GetJoystickHolder(int id)
        {
            var joystickHolder = await _dbContext.JoystickHolder
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(joystickHolder);
        }

        [HttpGet("cranes/{id}/hoseguards")]
        public async Task<ActionResult<IEnumerable<HoseGuard>>> GetHoseGuards(int id)
        {
            var hoseGuards = await _dbContext.HoseGuard
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(hoseGuards);
        }

        [HttpGet("cranes/{id}/turningdevicecounterplate")]
        public async Task<ActionResult<TurningDeviceCounterPlate>> GetTurningDeviceCounterPlate(int id)
        {
            var turningDeviceCounterPlate = await _dbContext.TurningDeviceCounterPlate
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(turningDeviceCounterPlate);
        }

        [HttpGet("cranes/{id}/supportlegcounterplate")]
        public async Task<ActionResult<SupportLegCounterPlate>> GetSupportLegCounterPlate(int id)
        {
            var supportLegCounterPlate = await _dbContext.SupportLegCounterPlate
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(supportLegCounterPlate);
        }

        [HttpGet("cranes/{id}/boomguards")]
        public async Task<ActionResult<IEnumerable<BoomGuard>>> GetBoomGuards(int id)
        {
            var boomGuards = await _dbContext.BoomGuard
                .Where(s => s.Crane.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(boomGuards);
        }

        [HttpGet("cranes/{id}/cover")]
        public async Task<ActionResult<Cover>> GetCover(int id)
        {
            var cover = await _dbContext.Cover
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(cover);
        }

        [HttpGet("cranes/{id}/woodcontrol")]
        public async Task<ActionResult<WoodControl>> GetWoodControl(int id)
        {
            var woodControl = await _dbContext.WoodControl
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(woodControl);
        }

        [HttpGet("cranes/{id}/linkage")]
        public async Task<ActionResult<Linkage>> GetLinkage(int id)
        {
            var linkage = await _dbContext.Linkage
                .FirstOrDefaultAsync(b => b.Crane.Any(t => t.Id == id));

            return Ok(linkage);
        }
    }
}
