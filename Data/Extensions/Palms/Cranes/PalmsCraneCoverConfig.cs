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
                  Name = "Védőhuzat bőrből A2-A7-es, A11-es, A12-es és A14-es vezértömbökhöz",
                  Code = "JKK",
                  Price = "50"
              }
              );
        }
    }
}
