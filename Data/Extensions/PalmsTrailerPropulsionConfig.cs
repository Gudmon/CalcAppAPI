using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
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
               new Stanchion
               {
                   Id = 2,
                   Name = "Robson WD dörzshajtás elektronikus vezérlőrendszerrel",
                   Code = "RWD+",
                   Price = "7600",
               }
               );
        }
    }
}
