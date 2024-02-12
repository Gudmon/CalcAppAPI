using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerUnderrunProtectionConfig
    {
        public static void ConfigureMultiplePalmsUnderrunProtections(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnderrunProtection>().HasData(
               new UnderrunProtection
               {
                   Id = 1,
                   Name = "Aláfutásgátló D-típushoz, hátsó lámpa és rendszámtartó",
                   Code = "RUP1",
                   Price = "1040",
               },
               new UnderrunProtection
               {
                   Id = 2,
                   Name = "Aláfutásgátló S és U-típushoz, hátsó lámpa és rendszámtartó",
                   Code = "RUP2",
                   Price = "1040",
               }
               );
        }
    }
}
