using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerOilCoolerConfig
    {
        public static void ConfigureMultiplePalmsTrailerOilCoolers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrailerOilCooler>().HasData(
               new TrailerOilCooler
               {
                   Id = 1,
                   Name = "Olajhűtő csomag a tartályhoz rögzítve",
                   Code = "CP2",
                   Price = "1035",
               },
               new TrailerOilCooler
               {
                   Id = 2,
                   Name = "Olajhűtő csomag a tartályhoz rögzítve",
                   Code = "CP4",
                   Price = "1190",
               }
               );
        }
    }
}
