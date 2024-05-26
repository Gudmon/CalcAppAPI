using CalcAppAPI.Models.Machine.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanTrailerConfig
    {
        public static void ConfigureMultipleKrpanTrailers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailer>().HasData(
                new KrpanTrailer
                {
                    Id = 1,
                    Name = "Krpan GP 11 D",
                    Description = "",
                    Price = "",
                }
                );
        }
    }
}
