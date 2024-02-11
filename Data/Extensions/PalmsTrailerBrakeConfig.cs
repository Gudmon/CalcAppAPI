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
               }
               );
        }
    }
}
