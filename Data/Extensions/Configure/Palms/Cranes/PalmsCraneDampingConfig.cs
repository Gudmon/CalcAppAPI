using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneDampingConfig
    {
        public static void ConfigureMultiplePalmsDampings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Damping>().HasData(
              new Damping()
              {
                  Id = 1,
                  Name = "Csillapító a munkahenger elforgatáshoz",
                  Code = "D1",
                  Price = "945",
                  ImageUrls = ["PALMS-crane-damping-1", "PALMS-crane-damping-2"]
              },
              new Damping
              {
                  Id = 2,
                  Name = "Csillapító a munkahenger elforgatáshoz és emeléshez",
                  Code = "D2",
                  Price = "1610",
                  ImageUrls = ["PALMS-crane-damping-1", "PALMS-crane-damping-2"]
              },
              new Damping
              {
                  Id = 3,
                  Name = "Csillapító emeléshez",
                  Code = "D3",
                  Price = "665",
                  ImageUrls = ["PALMS-crane-damping-1", "PALMS-crane-damping-2"]
              }
              );
        }
    }
}
