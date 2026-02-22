using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerHayBaleFrameConfig
    {
        public static void ConfigureMultiplePalmsHayBaleFrames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HayBaleFrame>().HasData(
               new HayBaleFrame
               {
                   Id = 1,
                   Name = "Szénabála keret (D típushoz)",
                   Code = "HBF",
                   Price = "2785",
                   ImageUrls = ["PALMS-trailer-hay-bale-frame-1", "PALMS-trailer-hay-bale-frame-2", "PALMS-trailer-hay-bale-frame-3", "PALMS-trailer-hay-bale-frame-d"]
               },
               new HayBaleFrame
               {
                   Id = 2,
                   Name = "Szénabála keret (U típushoz)",
                   Code = "HBF",
                   Price = "2785",
                   ImageUrls = ["PALMS-trailer-hay-bale-frame-1", "PALMS-trailer-hay-bale-frame-2", "PALMS-trailer-hay-bale-frame-3", "PALMS-trailer-hay-bale-frame-u"]
               }
               );
        }
    }
}
