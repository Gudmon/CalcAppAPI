using CalcAppAPI.Application.Dtos.Palms.Crane;
using CalcAppAPI.Application.Dtos.Palms.Trailer;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Data;
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
        public async Task<TrailerDetailsDto?> GetTrailerAsync(int id)
        {
            var trailer = await _context.Trailer
                .AsNoTracking()
                .Include(t => t.Crane)
                .Include(t => t.Brake)
                .Include(t => t.Propulsion)
                .Include(t => t.Stanchion)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (trailer == null)
                return null;

            return new TrailerDetailsDto
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

                Cranes = trailer.Crane.Select(c => new CraneNestedDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Price = c.Price,
                    Series = c.Series,
                    MaxReach = c.MaxReach,
                    BrutLiftingTorque240Bar = c.BrutLiftingTorque240Bar,
                    BrutLiftingTorque215Bar = c.BrutLiftingTorque215Bar,
                    BrutLiftingTorque190Bar = c.BrutLiftingTorque190Bar,
                    TelescopeLength = c.TelescopeLength,
                    SlewingCylinder = c.SlewingCylinder,
                    SlewingTorque = c.SlewingTorque
                }),

                Options = BuildOptions(trailer)
            };
        }

        private IEnumerable<TrailerOptionDto> BuildOptions(
            Trailer trailer)
        {
            var list = new List<TrailerOptionDto>();

            if (trailer.Brake != null)
                list.AddRange(trailer.Brake.Select(b =>
                    new TrailerOptionDto
                    {
                        Id = b.Id,
                        Code = b.Code,
                        Name = b.Name,
                        Price = b.Price
                    }));

            if (trailer.Propulsion != null)
                list.AddRange(trailer.Propulsion.Select(p =>
                    new TrailerOptionDto
                    {
                        Id = p.Id,
                        Code = p.Code,
                        Name = p.Name,
                        Price = p.Price
                    }));

            if (trailer.Stanchion != null)
                list.AddRange(trailer.Stanchion.Select(s =>
                    new TrailerOptionDto
                    {
                        Id = s.Id,
                        Code = s.Code,
                        Name = s.Name,
                        Price = s.Price
                    }));

            return list;
        }
    }
}
