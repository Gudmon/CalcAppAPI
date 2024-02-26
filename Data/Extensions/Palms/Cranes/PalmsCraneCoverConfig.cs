using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneCoverConfig
    {
        public static void ConfigureMultiplePalmsCraneCovers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cover>().HasData(
              new Cover
              {
                  Id = 1,
                  Name = "Védőhuzat bőrből A2-A7-hez, A11-hez, A12-höz és A14-hez",
                  Code = "JKK",
                  Price = "50"
              }
              );
        }
    }
}
