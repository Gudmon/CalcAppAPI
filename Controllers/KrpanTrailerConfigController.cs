using CalcAppAPI.Data;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
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

        [HttpGet("trailers/{id}/hydraulicadjustablechassis")]
        public async Task<ActionResult<KrpanHydraulicAdjustableChassis>> GetKrpanHydraulicAdjustableChassis(int id)
        {
            var krpanHydraulicAdjustableChassis = await _dbContext.KrpanHydraulicAdjustableChassis
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanHydraulicAdjustableChassis);
        }

        [HttpGet("trailers/{id}/lamp")]
        public async Task<ActionResult<KrpanTrailerLamp>> GetKrpanTrailerLamp(int id)
        {
            var krpanHydraulicAdjustableChassis = await _dbContext.KrpanTrailerLamp
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanHydraulicAdjustableChassis);
        }

        [HttpGet("trailers/{id}/chock")]
        public async Task<ActionResult<KrpanChock>> GetKrpanChock(int id)
        {
            var chock = await _dbContext.KrpanChock
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(chock);
        }

        [HttpGet("trailers/{id}/drawbarsteering")]
        public async Task<ActionResult<KrpanDrawbarSteering>> GetKrpanDrawbarSteering(int id)
        {
            var drawbarSteering = await _dbContext.KrpanDrawbarSteering
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(drawbarSteering);
        }

        [HttpGet("trailers/{id}/supportleg")]
        public async Task<ActionResult<KrpanTrailerSupportLeg>> GetKrpanTrailerSupportLeg(int id)
        {
            var trailerSupportLeg = await _dbContext.KrpanTrailerSupportLeg
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(trailerSupportLeg);
        }

        [HttpGet("trailers/{id}/propulsions")]
        public async Task<ActionResult<IEnumerable<KrpanPropulsion>>> GetKrpanPropulsions(int id)
        {
            var krpanPropulsions = await _dbContext.KrpanPropulsion
                .Where(s => s.KrpanTrailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(krpanPropulsions);
        }

        [HttpGet("trailers/{id}/adjustabledrive")]
        public async Task<ActionResult<KrpanAdjustableDrive>> GetKrpanAdjustableDrive(int id)
        {
            var krpanAdjustableDrive = await _dbContext.KrpanAdjustableDrive
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanAdjustableDrive);
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

        [HttpGet("trailers/{id}/handbrake")]
        public async Task<ActionResult<KrpanHandBrake>> GetKrpanHandBrake(int id)
        {
            var krpanHandBrake = await _dbContext.KrpanHandBrake
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanHandBrake);
        }

        [HttpGet("trailers/{id}/extrastanchion")]
        public async Task<ActionResult<KrpanExtraStanchion>> GetKrpanExtraStanchion(int id)
        {
            var krpanExtraStanchion = await _dbContext.KrpanExtraStanchion
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanExtraStanchion);
        }

        [HttpGet("trailers/{id}/extraforwarderstanchion")]
        public async Task<ActionResult<KrpanExtraForwarderStanchion>> GetKrpanExtraForwarderStanchion(int id)
        {
            var krpanExtraForwarderStanchion = await _dbContext.KrpanExtraForwarderStanchion
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanExtraForwarderStanchion);
        }

        [HttpGet("trailers/{id}/topconnection")]
        public async Task<ActionResult<KrpanTopConnection>> GetKrpanTopconnection(int id)
        {
            var krpanTopConnection = await _dbContext.KrpanTopConnection
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanTopConnection);
        }

        [HttpGet("trailers/{id}/clutches")]
        public async Task<ActionResult<IEnumerable<KrpanClutch>>> GetKrpanClutches(int id)
        {
            var krpanClutch = await _dbContext.KrpanClutch
                .Where(s => s.KrpanTrailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(krpanClutch);
        }

        [HttpGet("trailers/{id}/drawhead")]
        public async Task<ActionResult<KrpanDrawhead>> GetKrpanDrawhead(int id)
        {
            var krpanDrawHead = await _dbContext.KrpanDrawHead
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanDrawHead);
        }

        [HttpGet("trailers/{id}/drawbars")]
        public async Task<ActionResult<IEnumerable<KrpanDrawbar>>> GetKrpanDrawbars(int id)
        {
            var krpanDrawbar = await _dbContext.KrpanDrawbar
                .Where(s => s.KrpanTrailer.Any(t => t.Id == id))
                .ToListAsync();

            return Ok(krpanDrawbar);
        }

        [HttpGet("trailers/{id}/cardanshaft")]
        public async Task<ActionResult<KrpanCardanShaft>> GetKrpanCardanShaft(int id)
        {
            var krpanCardanShaft = await _dbContext.KrpanCardanShaft
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanCardanShaft);
        }

        [HttpGet("trailers/{id}/bbox")]
        public async Task<ActionResult<KrpanBBox>> GetKrpanBBox(int id)
        {
            var krpanBBox = await _dbContext.KrpanBBox
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanBBox);
        }

        [HttpGet("trailers/{id}/baletransportplatform")]
        public async Task<ActionResult<KrpanBaleTransportPlatform>> GetKrpanBaleTransportPlatform(int id)
        {
            var krpanBaleTransportPlatform = await _dbContext.KrpanBaleTransportPlatform
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanBaleTransportPlatform);
        }

        [HttpGet("trailers/{id}/cargospaceextension")]
        public async Task<ActionResult<KrpanCargoSpaceExtension>> GetKrpanCargoSpaceExtension(int id)
        {
            var krpanCargoSpaceExtension = await _dbContext.KrpanCargoSpaceExtension
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanCargoSpaceExtension);
        }

        [HttpGet("trailers/{id}/axeholder")]
        public async Task<ActionResult<KrpanAxeHolder>> GetKrpanAxeHolder(int id)
        {
            var krpanAxeHolder = await _dbContext.KrpanAxeHolder
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanAxeHolder);
        }

        [HttpGet("trailers/{id}/chainsawholder")]
        public async Task<ActionResult<KrpanChainsawHolder>> GetKrpanChainsawHolder(int id)
        {
            var krpanChainsawHolder = await _dbContext.KrpanChainsawHolder
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanChainsawHolder);
        }

        [HttpGet("trailers/{id}/fueltankholder")]
        public async Task<ActionResult<KrpanFuelTankHolder>> GetKrpanFuelTankHolder(int id)
        {
            var krpanFuelTankHolder = await _dbContext.KrpanFuelTankHolder
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanFuelTankHolder);
        }

        [HttpGet("trailers/{id}/toolbox")]
        public async Task<ActionResult<KrpanToolBox>> GetKrpanToolBox(int id)
        {
            var krpanToolBox = await _dbContext.KrpanToolBox
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanToolBox);
        }

        [HttpGet("trailers/{id}/plato")]
        public async Task<ActionResult<KrpanPlato>> GetKrpanPlato(int id)
        {
            var krpanPlato = await _dbContext.KrpanPlato
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanPlato);
        }

        [HttpGet("trailers/{id}/extension")]
        public async Task<ActionResult<KrpanExtension>> GetKrpanExtension(int id)
        {
            var krpanExtension = await _dbContext.KrpanExtension
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanExtension);
        }

        [HttpGet("trailers/{id}/hydraulicsupportleg")]
        public async Task<ActionResult<KrpanHydraulicSupportLeg>> GetKrpanHydraulicSupportLeg(int id)
        {
            var krpanHydraulicSupportLeg = await _dbContext.KrpanHydraulicSupportLeg
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanHydraulicSupportLeg);
        }

        [HttpGet("trailers/{id}/grapplelocation")]
        public async Task<ActionResult<KrpanGrappleLocation>> GetKrpanGrappleLocation(int id)
        {
            var krpanGrappleLocation = await _dbContext.KrpanGrappleLocation
                .FirstOrDefaultAsync(b => b.KrpanTrailer.Any(t => t.Id == id));

            return Ok(krpanGrappleLocation);
        }
    }
}
