﻿using CalcAppAPI.Data;
using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
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
        private readonly ILogger<PalmsTrailerConfigController> _logger;
        private readonly DataContext _dbContext;

        public PalmsTrailerConfigController(ILogger<PalmsTrailerConfigController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
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
                .Include(s => s.OilTankCooler)
                .Select(s => new OilTank
                {
                    Id = s.Id,
                    Name = s.Name,
                    Code = s.Code,
                    Price = s.Price,
                    OilTankCooler = s.OilTankCooler
                })
                .ToListAsync();

            return Ok(oilTanks);
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
            var bBOx = await _dbContext.BBox
                .FirstOrDefaultAsync(b => b.Trailer.Any(t => t.Id == id));

            return Ok(bBOx);
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
        public async Task<ActionResult<IEnumerable<Light>>> GetLights(int id)
        {
            var lights = await _dbContext.Light
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
    }
}
