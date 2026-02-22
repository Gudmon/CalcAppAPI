using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
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
                   ImageUrls = ["PALMS-trailer-oil-cooler-1"],
                   VideoUrls = ["5u9NDzvA0gk"]
               },
               new TrailerOilCooler
               {
                   Id = 2,
                   Name = "Olajhűtő csomag a tartályhoz rögzítve",
                   Code = "CP4",
                   Price = "1190",
                   ImageUrls = ["PALMS-trailer-oil-cooler-1"],
                   VideoUrls = ["5u9NDzvA0gk"]
               }
               );
        }
    }
}
