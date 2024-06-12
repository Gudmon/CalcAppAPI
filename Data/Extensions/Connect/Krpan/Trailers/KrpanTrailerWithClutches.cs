using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithClutches
    {
        public static void ConnectKrpanTrailersWithClutches(this ModelBuilder modelBuilder)
        {
            // BRAKE
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanClutch)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanClutchTrailer")
                    .HasData
                    (
                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanClutchId = 1 },
                        new { KrpanTrailerId = 6, KrpanClutchId = 2 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanClutchId = 1 },
                        new { KrpanTrailerId = 7, KrpanClutchId = 2 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanClutchId = 1 },
                        new { KrpanTrailerId = 8, KrpanClutchId = 2 }
                    )
                );
        }
    }
}
