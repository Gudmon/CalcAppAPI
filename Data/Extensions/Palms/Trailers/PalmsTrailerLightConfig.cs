using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerLightConfig
    {
        public static void ConfigureMultiplePalmsTrailerLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrailerLights>().HasData(
               new TrailerLights
               {
                   Id = 1,
                   Name = "Összecsukható hátsó lámpák",
                   Code = "L1",
                   Price = "420",
               },
               new TrailerLights
               {
                   Id = 2,
                   Name = "Hátsó LED lámpa flexibilis Kilpi karokkal",
                   Code = "L2",
                   Price = "465",
               },
               new TrailerLights
               {
                   Id = 3,
                   Name = "Fix hátsó LED lámpák",
                   Code = "L4",
                   Price = "420",
               },
               new TrailerLights
               {
                   Id = 4,
                   Name = "Összecsukható hátsó lámpák",
                   Code = "L1",
                   Price = "340",
               },
               new TrailerLights
               {
                   Id = 5,
                   Name = "Hátsó LED lámpa flexibilis Kilpi karokkal",
                   Code = "L2",
                   Price = "440",
               }
               );
        }
    }
}
