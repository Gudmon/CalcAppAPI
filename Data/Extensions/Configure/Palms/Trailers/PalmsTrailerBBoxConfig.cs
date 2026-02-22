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
                   ImageUrls = ["PALMS-trailer-bbox-1", "PALMS-trailer-bbox-2", "PALMS-trailer-bbox-3", "PALMS-trailer-bbox-4", "PALMS-trailer-bbox-5", "PALMS-trailer-bbox-6"],
                   VideoUrls = ["4irHQzQZYHM"]
               },
               new BBox
               {
                   Id = 2,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3150",
                   ImageUrls = ["PALMS-trailer-bbox-1", "PALMS-trailer-bbox-2", "PALMS-trailer-bbox-3", "PALMS-trailer-bbox-4", "PALMS-trailer-bbox-5", "PALMS-trailer-bbox-6"],
                   VideoUrls = ["4irHQzQZYHM"]
               },
               new BBox
               {
                   Id = 3,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3360",
                   ImageUrls = ["PALMS-trailer-bbox-1", "PALMS-trailer-bbox-2", "PALMS-trailer-bbox-3", "PALMS-trailer-bbox-4", "PALMS-trailer-bbox-5", "PALMS-trailer-bbox-6"],
                   VideoUrls = ["4irHQzQZYHM"]
               },
               new BBox
               {
                   Id = 4,
                   Name = "Biomasszás boksz 4 mm-es Strenx acélból",
                   Code = "Bbox",
                   Price = "3200",
                   ImageUrls = ["PALMS-trailer-bbox-1", "PALMS-trailer-bbox-2", "PALMS-trailer-bbox-3", "PALMS-trailer-bbox-4", "PALMS-trailer-bbox-5", "PALMS-trailer-bbox-6"],
                   VideoUrls = ["4irHQzQZYHM"]
               },
               new BBox
               {
                   Id = 5,
                   Name = "Biomasszás boksz 2mm HARDOX",
                   Code = "Bbox",
                   Price = "1000",
                   ImageUrls = ["PALMS-trailer-bbox-1", "PALMS-trailer-bbox-2", "PALMS-trailer-bbox-3", "PALMS-trailer-bbox-4", "PALMS-trailer-bbox-5", "PALMS-trailer-bbox-6"],
                   VideoUrls = ["4irHQzQZYHM"]
               });
        }
    }
}
