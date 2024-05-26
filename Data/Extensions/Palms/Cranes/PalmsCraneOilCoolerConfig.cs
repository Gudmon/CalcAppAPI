using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneOilCoolerConfig
    {
        public static void ConfigureMultiplePalmsCraneOilCoolers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneOilCooler>().HasData(
              new CraneOilCooler
              {
                  Id = 1,
                  Name = "Olajhűtő csomag elektromos csatlakozással a traktorhoz",
                  Code = "CP1",
                  Price = "1035"
              }
              );
        }
    }
}
