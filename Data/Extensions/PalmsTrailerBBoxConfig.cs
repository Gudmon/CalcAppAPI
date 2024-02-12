using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerBBoxConfig
    {
        public static void ConfigureMultiplePalmsBBoxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BBox>().HasData(
               new BBox
               {
                   Id = 1,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "2825",
               });
        }
    }
}
