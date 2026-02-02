using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerHydroPackConfig
    {
        public static void ConfigureMultiplePalmsHydropacks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydroPack>().HasData(
               new HydroPack
               {
                   Id = 1,
                   Name = "Hydropack 6,5 lóerő - 12 l/min, 1 szekciós",
                   Code = "HyP1",
                   Price = "1575",
               },
               new HydroPack
               {
                   Id = 2,
                   Name = "Hydropack 6,5 lóerő - 12 l/min, 4 szekciós",
                   Code = "HyP4",
                   Price = "2365",
               },
               new HydroPack
               {
                   Id = 3,
                   Name = "Hydropack 6,5 lóerő - 12 l/min, 4 szekciós + elektronikus indítás és akkumulátor",
                   Code = "HyP4+",
                   Price = "1510",
               });
        }
    }
}
