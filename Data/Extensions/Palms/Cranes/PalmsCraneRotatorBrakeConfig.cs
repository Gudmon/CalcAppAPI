using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneRotatorBrakeConfig
    {
        public static void ConfigureMultiplePalmsCraneRotatorBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RotatorBrake>().HasData(
              new RotatorBrake
              {
                  Id = 1,
                  Name = "Rotátorfék  nélkül",
                  Code = "Br0",
                  Price = "0",
              },
              new RotatorBrake
              {
                  Id = 2,
                  Name = "Rotátor fék",
                  Code = "Br1",
                  Price = "75"
              },
              new RotatorBrake
              {
                  Id = 3,
                  Name = "Rotátor fék",
                  Code = "Br1",
                  Price = "55"
              },
              new RotatorBrake
              {
                  Id = 4,
                  Name = "Dupla rotátor fék",
                  Code = "Br2",
                  Price = "115"
              },
              new RotatorBrake
              {
                  Id = 5,
                  Name = "Dupla rotátor fék",
                  Code = "Br2",
                  Price = "220"
              }
              );
        }
    }
}
