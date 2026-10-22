using CalcAppAPI.Application.Dtos.Krpan.Crane;
using CalcAppAPI.Application.Dtos.Krpan.Trailer;
using CalcAppAPI.Application.Dtos.Krpan.Trailer.Options;
using CalcAppAPI.Models.Machine.Krpan.Trailers;
using System.Linq.Expressions;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Application.Queries
{
    public class KrpanQueryHandler : IKrpanQueryHandler
    {
        private readonly DataContext _context;

        public KrpanQueryHandler(DataContext context)
        {
            _context = context;
        }

        public static Expression<Func<KrpanTrailer, KrpanTrailerConfigurationsDto>> ToConfigurationsDto
            => t => new KrpanTrailerConfigurationsDto
            {
                Brakes = t.KrpanBrake.Select(x => new KrpanBrakeDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                Tyres = t.KrpanTyre.Select(x => new KrpanTyreDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                SupportLegs = t.KrpanTrailerSupportLegs.Select(x => new KrpanTrailerSupportLegDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                Propulsions = t.KrpanPropulsion.Select(x => new PropulsionDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                Drawbars = t.KrpanDrawbar.Select(x => new KrpanDrawbarDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                AdjustableDrive = t.KrpanAdjustableDrive == null ? null : new KrpanAdjustableDriveDto
                {
                    Id = t.KrpanAdjustableDrive.Id,
                    Name = t.KrpanAdjustableDrive.Name,
                    Code = t.KrpanAdjustableDrive.Code,
                    Price = t.KrpanAdjustableDrive.Price
                },

                TrailerLamp = t.KrpanTrailerLamp == null ? null : new KrpanTrailerLampDto
                {
                    Id = t.KrpanTrailerLamp.Id,
                    Name = t.KrpanTrailerLamp.Name,
                    Code = t.KrpanTrailerLamp.Code,
                    Price = t.KrpanTrailerLamp.Price
                },

                Chock = t.KrpanChock == null ? null : new KrpanChockDto
                {
                    Id = t.KrpanChock.Id,
                    Name = t.KrpanChock.Name,
                    Code = t.KrpanChock.Code,
                    Price = t.KrpanChock.Price
                },

                WheelChock = t.KrpanWheelChock == null ? null : new KrpanWheelChockDto
                {
                    Id = t.KrpanWheelChock.Id,
                    Name = t.KrpanWheelChock.Name,
                    Code = t.KrpanWheelChock.Code,
                    Price = t.KrpanWheelChock.Price
                },

                DrawbarSteering = t.KrpanDrawbarSteering == null ? null : new KrpanDrawbarSteeringDto
                {
                    Id = t.KrpanDrawbarSteering.Id,
                    Name = t.KrpanDrawbarSteering.Name,
                    Code = t.KrpanDrawbarSteering.Code,
                    Price = t.KrpanDrawbarSteering.Price
                },

                Clutches = t.KrpanClutch.Select(x => new KrpanClutchDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                TrailerCouplingDevices = t.KrpanTrailerCouplingDevice.Select(x => new KrpanTrailerCouplingDeviceDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                CardanShaft = t.KrpanCardanShaft == null ? null : new KrpanCardanShaftDto
                {
                    Id = t.KrpanCardanShaft.Id,
                    Name = t.KrpanCardanShaft.Name,
                    Code = t.KrpanCardanShaft.Code,
                    Price = t.KrpanCardanShaft.Price
                },

                BBox = t.KrpanBBox == null ? null : new KrpanBBoxDto
                {
                    Id = t.KrpanBBox.Id,
                    Name = t.KrpanBBox.Name,
                    Code = t.KrpanBBox.Code,
                    Price = t.KrpanBBox.Price
                },

                BaleTransportPlatform = t.KrpanBaleTransportPlatform == null ? null : new KrpanBaleTransportPlatformDto
                {
                    Id = t.KrpanBaleTransportPlatform.Id,
                    Name = t.KrpanBaleTransportPlatform.Name,
                    Code = t.KrpanBaleTransportPlatform.Code,
                    Price = t.KrpanBaleTransportPlatform.Price
                },

                CargoSpaceExtension = t.KrpanCargoSpaceExtension == null ? null : new KrpanCargoSpaceExtensionDto
                {
                    Id = t.KrpanCargoSpaceExtension.Id,
                    Name = t.KrpanCargoSpaceExtension.Name,
                    Code = t.KrpanCargoSpaceExtension.Code,
                    Price = t.KrpanCargoSpaceExtension.Price
                },

                AxeHolder = t.KrpanAxeHolder == null ? null : new KrpanAxeHolderDto
                {
                    Id = t.KrpanAxeHolder.Id,
                    Name = t.KrpanAxeHolder.Name,
                    Code = t.KrpanAxeHolder.Code,
                    Price = t.KrpanAxeHolder.Price
                },

                ChainsawHolder = t.KrpanChainsawHolder == null ? null : new KrpanChainsawHolderDto
                {
                    Id = t.KrpanChainsawHolder.Id,
                    Name = t.KrpanChainsawHolder.Name,
                    Code = t.KrpanChainsawHolder.Code,
                    Price = t.KrpanChainsawHolder.Price
                },

                FuelTankHolder = t.KrpanFuelTankHolder == null ? null : new KrpanFuelTankHolderDto
                {
                    Id = t.KrpanFuelTankHolder.Id,
                    Name = t.KrpanFuelTankHolder.Name,
                    Code = t.KrpanFuelTankHolder.Code,
                    Price = t.KrpanFuelTankHolder.Price
                },

                ToolBox = t.KrpanToolBox == null ? null : new KrpanToolBoxDto
                {
                    Id = t.KrpanToolBox.Id,
                    Name = t.KrpanToolBox.Name,
                    Code = t.KrpanToolBox.Code,
                    Price = t.KrpanToolBox.Price
                },

                Plato = t.KrpanPlato == null ? null : new KrpanPlatoDto
                {
                    Id = t.KrpanPlato.Id,
                    Name = t.KrpanPlato.Name,
                    Code = t.KrpanPlato.Code,
                    Price = t.KrpanPlato.Price
                },

                Extension = t.KrpanExtension == null ? null : new KrpanExtensionDto
                {
                    Id = t.KrpanExtension.Id,
                    Name = t.KrpanExtension.Name,
                    Code = t.KrpanExtension.Code,
                    Price = t.KrpanExtension.Price
                },

                GrappleLocation = t.KrpanGrappleLocation == null ? null : new KrpanGrappleLocationDto
                {
                    Id = t.KrpanGrappleLocation.Id,
                    Name = t.KrpanGrappleLocation.Name,
                    Code = t.KrpanGrappleLocation.Code,
                    Price = t.KrpanGrappleLocation.Price
                },

                MechanicalAdjustableFrame = t.KrpanMechanicalAdjustableFrame == null ? null : new KrpanMechanicalAdjustableFrameDto
                {
                    Id = t.KrpanMechanicalAdjustableFrame.Id,
                    Name = t.KrpanMechanicalAdjustableFrame.Name,
                    Code = t.KrpanMechanicalAdjustableFrame.Code,
                    Price = t.KrpanMechanicalAdjustableFrame.Price
                },

                Stanchions = t.KrpanStanchions.Select(x => new KrpanStanchionDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code,
                    Price = x.Price
                }),

                HandBrake = t.KrpanHandBrake == null ? null : new KrpanHandBrakeDto
                {
                    Id = t.KrpanHandBrake.Id,
                    Name = t.KrpanHandBrake.Name,
                    Code = t.KrpanHandBrake.Code,
                    Price = t.KrpanHandBrake.Price
                }
            };

        public async Task<IEnumerable<KrpanTrailerCardOverviewDto>> GetTrailersAsync(CancellationToken cancellationToken)
        {
            var desiredOrder = new List<string>
            {
                "GP 6 XS", "GP 7 XS", "GP 8 XS", "GP 8 S", "GP 9 S", "GP 10 S",
                "GP 8 DF", "GP 9 DF", "GP 10 DF", "GP 12 DF", "GP 14 DF",
                "GP 11 D", "GP 13 D", "GP 15 D"
            };

            var orderMap = desiredOrder
                .Select((name, index) => new { name, index })
                .ToDictionary(x => x.name, x => x.index);

            var trailers = await _context.KrpanTrailer
                .AsNoTracking()
                .Select(t => new KrpanTrailerCardOverviewDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    LoadCapacity = t.LoadCapacity,
                    LoadingLength = t.LoadingLength,
                    LoadingLengthWithExtension = t.LoadingLengthWithExtension,
                    Weight = t.Weight,
                    ImageUrl = t.ImageUrls.FirstOrDefault() ?? ""
                })
                .ToListAsync(cancellationToken);

            return trailers
                .OrderBy(t => orderMap.TryGetValue(t.Name, out var i) ? i : int.MaxValue)
                .ToList();
        }

        public async Task<KrpanTrailerDetailsDto> GetTrailerAsync(int id, CancellationToken cancellationToken)
        {
            var trailer = await _context.KrpanTrailer
                .AsNoTracking()
                .Include(t => t.KrpanCrane)
                .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);

            if (trailer == null)
                throw new KeyNotFoundException($"Trailer {id} not found");

            return new KrpanTrailerDetailsDto
            {
                Id = trailer.Id,
                Name = trailer.Name,
                Description = trailer.Description,
                Price = trailer.Price,
                LoadCapacity = trailer.LoadCapacity,
                CentralBeams = trailer.CentralBeams,
                LoadingLength = trailer.LoadingLength,
                LoadingLengthWithExtension = trailer.LoadingLengthWithExtension,
                TotalLength = trailer.TotalLength,
                TotalLengthWithExtension = trailer.TotalLengthWithExtension,
                TotalWidth = trailer.TotalWidth,
                Weight = trailer.Weight,
                Cranes = trailer.KrpanCrane.Select(c => new KrpanCraneCardOverviewDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    MaxReach = c.MaxReach,
                    MaxReachWithGrabOpen = c.MaxReachWithGrabOpen,
                    NetLiftingTorque = c.NetLiftingTorque,
                    LiftCapacityAtFourMeters = c.LiftCapacityAtFourMeters,
                    ImageUrl = c.KrpanTrailer.SelectMany(t => t.ImageUrls).FirstOrDefault() ?? ""
                }),
                ImageUrls = trailer.ImageUrls,
                VideoUrls = trailer.VideoUrls
            };
        }

        public async Task<IEnumerable<KrpanCraneCardOverviewDto>> GetCranesAsync(CancellationToken cancellationToken)
        {
            var cranes = await _context.KrpanCrane
                .AsNoTracking()
                .Select(c => new KrpanCraneCardOverviewDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    MaxReach = c.MaxReach,
                    MaxReachWithGrabOpen = c.MaxReachWithGrabOpen,
                    NetLiftingTorque = c.NetLiftingTorque,
                    LiftCapacityAtFourMeters = c.LiftCapacityAtFourMeters,
                    ImageUrl = c.KrpanTrailer.SelectMany(t => t.ImageUrls).FirstOrDefault() ?? ""
                })
                .ToListAsync(cancellationToken);

            return cranes;
        }

        public async Task<KrpanCraneDetailsDto> GetCraneAsync(int id, CancellationToken cancellationToken)
        {
            var crane = await _context.KrpanCrane
                .AsNoTracking()
                .Include(c => c.KrpanTrailer)
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

            if (crane == null)
                throw new KeyNotFoundException($"Crane {id} not found");

            return new KrpanCraneDetailsDto
            {
                Id = crane.Id,
                Name = crane.Name,
                Description = crane.Description,
                Price = crane.Price,
                MaxReach = crane.MaxReach,
                MaxReachWithGrabOpen = crane.MaxReachWithGrabOpen,
                NetLiftingTorque = crane.NetLiftingTorque,
                BrutLiftingTorque = crane.BrutLiftingTorque,
                LiftCapacityAtFourMeters = crane.LiftCapacityAtFourMeters,
                LiftCapacityAtMaxReach = crane.LiftCapacityAtMaxReach,
                Weight = crane.Weight,
                SlewTorque = crane.SlewTorque,
                SlewingAngle = crane.SlewingAngle,
                SystemPressure = crane.SystemPressure,
                OilQuantityInTank = crane.OilQuantityInTank,
                SlewCylinders = crane.SlewCylinders,
                TelescopicStages = crane.TelescopicStages,
                Trailers = crane.KrpanTrailer.Select(t => new KrpanTrailerCardOverviewDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    LoadCapacity = t.LoadCapacity,
                    LoadingLength = t.LoadingLength,
                    LoadingLengthWithExtension = t.LoadingLengthWithExtension,
                    Weight = t.Weight,
                    ImageUrl = t.ImageUrls.FirstOrDefault() ?? ""
                })
            };
        }
    }
}
