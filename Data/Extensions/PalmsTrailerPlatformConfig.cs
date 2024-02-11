using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
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
               },
               new Platform
               {
                   Id = 2,
                   Name = "Kezelő platform háttámlával a vonórúdon túlfutásgátlós vonórúddal",
                   Code = "D2",
                   Price = "600",
               }
               );
        }
    }
}
