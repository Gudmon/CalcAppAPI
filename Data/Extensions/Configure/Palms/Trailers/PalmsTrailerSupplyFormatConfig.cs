using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerSupplyFormatConfig
    {
        public static void ConfigureMultiplePalmsSupplyFormats(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyFormat>().HasData(
               new SupplyFormat
               {
                   Id = 1,
                   Name = "Raklapra csomagolva",
                   Code = "POP",
                   Price = "0",
               },
               new SupplyFormat
               {
                   Id = 2,
                   Name = "Teljesen összeszerelve",
                   Code = "FA",
                   Price = "195",
               }
              );
        }
    }
}
