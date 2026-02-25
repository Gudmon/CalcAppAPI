using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneHoseGuardConfig
    {
        public static void ConfigureMultiplePalmsCraneHoseGuards(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoseGuard>().HasData(
              new HoseGuard()
              {
                  Id = 1,
                  Name = "Tömlő védő B3 és B6 talpaló esetén",
                  Code = "HG1",
                  Price = "105",
                  ImageUrls = ["PALMS_crane-hose-guard-1"]
              },
              new HoseGuard
              {
                  Id = 2,
                  Name = "Tömlő védő B9 talpaló esetén",
                  Code = "HG2",
                  Price = "105",
                  ImageUrls = ["PALMS_crane-hose-guard-1"]
              }
              );
        }
    }
}
