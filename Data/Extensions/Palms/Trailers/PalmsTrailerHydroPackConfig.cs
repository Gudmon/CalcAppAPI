using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerHydroPackConfig
    {
        public static void ConfigureMultiplePalmsHydroPacks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydroPack>().HasData(
               new HydroPack
               {
                   Id = 1,
                   Name = "Hydropack 6,5 lóerő - 12 l/min",
                   Code = "HyP",
                   Price = "2195",
               });
        }
    }
}
