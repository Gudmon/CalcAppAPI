using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneHoseGuardConfig
    {
        public static void ConfigureMultiplePalmsCraneHoseGuards(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoseGuard>().HasData(
              new HoseGuard()
              {
                  Id = 1,
                  Name = "Tömlő védő B3 és B6.1 talpaló esetén",
                  Code = "HG1",
                  Price = "105"
              },
              new HoseGuard
              {
                  Id = 2,
                  Name = "Tömlő védő  B09 és B9 talpaló esetén",
                  Code = "HG2",
                  Price = "105"
              }
              );
        }
    }
}
