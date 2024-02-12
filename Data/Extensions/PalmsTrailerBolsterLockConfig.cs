using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerBolsterLockConfig
    {
        public static void ConfigureMultiplePalmsBolsterLocks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BolsterLock>().HasData(
               new BolsterLock
               {
                   Id = 1,
                   Name = "Rakconca rögzítő az első pár rakoncához",
                   Code = "BL",
                   Price = "0",
               });
        }
    }
}
