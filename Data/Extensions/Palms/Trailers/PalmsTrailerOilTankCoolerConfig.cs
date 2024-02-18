using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerOilTankCoolerConfig
    {
        public static void ConfigureMultiplePalmsOilTankCoolers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OilTankCooler>().HasData(
               new OilTankCooler
               {
                   Id = 1,
                   Name = "Olajhűtő csomag a tartályhoz rögzítve",
                   Code = "CP2",
                   Price = "1035",
               });
        }
    }
}
