using CalcAppAPI.Models.Machine.Configurations.Trailers;
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
               },
               new Propulsion
               {
                   Id = 2,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7600",
               },

               new Propulsion
               {
                   Id = 3,
                   Name = "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel",
                   Code = "25WDF",
                   Price = "0",
               },
               new Propulsion
               {
                   Id = 4,
                   Name = "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel",
                   Code = "25WDR",
                   Price = "0",
               },

               new Propulsion
               {
                   Id = 5,
                   Name = "Robson WD dörzshajtás (traktor hidarulikáról)",
                   Code = "RWD",
                   Price = "4845",
               },
               new Propulsion
               {
                   Id = 6,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7170",
               }
               );
        }
    }
}
