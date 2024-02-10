using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerStanchionConfig
    {
        public static void ConfigureMultiplePalmsStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stanchion>().HasData(
               new Stanchion
               {
                   Id = 1,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "5285",
               },
               new Stanchion
               {
                   Id = 2,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "5800",
               }
               );
        }
    }
}
