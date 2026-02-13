using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneSupportBracketConfig
    {
        public static void ConfigureMultiplePalmsCraneSupportBrackets(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportBracket>().HasData(
              new SupportBracket
              {
                  Id = 1,
                  Name = "Támasztókonzol",
                  Description = "csavarozható a keretre a védőburkolat és az első rakoncapár között",
                  Code = "BOB",
                  Price = "125"
              }
              );
        }
    }
}
