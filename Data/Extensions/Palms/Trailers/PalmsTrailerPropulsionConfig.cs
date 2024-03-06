﻿using CalcAppAPI.Models.Machine.Configurations.Trailers;
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
                   Name = "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel)",
                   Code = "25WDF",
                   Price = "0",
                   Description = "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen."
               },
               new Propulsion
               {
                   Id = 4,
                   Name = "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel)",
                   Code = "25WDR",
                   Price = "0",
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
               }
               );
        }
    }
}
