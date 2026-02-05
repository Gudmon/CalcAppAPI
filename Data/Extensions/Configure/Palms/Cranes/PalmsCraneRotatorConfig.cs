using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneRotatorConfig
    {
        public static void ConfigureMultiplePalmsRotators(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rotator>().HasData(
              new Rotator
              {
                  Id = 1,
                  Name = "Rotátor nélkül",
                  Code = "R0",
                  Price = "0",
              },
              new Rotator
              {
                  Id = 2,
                  Name = "30 kN-os rotátor (csapos)",
                  Code = "R30",
                  Price = "300"
              },
              new Rotator
              {
                  Id = 3,
                  Name = "30 kN-os rotátor FL (talpas)",
                  Code = "R31",
                  Price = "430"
              },
              new Rotator
              {
                  Id = 4,
                  Name = "45 kN-os rotátor FL (talpas)",
                  Code = "R45",
                  Price = "620",
              },
              new Rotator
              {
                  Id = 5,
                  Name = "55 kN-os rotátor FL (talpas)",
                  Code = "R55",
                  Price = "915",
              },
              new Rotator
              {
                  Id = 6,
                  Name = "60 kN-os rotátor FL Indexator GV6 (talpas)",
                  Code = "R60",
                  Price = "1600",
              },
              new Rotator
              {
                  Id = 7,
                  Name = "100 kN-os rotátor FL Indexator T10 (talpas)",
                  Code = "R90",
                  Price = "1880",
              },
              new Rotator
              {
                  Id = 8,
                  Name = "Rotátor 1000 kN (csapos - Finrotor)",
                  Code = "R10",
                  Price = "245",
              }
              );
        }
    }
}
