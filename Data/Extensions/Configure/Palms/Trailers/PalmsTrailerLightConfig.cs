using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerLightConfig
    {
        public static void ConfigureMultiplePalmsTrailerLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrailerLight>().HasData(
               new TrailerLight
               {
                   Id = 1,
                   Name = "Összecsukható hátsó lámpák",
                   Code = "L1",
                   Price = "420",
                   ImageUrls = ["PALMS-trailer-light-L1-1", "PALMS-trailer-light-L1-2"]
               },
               new TrailerLight
               {
                   Id = 2,
                   Name = "Hátsó LED lámpa flexibilis Kilpi karokkal",
                   Code = "L2",
                   Price = "465",
                   ImageUrls = ["PALMS-trailer-light-L2-1", "PALMS-trailer-light-L2-2"]
               },
               new TrailerLight
               {
                   Id = 3,
                   Name = "Fix hátsó LED lámpák",
                   Code = "L4",
                   Price = "420",
                   ImageUrls = ["PALMS-trailer-light-L4-1", "PALMS-trailer-light-L4-2"]
               },
               new TrailerLight
               {
                   Id = 4,
                   Name = "Összecsukható hátsó lámpák",
                   Code = "L1",
                   Price = "340",
                   ImageUrls = ["PALMS-trailer-light-L1-1", "PALMS-trailer-light-L1-2"]
               },
               new TrailerLight
               {
                   Id = 5,
                   Name = "Hátsó LED lámpa flexibilis Kilpi karokkal",
                   Code = "L2",
                   Price = "440",
                   ImageUrls = ["PALMS-trailer-light-L2-1", "PALMS-trailer-light-L2-2"]
               }
               );
        }
    }
}
