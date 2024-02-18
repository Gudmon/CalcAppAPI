using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerChainsawHolderConfig
    {
        public static void ConfigureMultiplePalmsChainsawHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChainsawHolder>().HasData(
               new ChainsawHolder
               {
                   Id = 1,
                   Name = "Láncfűrész tartó",
                   Code = "MSH",
                   Price = "65",
               });
        }
    }
}
