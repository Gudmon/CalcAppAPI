using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
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
                  Description = null
              },
              new RotatorBrake
              {
                  Id = 2,
                  Name = "Rotátor fék",
                  Code = "Br1",
                  Price = "85",
                  Description = "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva."
              },
              new RotatorBrake
              {
                  Id = 3,
                  Name = "Rotátor fék",
                  Code = "Br1",
                  Price = "55",
                  Description = "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva."
              },
              new RotatorBrake
              {
                  Id = 4,
                  Name = "Dupla rotátor fék",
                  Code = "Br2",
                  Price = "125",
                  Description = "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva."
              },
              new RotatorBrake
              {
                  Id = 5,
                  Name = "Dupla rotátor fék",
                  Code = "Br2",
                  Price = "220",
                  Description = "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva."
              }
              );
        }
    }
}
