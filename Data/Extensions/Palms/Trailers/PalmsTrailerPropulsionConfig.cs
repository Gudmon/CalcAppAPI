using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
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
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség."
               },
               new Propulsion
               {
                   Id = 2,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7600",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága."
               },
               new Propulsion
               {
                   Id = 3,
                   Name = "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "24WDF",
                   Price = "12885",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 4,
                   Name = "2WD hajtás (BB240 az hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "24WDRe",
                   Price = "11130",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 5,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "4845",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség."
               },
               new Propulsion
               {
                   Id = 6,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7170",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága."
               },
               new Propulsion
               {
                   Id = 7,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "15375",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 8,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "15375",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 9,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "13880",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 10,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "13880",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 11,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz",
                   Code = "45WDB.1",
                   Price = "0",
                   Description = ""
               },
               new Propulsion
               {
                   Id = 12,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "14805",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 13,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "14805",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 14,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "12810",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 15,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "12810",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 16,
                   Name = "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDF",
                   Price = "14450",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 17,
                   Name = "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)",
                   Code = "25WDR",
                   Price = "14450",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 18,
                   Name = "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDFe",
                   Price = "12455",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 19,
                   Name = "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)",
                   Code = "25WDRe",
                   Price = "12455",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen."
               },
               new Propulsion
               {
                   Id = 20,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel",
                   Code = "45WDB",
                   Price = "0",
                   Description = ""
               },
               new Propulsion
               {
                   Id = 21,
                   Name = "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz",
                   Code = "45WDB.1",
                   Price = "1135",
                   Description = ""
               },
               //PALMS 2D
               new Propulsion
               {
                   Id = 22,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "2040",
                   Description = "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség."
               }
               );
        }
    }
}
