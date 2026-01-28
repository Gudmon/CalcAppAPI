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
                   Name = "Szénabála keret (D típushoz)",
                   Code = "HBF",
                   Price = "2785",
               },
               new HayBaleFrame
               {
                   Id = 2,
                   Name = "Szénabála keret (U típushoz)",
                   Code = "HBF",
                   Price = "2785",
               }
               );
        }
    }
}
