using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalmsTrailerConfigController : ControllerBase
    {
        private readonly ILogger<PalmsTrailerConfigController> _logger;
        private readonly DataContext _dbContext;
        private readonly IPalmsQueryHandler _queryHandler;

        public PalmsTrailerConfigController(ILogger<PalmsTrailerConfigController> logger, DataContext dbContext, IPalmsQueryHandler queryHandler)
        {
            _logger = logger;
            _dbContext = dbContext;
            _queryHandler = queryHandler;
        }

        [HttpGet("trailers/{id}/stanchions")]
        public async Task<ActionResult<IEnumerable<Stanchion>>> GetStanchions(int id)
        {
            var stanchions = await _dbContext.Stanchion
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(stanchions);
        }

        [HttpGet("trailers/{id}/brakes")]
        public async Task<ActionResult<IEnumerable<Brake>>> GetBrakes(int id)
        {
            var brakes = await _dbContext.Brake
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(brakes);
        }

        [HttpGet("trailers/{id}/propulsions")]
        public async Task<ActionResult<IEnumerable<Propulsion>>> GetPropulsions(int id)
        {
            var propulsions = await _dbContext.Propulsion
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(propulsions);
        }

        [HttpGet("trailers/{id}/drawbars")]
        public async Task<ActionResult<IEnumerable<Drawbar>>> GetDrawbars(int id)
        {
            var drawbars = await _dbContext.Drawbar
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(drawbars);
        }

        [HttpGet("trailers/{id}/platforms")]
        public async Task<ActionResult<IEnumerable<Platform>>> GetPlatforms(int id)
        {
            var platforms = await _dbContext.Platform
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(platforms);
        }

        [HttpGet("trailers/{id}/oilpumps")]
        public async Task<ActionResult<IEnumerable<OilPump>>> GetOilPumps(int id)
        {
            var oilPumps = await _dbContext.OilPump
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(oilPumps);
        }

        [HttpGet("trailers/{id}/oiltanks")]
        public async Task<ActionResult<IEnumerable<OilTank>>> GetOilTanks(int id)
        {
            var oilTanks = await _dbContext.OilTank
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(oilTanks);
        }

        [HttpGet("trailers/{id}/oilcooler")]
        public async Task<ActionResult<TrailerOilCooler>> GetTrailerOilCooler(int id)
        {
            var trailerOilCooler = await _dbContext.TrailerOilCooler
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(trailerOilCooler);

        }

        [HttpGet("trailers/{id}/bolsterlock")]
        public async Task<ActionResult<BolsterLock>> GetBolsterLock(int id)
        {
            var bolsterLock = await _dbContext.BolsterLock
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(bolsterLock);

        }

        [HttpGet("trailers/{id}/bbox")]
        public async Task<ActionResult<BBox>> GetBBox(int id)
        {
            var bBox = await _dbContext.BBox
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(bBox);
        }

        [HttpGet("trailers/{id}/dbox")]
        public async Task<ActionResult<DBox>> GetDBox(int id)
        {
            var dBox = await _dbContext.DBox
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(dBox);
        }

        [HttpGet("trailers/{id}/haybaleframe")]
        public async Task<ActionResult<HayBaleFrame>> GetHayBaleFrame(int id)
        {
            var hayBaleFrame = await _dbContext.HayBaleFrame
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(hayBaleFrame);
        }

        [HttpGet("trailers/{id}/woodsorter")]
        public async Task<ActionResult<WoodSorter>> GetWoodSorter(int id)
        {
            var woodSorter = await _dbContext.WoodSorter
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(woodSorter);
        }

        [HttpGet("trailers/{id}/handbrake")]
        public async Task<ActionResult<HandBrake>> GetHandBrake(int id)
        {
            var handBrake = await _dbContext.HandBrake
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(handBrake);
        }

        [HttpGet("trailers/{id}/chainsawholder")]
        public async Task<ActionResult<ChainsawHolder>> GetChainsawHolder(int id)
        {
            var chainsawHolder = await _dbContext.ChainsawHolder
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(chainsawHolder);
        }

        [HttpGet("trailers/{id}/underrunprotection")]
        public async Task<ActionResult<UnderrunProtection>> GetUnderrunProtection(int id)
        {
            var underrunProtection = await _dbContext.UnderrunProtection
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(underrunProtection);
        }

        [HttpGet("trailers/{id}/supportlegs")]
        public async Task<ActionResult<IEnumerable<SupportLeg>>> GetSupportLegs(int id)
        {
            var supportLegs = await _dbContext.SupportLeg
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(supportLegs);
        }

        [HttpGet("trailers/{id}/lights")]
        public async Task<ActionResult<IEnumerable<TrailerLight>>> GetLights(int id)
        {
            var lights = await _dbContext.TrailerLight
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(lights);
        }

        [HttpGet("trailers/{id}/tyres")]
        public async Task<ActionResult<IEnumerable<Tyre>>> GetTyres(int id)
        {
            var tyres = await _dbContext.Tyre
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(tyres);
        }

        [HttpGet("trailers/{id}/bunkadapter")]
        public async Task<ActionResult<BunkAdapter>> GetBunkAdapter(int id)
        {
            var bunkAdapter = await _dbContext.BunkAdapter
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(bunkAdapter);
        }

        [HttpGet("trailers/{id}/bunkextension")]
        public async Task<ActionResult<BunkExtension>> GetBunkExtension(int id)
        {
            var bunkExtension = await _dbContext.BunkExtension
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(bunkExtension);
        }

        [HttpGet("trailers/{id}/manualbunkextension")]
        public async Task<ActionResult<ManualBunkExtension>> GetManualBunkExtension(int id)
        {
            var manualBunkExtension = await _dbContext.ManualBunkExtension
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(manualBunkExtension);
        }

        [HttpGet("trailers/{id}/frameextension")]
        public async Task<ActionResult<FrameExtension>> GetFrameExtension(int id)
        {
            var frameExtension = await _dbContext.FrameExtension
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(frameExtension);
        }

        [HttpGet("trailers/{id}/shipping")]
        public async Task<ActionResult<Shipping>> GetShipping(int id)
        {
            var shipping = await _dbContext.Shipping
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(shipping);
        }


        [HttpGet("trailers/{id}/mot")]
        public async Task<ActionResult<Shipping>> GetMOT(int id)
        {
            var MOT = await _dbContext.MOT
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(MOT);
        }

        [HttpGet("trailers/{id}/stanchionextension")]
        public async Task<ActionResult<StanchionExtension>> GetStanchionExtension(int id)
        {
            var stanchionExtension = await _dbContext.StanchionExtension
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(stanchionExtension);
        }

        [HttpGet("trailers/{id}/hydropacks")]
        public async Task<ActionResult<IEnumerable<HydroPack>>> GetHydroPack(int id)
        {
            var hydroPacks = await _dbContext.HydroPack
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(hydroPacks);
        }

        [HttpGet("trailers/{id}/supplyformats")]
        public async Task<ActionResult<IEnumerable<SupplyFormat>>> GetSupplyFormats(int id)
        {
            var supplyFormats = await _dbContext.SupplyFormat
                .Where(s => s.Trailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(supplyFormats);
        }

        [HttpGet("trailers/{id}/toolbox")]
        public async Task<ActionResult<StanchionExtension>> GetToolbox(int id)
        {
            var toolbox = await _dbContext.Toolbox
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(toolbox);
        }
    }
}
