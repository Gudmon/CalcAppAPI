using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneBoomGuardConfig
    {
        public static void ConfigureMultiplePalmsCraneBoomGuards(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoomGuard>().HasData(
              new BoomGuard
              {
                  Id = 1,
                  Name = "Főgém védő az 5-ös szériához",
                  Code = "BG5",
                  Price = "630"
              },
              new BoomGuard
              {
                  Id = 2,
                  Name = "Főgém védő a 7-es szériához",
                  Code = "BG7",
                  Price = "650"
              },
              new BoomGuard
              {
                  Id = 3,
                  Name = "Főgém védő X100-hoz",
                  Code = "BG10",
                  Price = "675"
              }
              );
        }
    }
}
