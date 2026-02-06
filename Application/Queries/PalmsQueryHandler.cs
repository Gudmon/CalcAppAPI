using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Data;
using CalcAppAPI.Domain.Entities.Errors;
using CalcAppAPI.Domain.Entities.Exceptions;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Application.Queries
{
    public class PalmsQueryHandler : IPalmsQueryHandler
    {
        private readonly DataContext _context;

        public PalmsQueryHandler(DataContext context)
        {
            _context = context;


        }

        public async Task<IEnumerable<PalmsTrailerCardOverviewDto>> GetTrailersAsync()
        {
            var desiredOrder = new List<string> {
                "PALMS 2D", "PALMS 6S", "PALMS 8SX", "PALMS 8D",
                "PALMS 9SC", "PALMS 10D", "PALMS 12D",
                "PALMS 14D", "PALMS 10UX", "PALMS 11UX", "PALMS 12U",
                "PALMS 12UAWD", "PALMS 15U", "PALMS 15UAWD",
                "PALMS MWD 3.2", "PALMS HMWD 3.2"
            };

            try
            {
                var allTrailers = await _context.Trailer
                    .AsNoTracking()
                    .ToListAsync();

                var orderedTrailers = allTrailers
                    .OrderBy(t =>
                    {
                        var index = desiredOrder.IndexOf(t.Name);
                        return index == -1 ? int.MaxValue : index;
                    })
                    .Select(t => new PalmsTrailerCardOverviewDto
                    {
                        Id = t.Id,
                        Name = t.Name,
                        GrossWeight = t.GrossWeight,
                        Frame = t.Frame,
                        LoadingAreaCross = t.LoadingAreaCross,
                        MaxCraneSize = t.MaxCraneSize,
                        DrawbarControlCylinders = t.DrawbarControlCylinders,
                        BeamType = t.BeamType
                    })
                    .ToList();

                return orderedTrailers;
            }
            catch (DbUpdateException)
            {
                throw Errors.Infrastructure.DatabaseUnavailable;
            }
            catch (Exception ex) when (ex is not AppException)
            {
                throw new InfrastructureException(
                    "UNEXPECTED_ERROR",
                    "Unexpected error.");
            }
        }

        public async Task<PalmsTrailerDetailsDto> GetTrailerAsync(int id)
        {
            try
            {
                var trailer = await _context.Trailer
                    .AsNoTracking()
                    .Include(t => t.Crane)
                    .FirstOrDefaultAsync(t => t.Id == id);

                if (trailer == null)
                    throw Errors.Trailer.NotFound(id);

                return new PalmsTrailerDetailsDto
                {
                    Id = trailer.Id,
                    Name = trailer.Name,
                    Description = trailer.Description,
                    Price = trailer.Price,
                    BeamType = trailer.BeamType,
                    LoadingAreaCross = trailer.LoadingAreaCross,
                    LoadingAreaLength = trailer.LoadingAreaLength,
                    Frame = trailer.Frame,
                    FrameExtensionLength = trailer.FrameExtensionLength,
                    GrossWeight = trailer.GrossWeight,
                    CurbWeight = trailer.CurbWeight,
                    TotalLength = trailer.TotalLength,
                    WidthWithStandardWheels = trailer.WidthWithStandardWheels,
                    StandardWheelSize = trailer.StandardWheelSize,
                    MaxCraneSize = trailer.MaxCraneSize,
                    DrawbarControlCylinders = trailer.DrawbarControlCylinders,

                    Cranes = trailer.Crane.Select(c => new PalmsCraneCardOverviewDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        MaxReach = c.MaxReach,
                        BrutLiftingTorque215Bar = c.BrutLiftingTorque215Bar,
                        BrutLiftingTorque190Bar = c.BrutLiftingTorque190Bar,
                        TelescopeLength = c.TelescopeLength,
                        SlewingCylinder = c.SlewingCylinder,
                        SlewingTorque = c.SlewingTorque
                    }),
                };
            }
            catch (DbUpdateException)
            {
                throw Errors.Infrastructure.DatabaseUnavailable;
            }
            catch (Exception ex) when (ex is not AppException)
            {
                throw new InfrastructureException(
                    "UNEXPECTED_ERROR",
                    "Unexpected error.");
            }
        }

        public async Task<IEnumerable<PalmsCraneCardOverviewDto>> GetCranesAsync()
        {
            var desiredOrder = new List<string> {
                "PALMS 1.42", "PALMS 2.42", "PALMS 2.54", "PALMS 3.63",
                "PALMS 3.67", "PALMS 4.71", "PALMS 5.75", "PALMS 5.85", "PALMS 5.87Z",
                "PALMS 7.78", "PALMS 7.87", "PALMS 7.94", "PALMS X100"
            };

            try
            {
                var allCranes = await _context.Crane
                    .AsNoTracking()
                    .ToListAsync();

                var orderedCranes = allCranes
                    .OrderBy(t =>
                    {
                        var index = desiredOrder.IndexOf(t.Name);
                        return index == -1 ? int.MaxValue : index;
                    })
                    .Select(t => new PalmsCraneCardOverviewDto
                    {
                        Id = t.Id,
                        Name = t.Name,
                        MaxReach = t.MaxReach,
                        BrutLiftingTorque190Bar = t.BrutLiftingTorque190Bar,
                        BrutLiftingTorque215Bar = t.BrutLiftingTorque215Bar,
                        TelescopeLength = t.TelescopeLength,
                        SlewingCylinder = t.SlewingCylinder,
                        SlewingTorque = t.SlewingTorque
                    })
                    .ToList();

                return orderedCranes;
            }
            catch (DbUpdateException)
            {
                throw Errors.Infrastructure.DatabaseUnavailable;
            }
            catch (Exception ex) when (ex is not AppException)
            {
                throw new InfrastructureException(
                    "UNEXPECTED_ERROR",
                    "Unexpected error.");
            }
        }

        public async Task<PalmsCraneDetailsDto> GetCraneAsync(int id)
        {
            try
            {
                var crane = await _context.Crane
                    .AsNoTracking()
                    .Include(t => t.Trailer)
                    .FirstOrDefaultAsync(t => t.Id == id);

                if (crane == null)
                    throw Errors.Crane.NotFound(id);

                return new PalmsCraneDetailsDto
                {
                    Id = crane.Id,
                    Name = crane.Name,
                    Description = crane.Description,
                    Price = crane.Price,
                    Series = crane.Series,
                    MaxReach = crane.MaxReach,
                    LiftAtFullReach240Bar = crane.LiftAtFullReach240Bar,
                    LiftAtFullReach215Bar = crane.LiftAtFullReach215Bar,
                    LiftAtFullReach190Bar = crane.LiftAtFullReach190Bar,
                    LiftAtFourMeters240Bar = crane.LiftAtFourMeters240Bar,
                    LiftAtFourMeters215Bar = crane.LiftAtFourMeters215Bar,
                    LiftAtFourMeters190Bar = crane.LiftAtFourMeters190Bar,
                    BrutLiftingTorque240Bar = crane.BrutLiftingTorque240Bar,
                    BrutLiftingTorque215Bar = crane.BrutLiftingTorque215Bar,
                    BrutLiftingTorque190Bar = crane.BrutLiftingTorque190Bar,
                    TelescopeLength = crane.TelescopeLength,
                    SlewingCylinder = crane.SlewingCylinder,
                    SlewingTorque = crane.SlewingTorque,
                    WorkingPressure = crane.WorkingPressure,
                    RotatorMaximumLoad = crane.RotatorMaximumLoad,
                    RotatorCapacity = crane.RotatorCapacity,
                    RotatorType = crane.RotatorType,
                    RotatorConnection = crane.RotatorConnection,
                    CraneWeight = crane.CraneWeight,
                    PillarSlewingAngle = crane.PillarSlewingAngle,
                    RecommendedOilFlow = crane.RecommendedOilFlow,
                    Trailers = crane.Trailer.Select(c => new PalmsTrailerCardOverviewDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        GrossWeight = c.GrossWeight,
                        Frame = c.Frame,
                        LoadingAreaCross = c.LoadingAreaCross,
                        MaxCraneSize = c.MaxCraneSize,
                        DrawbarControlCylinders = c.DrawbarControlCylinders,
                        BeamType = c.BeamType
                    }),
                    
                };
            }
            catch (DbUpdateException)
            {
                throw Errors.Infrastructure.DatabaseUnavailable;
            }
            catch (Exception ex) when (ex is not AppException)
            {
                throw new InfrastructureException(
                    "UNEXPECTED_ERROR",
                    "Unexpected error.");
            }
        }
    }
}
