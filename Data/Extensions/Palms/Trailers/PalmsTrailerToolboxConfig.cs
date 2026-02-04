using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
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
               }
              );
        }
    }
}
