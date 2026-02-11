using CalcAppAPI.Application.Dtos.Palms;
using CalcAppAPI.Application.Dtos.Palms.Common;
using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;
using CalcAppAPI.Application.Dtos.Palms.Trailer.Options;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Data;
using CalcAppAPI.Domain.Entities.Errors;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalcAppAPI.Application.Queries
{
    public class PalmsQueryHandler : IPalmsQueryHandler
    {
        private readonly DataContext _context;
        private readonly MachineConfigurationLoader _configurationLoader;

        public PalmsQueryHandler(DataContext context, MachineConfigurationLoader configurationLoader)
        {
            _context = context;
            _configurationLoader = configurationLoader;
        }

        public async Task<IEnumerable<PalmsTrailerCardOverviewDto>> GetTrailersAsync(CancellationToken cancellationToken)
        {
            var desiredOrder = new List<string>
            {
                "PALMS 2D", "PALMS 6S", "PALMS 8SX", "PALMS 8D",
                "PALMS 9SC", "PALMS 10D", "PALMS 12D",
                "PALMS 14D", "PALMS 10UX", "PALMS 11UX", "PALMS 12U",
                "PALMS 12UAWD", "PALMS 15U", "PALMS 15UAWD",
                "PALMS MWD 3.2", "PALMS HMWD 3.2"
            };

            var orderMap = desiredOrder
            .Select((name, index) => new { name, index })
            .ToDictionary(x => x.name, x => x.index);

            var trailers = await _context.Trailer
                .AsNoTracking()
                .Select(t => new PalmsTrailerCardOverviewDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    GrossWeight = t.GrossWeight,
                    Frame = t.Frame,
                    LoadingAreaCross = t.LoadingAreaCross,
                    MaxCraneSize = t.MaxCraneSize,
                    DrawbarControlCylinders = t.DrawbarControlCylinders,
                    BeamType = t.BeamType,
                    ImageUrl = t.ImageUrls.FirstOrDefault() ?? ""
                })
                .ToListAsync(cancellationToken);

            return trailers
                .OrderBy(t => orderMap.TryGetValue(t.Name, out var i) ? i : int.MaxValue)
                .ToList();
        }


        public async Task<PalmsTrailerDetailsDto> GetTrailerAsync(int id, CancellationToken cancellationToken)
        {
            var trailer = await _context.Trailer
                .AsNoTracking()
                .Include(t => t.Crane)
                .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);

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
                    Price = c.Price,
                    MaxReach = c.MaxReach,
                    BrutLiftingTorque215Bar = c.BrutLiftingTorque215Bar,
                    BrutLiftingTorque190Bar = c.BrutLiftingTorque190Bar,
                    TelescopeLength = c.TelescopeLength,
                    SlewingCylinder = c.SlewingCylinder,
                    SlewingTorque = c.SlewingTorque
                }),
                ImageUrls = trailer.ImageUrls,
                VideoUrls = trailer.VideoUrls,
            };
        }

        public async Task<IEnumerable<PalmsCraneCardOverviewDto>> GetCranesAsync(CancellationToken cancellationToken)
        {
            var desiredOrder = new List<string> {
                "PALMS 1.42", "PALMS 2.42", "PALMS 2.54", "PALMS 3.63",
                "PALMS 3.67", "PALMS 4.71", "PALMS 5.75", "PALMS 5.85", "PALMS 5.87Z",
                "PALMS 7.78", "PALMS 7.87", "PALMS 7.94", "PALMS X100"
            };

            var orderMap = desiredOrder
            .Select((name, index) => new { name, index })
            .ToDictionary(x => x.name, x => x.index);

            var cranes = await _context.Crane
                .AsNoTracking()
                .Select(c => new PalmsCraneCardOverviewDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    MaxReach = c.MaxReach,
                    BrutLiftingTorque190Bar = c.BrutLiftingTorque190Bar,
                    BrutLiftingTorque215Bar = c.BrutLiftingTorque215Bar,
                    TelescopeLength = c.TelescopeLength,
                    SlewingCylinder = c.SlewingCylinder,
                    SlewingTorque = c.SlewingTorque,
                    ImageUrl = c.ImageUrls.FirstOrDefault() ?? ""
                })
                .ToListAsync(cancellationToken);

            return cranes
                .OrderBy(c => orderMap.TryGetValue(c.Name, out var i) ? i : int.MaxValue)
                .ToList();
        }

        public async Task<PalmsCraneDetailsDto> GetCraneAsync(int id, CancellationToken cancellationToken)
        {
            var crane = await _context.Crane
                .AsNoTracking()
                .Include(t => t.Trailer)
                .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);

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
                ImageUrls = crane.ImageUrls,
                VideoUrls = crane.VideoUrls,
            };
        }

        public async Task<PalmsTrailerConfigurationsDto> GetTrailerConfigurationsAsync(int trailerId, CancellationToken cancellationToken)
        {
            var dto = await _context.Trailer
                .AsNoTracking()
                .AsSplitQuery()
                .Where(t => t.Id == trailerId)
                .Select(ToConfigurationsDto)
                .FirstOrDefaultAsync(cancellationToken);

            if (dto == null)
                throw Errors.Trailer.NotFound(trailerId);

            return dto;
        }

        // Refactor: Single method for mapping
        public static Expression<Func<Trailer, PalmsTrailerConfigurationsDto>> ToConfigurationsDto
        => t => new PalmsTrailerConfigurationsDto
        {
            Brakes = t.Brake.Select(x => new BrakeDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            Stanchions = t.Stanchion.Select(x => new StanchionDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            Propulsions = t.Propulsion.Select(x => new PropulsionDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                Description = x.Description,
                ImageUrls = x.ImageUrls
            }),

            Drawbars = t.Drawbar.Select(x => new DrawbarDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            Platforms = t.Platform.Select(x => new PlatformDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            OilPumps = t.OilPump.Select(x => new OilPumpDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            OilTanks = t.OilTank.Select(x => new OilTankDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            SupportLegs = t.SupportLeg.Select(x => new SupportLegDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            TrailerLights = t.Light.Select(x => new TrailerLightDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            Tyres = t.Tyre.Select(x => new TyreDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            HydroPacks = t.HydroPack.Select(x => new HydroPackDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            SupplyFormats = t.SupplyFormat.Select(x => new SupplyFormatDto
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                Price = x.Price,
                ImageUrls = x.ImageUrls
            }),

            TrailerOilCooler = t.TrailerOilCooler == null ? null : new TrailerOilCoolerDto
            {
                Id = t.TrailerOilCooler.Id,
                Name = t.TrailerOilCooler.Name,
                Code = t.TrailerOilCooler.Code,
                Price = t.TrailerOilCooler.Price,
                ImageUrls = t.TrailerOilCooler.ImageUrls
            },

            BolsterLock = t.BolsterLock == null ? null : new BolsterLockDto
            {
                Id = t.BolsterLock.Id,
                Name = t.BolsterLock.Name,
                Code = t.BolsterLock.Code,
                Price = t.BolsterLock.Price,
                ImageUrls = t.BolsterLock.ImageUrls
            },

            BBox = t.BBox == null ? null : new BBoxDto
            {
                Id = t.BBox.Id,
                Name = t.BBox.Name,
                Code = t.BBox.Code,
                Price = t.BBox.Price,
                ImageUrls = t.BBox.ImageUrls
            },

            DBox = t.DBox == null ? null : new DBoxDto
            {
                Id = t.DBox.Id,
                Name = t.DBox.Name,
                Code = t.DBox.Code,
                Price = t.DBox.Price,
                ImageUrls = t.DBox.ImageUrls
            },

            HayBaleFrame = t.HayBaleFrame == null ? null : new HayBaleFrameDto
            {
                Id = t.HayBaleFrame.Id,
                Name = t.HayBaleFrame.Name,
                Code = t.HayBaleFrame.Code,
                Price = t.HayBaleFrame.Price,
                ImageUrls = t.HayBaleFrame.ImageUrls
            },

            WoodSorter = t.WoodSorter == null ? null : new WoodSorterDto
            {
                Id = t.WoodSorter.Id,
                Name = t.WoodSorter.Name,
                Code = t.WoodSorter.Code,
                Price = t.WoodSorter.Price,
                ImageUrls = t.WoodSorter.ImageUrls
            },

            HandBrake = t.HandBrake == null ? null : new HandBrakeDto
            {
                Id = t.HandBrake.Id,
                Name = t.HandBrake.Name,
                Code = t.HandBrake.Code,
                Price = t.HandBrake.Price,
                ImageUrls = t.HandBrake.ImageUrls
            },

            ChainsawHolder = t.ChainsawHolder == null ? null : new ChainsawHolderDto
            {
                Id = t.ChainsawHolder.Id,
                Name = t.ChainsawHolder.Name,
                Code = t.ChainsawHolder.Code,
                Price = t.ChainsawHolder.Price,
                ImageUrls = t.ChainsawHolder.ImageUrls
            },

            UnderrunProtection = t.UnderrunProtection == null ? null : new UnderrunProtectionDto
            {
                Id = t.UnderrunProtection.Id,
                Code = t.UnderrunProtection.Code,
                Name = t.UnderrunProtection.Name,
                Price = t.UnderrunProtection.Price,
                ImageUrls = t.UnderrunProtection.ImageUrls
            },

            BunkAdapter = t.BunkAdapter == null ? null : new BunkAdapterDto
            {
                Id = t.BunkAdapter.Id,
                Name = t.BunkAdapter.Name,
                Code = t.BunkAdapter.Code,
                Price = t.BunkAdapter.Price,
                ImageUrls = t.BunkAdapter.ImageUrls
            },

            BunkExtension = t.BunkExtension == null ? null : new BunkExtensionDto
            {
                Id = t.BunkExtension.Id,
                Name = t.BunkExtension.Name,
                Code = t.BunkExtension.Code,
                Price = t.BunkExtension.Price,
                ImageUrls = t.BunkExtension.ImageUrls
            },

            ManualBunkExtension = t.ManualBunkExtension == null ? null : new ManualBunkExtensionDto
            {
                Id = t.ManualBunkExtension.Id,
                Name = t.ManualBunkExtension.Name,
                Code = t.ManualBunkExtension.Code,
                Price = t.ManualBunkExtension.Price,
                ImageUrls = t.ManualBunkExtension.ImageUrls
            },

            FrameExtension = t.FrameExtension == null ? null : new FrameExtensionDto
            {
                Id = t.FrameExtension.Id,
                Name = t.FrameExtension.Name,
                Code = t.FrameExtension.Code,
                Price = t.FrameExtension.Price,
                ImageUrls = t.FrameExtension.ImageUrls
            },

            Shipping = t.Shipping == null ? null : new ShippingDto
            {
                Id = t.Shipping.Id,
                Name = t.Shipping.Name,
                Code = t.Shipping.Code,
                Price = t.Shipping.Price,
                ImageUrls = t.Shipping.ImageUrls
            },

            MOT = t.MOT == null ? null : new MOTDto
            {
                Id = t.MOT.Id,
                Name = t.MOT.Name,
                Code = t.MOT.Code,
                Price = t.MOT.Price,
                ImageUrls = t.MOT.ImageUrls
            },

            StanchionExtension = t.StanchionExtension == null ? null : new StanchionExtensionDto
            {
                Id = t.StanchionExtension.Id,
                Name = t.StanchionExtension.Name,
                Code = t.StanchionExtension.Code,
                Price = t.StanchionExtension.Price,
                ImageUrls = t.StanchionExtension.ImageUrls
            },

            HydroPackControl = t.HydropackControl == null ? null : new HydroPackControlDto
            {
                Id = t.HydropackControl.Id,
                Name = t.HydropackControl.Name,
                Code = t.HydropackControl.Code,
                Price = t.HydropackControl.Price,
                ImageUrls = t.HydropackControl.ImageUrls
            },

            Toolbox = t.Toolbox == null ? null : new ToolboxDto
            {
                Id = t.Toolbox.Id,
                Name = t.Toolbox.Name,
                Code = t.Toolbox.Code,
                Price = t.Toolbox.Price,
                ImageUrls = t.Toolbox.ImageUrls
            }
        };
    }
}
