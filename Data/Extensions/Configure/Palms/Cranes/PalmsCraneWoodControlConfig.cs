using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneWoodControlConfig
    {
        public static void ConfigureMultiplePalmsCraneWoodControls(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WoodControl>().HasData(
              new WoodControl
              {
                  Id = 1,
                  Name = "Hosszú fás kiegészítő a főgémhez",
                  Code = "LWS",
                  Price = "150"
              }
              );
        }
    }
}
