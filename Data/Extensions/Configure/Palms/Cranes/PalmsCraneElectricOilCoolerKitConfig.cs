using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneElectricOilCoolerKitConfig
    {
        public static void ConfigureMultiplePalmsCraneElectricOilCoolerKits(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneElectricOilCoolerKit>().HasData(
               new CraneElectricOilCoolerKit
               {
                   Id = 1,
                   Name = "Nagy olajhűtő csomag elektromos csatlakozással a traktorhoz",
                   Code = "T5",
                   Price = "1290",
                   ImageUrls = ["PALMS-crane-electric-oil-cooler-kit-1"]
               }
               );
        }
    }
}
