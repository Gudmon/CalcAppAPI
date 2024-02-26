using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneSupportLegCounterPlateConfig
    {
        public static void ConfigureMultiplePalmsCraneSupportLegCounterPlates(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportLegCounterPlate>().HasData(
              new SupportLegCounterPlate
              {
                  Id = 1,
                  Name = "Fedőlap a Palms talpaló lábhoz",
                  Code = "PL2",
                  Price = "475"
              }
              );
        }
    }
}
