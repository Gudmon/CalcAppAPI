using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerPropulsionConfig
    {
        public static void ConfigureMultiplePalmsPropulsions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propulsion>().HasData(
               new Propulsion
               {
                   Id = 1,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "5280",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.",
                   ImageUrls = ["PALMS-trailer-propulsion-RWD-RWD+-1", "PALMS-trailer-propulsion-RWD-RWD+-2", "PALMS-trailer-propulsion-RWD-RWD+-3", "PALMS-trailer-propulsion-RWD-RWD+-4"]
               },
               new Propulsion
               {
                   Id = 2,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7600",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.",
                   ImageUrls = ["PALMS-trailer-propulsion-RWD-RWD+-1", "PALMS-trailer-propulsion-RWD-RWD+-2", "PALMS-trailer-propulsion-RWD-RWD+-3", "PALMS-trailer-propulsion-RWD-RWD+-4", "PALMS-trailer-propulsion-electronic"]
               },
               new Propulsion
               {
                   Id = 3,
                   Name = "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "24WDF",
                   Price = "13200",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 4,
                   Name = "2WD hajtás (BB240 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "24WDRe",
                   Price = "11445",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 5,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "4845",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.",
                   ImageUrls = ["PALMS-trailer-propulsion-RWD-RWD+-1", "PALMS-trailer-propulsion-RWD-RWD+-2", "PALMS-trailer-propulsion-RWD-RWD+-3", "PALMS-trailer-propulsion-RWD-RWD+-4"]
               },
               new Propulsion
               {
                   Id = 6,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7170",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.",
                   ImageUrls = ["PALMS-trailer-propulsion-RWD-RWD+-1", "PALMS-trailer-propulsion-RWD-RWD+-2", "PALMS-trailer-propulsion-RWD-RWD+-3", "PALMS-trailer-propulsion-RWD-RWD+-4", "PALMS-trailer-propulsion-electronic"]
               },
               new Propulsion
               {
                   Id = 7,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "15585",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 8,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "15585",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 9,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "13590",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 10,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "13590",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 11,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz",
                   Code = "45WDB.1",
                   Price = "0",
                   Description = "",
                   ImageUrls = ["PALMS-trailer-propulsion-4WD", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"]
               },
               new Propulsion
               {
                   Id = 12,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "15015",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 13,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "15015",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 14,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "13020",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 15,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "13020",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 16,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "14660",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 17,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "14660",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 18,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "12665",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDF", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 19,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "12665",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.",
                   ImageUrls = ["PALMS-trailer-propulsion-2WDR", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
                   VideoUrls = ["LKj7YS_M13E"]
               },
               new Propulsion
               {
                   Id = 20,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel",
                   Code = "45WDB",
                   Price = "0",
                   Description = "",
                   ImageUrls = ["PALMS-trailer-propulsion-4WD", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"],
               },
               new Propulsion
               {
                   Id = 21,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz",
                   Code = "45WDB.1",
                   Price = "1135",
                   Description = "",
                   ImageUrls = ["PALMS-trailer-propulsion-4WD", "PALMS-trailer-propulsion-2WD-4WD-1", "PALMS-trailer-propulsion-2WD-4WD-2"]
               },
               //PALMS 2D
               new Propulsion
               {
                   Id = 22,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "2185",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.",
                   ImageUrls = ["PALMS-trailer-propulsion-RWD-RWD+-1", "PALMS-trailer-propulsion-RWD-RWD+-2", "PALMS-trailer-propulsion-RWD-RWD+-3", "PALMS-trailer-propulsion-RWD-RWD+-4"]
               }
               );
        }
    }
}
