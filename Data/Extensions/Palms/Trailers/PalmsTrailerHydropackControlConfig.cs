using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerHydropackControlConfig
    {
        public static void ConfigureMultiplePalmsHydropackControls(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydroPackControl>().HasData(
               new HydroPackControl
               {
                   Id = 1,
                   Name = "Elektronikus pótkocsi kontrol (dörzshajtáshoz és vonórúdhoz) + csörlő control",
                   Code = "ETC",
                   Price = "410",
               }
              );
        }
    }
}
