using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
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
               },
               new BBox
               {
                   Id = 2,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3150",
               },
               new BBox
               {
                   Id = 3,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3360",
               },
               new BBox
               {
                   Id = 4,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3200",
               },
               new BBox
               {
                   Id = 5,
                   Name = "Biomasszás boksz 2mm HARDOX",
                   Code = "Bbox",
                   Price = "1000",
               }
               );
        }
    }
}
