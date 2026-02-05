using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanClutchConfig
    {
        public static void ConfigureMultipleKrpanClutches(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanClutch>().HasData(
                new KrpanClutch
                {
                    Id = 1,
                    Name = "Alsó tengelykapcsoló",
                    Code = "",
                    Price = "0",
                },
                new KrpanClutch
                {
                    Id = 2,
                    Name = "Felső tengelykapcsoló (a felső tengelykapcsoló és a kétkörös öntöttvas tandem szivattyú kombinációja nem lehetséges)",
                    Code = "",
                    Price = "145",
                }
                );
        }
    }
}
