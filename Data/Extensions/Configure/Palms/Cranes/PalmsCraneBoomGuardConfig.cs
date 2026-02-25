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
                  Price = "630",
                  ImageUrls = ["PALMS-crane-boom-guard-BG5-BG7-1", "PALMS-crane-boom-guard-BG5-BG7-2"]
              },
              new BoomGuard
              {
                  Id = 2,
                  Name = "Főgém védő a 7-es szériához",
                  Code = "BG7",
                  Price = "650",
                  ImageUrls = ["PALMS-crane-boom-guard-BG5-BG7-1", "PALMS-crane-boom-guard-BG5-BG7-2"]
              },
              new BoomGuard
              {
                  Id = 3,
                  Name = "Főgém védő X100-hoz",
                  Code = "BG10",
                  Price = "675",
                  ImageUrls = ["PALMS-crane-boom-guard-BG10"],
                  VideoUrls = ["LfALbXK_8F4&t"]
              }
              );
        }
    }
}
