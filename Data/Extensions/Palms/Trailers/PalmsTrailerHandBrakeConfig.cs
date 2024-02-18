using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerHandBrakeConfig
    {
        public static void ConfigureMultiplePalmsHandBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HandBrake>().HasData(
               new HandBrake
               {
                   Id = 1,
                   Name = "Kézifék, kerékről működtethető",
                   Code = "PB1",
                   Price = "105",
               });
        }
    }
}
