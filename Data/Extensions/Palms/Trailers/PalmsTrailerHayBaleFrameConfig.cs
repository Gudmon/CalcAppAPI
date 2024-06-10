using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerHayBaleFrameConfig
    {
        public static void ConfigureMultiplePalmsHayBaleFrames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HayBaleFrame>().HasData(
               new HayBaleFrame
               {
                   Id = 1,
                   Name = "Széna bála keret (D típushoz)",
                   Code = "HBF",
                   Price = "2650",
               },
               new HayBaleFrame
               {
                   Id = 2,
                   Name = "Széna bála keret (U típushoz)",
                   Code = "HBF",
                   Price = "2650",
               }
               );
        }
    }
}
