using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerToolboxConfig
    {
        public static void ConfigureMultiplePalmsToolboxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Toolbox>().HasData(
               new Toolbox
               {
                   Id = 1,
                   Name = "Palms szerszámláda",
                   Code = "TB1",
                   Price = "185",
                   ImageUrls = ["PALMS-trailer-toolbox-1", "PALMS-trailer-toolbox-2", "PALMS-trailer-toolbox-3", "PALMS-trailer-toolbox-4", "PALMS-trailer-toolbox-5", "PALMS-trailer-toolbox-6", "PALMS-trailer-toolbox-7"]
               }
              );
        }
    }
}
