using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneTurningDeviceCounterPlateConfig
    {
        public static void ConfigureMultiplePalmsCraneTurningDeviceCounterPlates(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurningDeviceCounterPlate>().HasData(
              new TurningDeviceCounterPlate
              {
                  Id = 1,
                  Name = "Fedőlap a fordító szerkezethez",
                  Code = "PL",
                  Price = "340"
              }
              );
        }
    }
}
