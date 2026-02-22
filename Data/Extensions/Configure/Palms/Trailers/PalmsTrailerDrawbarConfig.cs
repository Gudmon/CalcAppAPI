using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerDrawbarConfig
    {
        public static void ConfigureMultiplePalmsDrawbars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drawbar>().HasData(
               new Drawbar
               {
                   Id = 1,
                   Name = "Skandináv típusú forgó vonórúd",
                   Code = "C1",
                   Price = "0",
                   ImageUrls = ["PALMS-trailer-drawbar-C1"]
               },
               new Drawbar
               {
                   Id = 2,
                   Name = "Német típusú magas vonórúd vonószem nélkül",
                   Code = "C2",
                   Price = "0",
                   ImageUrls = ["PALMS-trailer-drawbar-C2"]
               },
               new Drawbar
               {
                   Id = 3,
                   Name = "Osztrák típusú alacsony vonórúd vonószem nélkül",
                   Code = "C3",
                   Price = "0",
                   ImageUrls = ["PALMS-trailer-drawbar-C3"]
               },
               new Drawbar
               {
                   Id = 4,
                   Name = "Német típusú magas vonórúd vonószemmel",
                   Code = "C4",
                   Price = "275",
                   ImageUrls = ["PALMS-trailer-drawbar-C4"]
               },
               new Drawbar
               {
                   Id = 5,
                   Name = "Osztrák típusú alacsony vonórúd vonószemmel",
                   Code = "C5",
                   Price = "275",
                   ImageUrls = ["PALMS-trailer-drawbar-C5"]
               },
               new Drawbar
               {
                   Id = 6,
                   Name = "Német típusú magas vonórúd vonószemmel (P1-P3 szivattyúhoz)",
                   Code = "C6",
                   Price = "430",
                   ImageUrls = ["PALMS-trailer-drawbar-C6"]
               },
               new Drawbar
               {
                   Id = 7,
                   Name = "Magas ráfutófékes vonórúd vonószemmel, kábelekkel és 2 kerék fékkel",
                   Code = "C7",
                   Price = "1675",
                   ImageUrls = ["PALMS-trailer-drawbar-C7"]
               },
               new Drawbar
               {
                   Id = 8,
                   Name = "K-80 típusú alacsony vonórúd vonószemmel",
                   Code = "C8",
                   Price = "470",
                   ImageUrls = ["PALMS-trailer-drawbar-C8"]
               },
               new Drawbar
               {
                   Id = 9,
                   Name = "Osztrák típusú alacsony vonórúd elforduló vonószemmel",
                   Code = "C9",
                   Price = "525",
                   ImageUrls = ["PALMS-trailer-drawbar-C9"]
               },

               new Drawbar
               {
                   Id = 10,
                   Name = "Osztrák típusú alacsony vonórúd vonószemmel",
                   Code = "C5",
                   Price = "315",
                   ImageUrls = ["PALMS-trailer-drawbar-C5"]
               },
               new Drawbar
               {
                   Id = 11,
                   Name = "K-80 típusú alacsony vonórúd vonószemmel",
                   Code = "C8",
                   Price = "535",
                   ImageUrls = ["PALMS-trailer-drawbar-C8"]
               },
               new Drawbar
               {
                   Id = 12,
                   Name = "Osztrák típusú alacsony vonórúd elforduló vonószemmel",
                   Code = "C9",
                   Price = "500",
                   ImageUrls = ["PALMS-trailer-drawbar-C9"]
               },
               new Drawbar
               {
                   Id = 13,
                   Name = "Y vonórúd Jake rögzítő csatlakozókkal (Valtra-hoz, egyéb traktorokhoz igény szerint) elektromos vezérléssel",
                   Code = "CY",
                   Price = "8500",
                   ImageUrls = ["PALMS-trailer-drawbar-CY"]
               },
               new Drawbar
               {
                   Id = 14,
                   Name = "Normál típusú vonórúd K50-es vonófejjel",
                   Code = "C1",
                   Price = "0",
                   ImageUrls = ["PALMS-trailer-drawbar-C1"]
               },
               new Drawbar
               {
                   Id = 15,
                   Name = "Normál típusú vonórúd D35-ös vonófejjel",
                   Code = "C1.1",
                   Price = "0",
               }
               );
        }
    }
}
