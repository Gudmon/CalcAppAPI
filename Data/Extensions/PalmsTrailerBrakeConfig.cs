using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerBrakeConfig
    {
        public static void ConfigureMultiplePalmsBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brake>().HasData(
               new Brake
               {
                   Id = 1,
                   Name = "Fék nélkül",
                   Code = "B0",
                   Price = "0",
               },
               new Brake
               {
                   Id = 2,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "960",
               },
               new Brake
               {
                   Id = 3,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "1810",
               },
               new Brake
               {
                   Id = 4,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1615",
               },
               new Brake
               {
                   Id = 5,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "2640",
               },
               new Brake
               {
                   Id = 6,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "2095",
               },
               new Brake
               {
                   Id = 7,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "3450",
               }
               );
        }
    }
}
