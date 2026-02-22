using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerPlatformConfig
    {
        public static void ConfigureMultiplePalmsPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().HasData(
               new Platform
               {
                   Id = 1,
                   Name = "Kezelő platform háttámlával a vonórúdon",
                   Code = "D1",
                   Price = "600",
                   ImageUrls = ["PALMS-trailer-platform-1", "PALMS-trailer-platform-2", "PALMS-trailer-platform-3", "PALMS-trailer-platform-4"]
               },
               new Platform
               {
                   Id = 2,
                   Name = "Kezelő platform háttámlával a vonórúdon túlfutásgátlós vonórúddal",
                   Code = "D2",
                   Price = "600",
                   ImageUrls = ["PALMS-trailer-platform-1", "PALMS-trailer-platform-2", "PALMS-trailer-platform-3", "PALMS-trailer-platform-4"]
               }
               );
        }
    }
}
