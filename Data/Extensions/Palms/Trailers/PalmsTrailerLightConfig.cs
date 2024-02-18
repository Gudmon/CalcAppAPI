using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerLightConfig
    {
        public static void ConfigureMultiplePalmsLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Light>().HasData(
               new Light
               {
                   Id = 1,
                   Name = "Összecsukható hátsó lámpák",
                   Code = "L1",
                   Price = "420",
               },
               new Light
               {
                   Id = 2,
                   Name = "Hátsó LED lámpa flexibilis Kilpi karokkal",
                   Code = "L2",
                   Price = "465",
               },
               new Light
               {
                   Id = 3,
                   Name = "Fix hátsó LED lámpák",
                   Code = "L4",
                   Price = "420",
               }
               );
        }
    }
}
