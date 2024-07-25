using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithPropulsions
    {
        public static void ConnectKrpanTrailersWithPropulsions(this ModelBuilder modelBuilder)
        {
            // PROPULSION
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanPropulsion)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanPropulsionTrailer")
                    .HasData
                    (
                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanPropulsionId = 1 },
                        new { KrpanTrailerId = 4, KrpanPropulsionId = 2 },
                        new { KrpanTrailerId = 4, KrpanPropulsionId = 3 },
                        new { KrpanTrailerId = 4, KrpanPropulsionId = 4 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanPropulsionId = 1 },
                        new { KrpanTrailerId = 5, KrpanPropulsionId = 2 },
                        new { KrpanTrailerId = 5, KrpanPropulsionId = 3 },
                        new { KrpanTrailerId = 5, KrpanPropulsionId = 4 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanPropulsionId = 1 },
                        new { KrpanTrailerId = 6, KrpanPropulsionId = 2 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanPropulsionId = 1 },
                        new { KrpanTrailerId = 7, KrpanPropulsionId = 2 },
                        new { KrpanTrailerId = 7, KrpanPropulsionId = 3 },
                        new { KrpanTrailerId = 7, KrpanPropulsionId = 4 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanPropulsionId = 1 },
                        new { KrpanTrailerId = 8, KrpanPropulsionId = 2 },
                        new { KrpanTrailerId = 8, KrpanPropulsionId = 3 },
                        new { KrpanTrailerId = 8, KrpanPropulsionId = 4 }
                    )
                );
        }
    }
}
