using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneLightConfig
    {
        public static void ConfigureMultiplePalmsCraneLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneLight>().HasData(
              new CraneLight
              {
                  Id = 1,
                  Name = "LED munkalámpák a darugémre, 2 db",
                  Code = "L1",
                  Price = "510",
                  ImageUrls = ["PALMS-crane-light-1", "PALMS-crane-light-2"]
              },
              new CraneLight
              {
                  Id = 2,
                  Name = "LED munkalámpák a darugémre, 1 db",
                  Code = "L1",
                  Price = "335",
                  ImageUrls = ["PALMS-crane-light-1", "PALMS-crane-light-2"]
              }
              );
        }
    }
}
