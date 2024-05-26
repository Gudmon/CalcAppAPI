using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneLinkageConfig
    {
        public static void ConfigureMultiplePalmsCraneLinkages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Linkage>().HasData(
              new Linkage
              {
                  Id = 1,
                  Name = "3 pontos csatlakozó adapter (csak a B9 és B10 talpalóval kompatibilis)",
                  Code = "3PL",
                  Price = "960"
              }
              );
        }
    }
}
