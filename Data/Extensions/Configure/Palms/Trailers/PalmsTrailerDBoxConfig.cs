using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerDBoxConfig
    {
        public static void ConfigureMultiplePalmsDBoxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBox>().HasData(
               new DBox
               {
                   Id = 1,
                   Name = "Billenős boksz HARDOX",
                   Code = "Dbox",
                   Price = "2615",
                   ImageUrls = ["PALMS-trailer-dbox-1"]
               }
              );
        }
    }
}
