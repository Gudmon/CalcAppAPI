using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerCranes
    {
        public static void ConnectKrpanTrailersWithCranes(this ModelBuilder modelBuilder)
        {
            // CRANES
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanCrane)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanCraneTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanCraneId = 1 },
                        new { KrpanTrailerId = 1, KrpanCraneId = 3 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanCraneId = 1 },
                        new { KrpanTrailerId = 2, KrpanCraneId = 3 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanCraneId = 1 },
                        new { KrpanTrailerId = 3, KrpanCraneId = 3 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanCraneId = 2 },
                        new { KrpanTrailerId = 4, KrpanCraneId = 4 },
                        new { KrpanTrailerId = 4, KrpanCraneId = 5 },
                        new { KrpanTrailerId = 4, KrpanCraneId = 6 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanCraneId = 2 },
                        new { KrpanTrailerId = 5, KrpanCraneId = 4 },
                        new { KrpanTrailerId = 5, KrpanCraneId = 5 },
                        new { KrpanTrailerId = 5, KrpanCraneId = 6 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanCraneId = 1 },
                        new { KrpanTrailerId = 6, KrpanCraneId = 2 },
                        new { KrpanTrailerId = 6, KrpanCraneId = 3 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanCraneId = 2 },
                        new { KrpanTrailerId = 7, KrpanCraneId = 4 },
                        new { KrpanTrailerId = 7, KrpanCraneId = 5 },
                        new { KrpanTrailerId = 7, KrpanCraneId = 6 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanCraneId = 2 },
                        new { KrpanTrailerId = 8, KrpanCraneId = 4 },
                        new { KrpanTrailerId = 8, KrpanCraneId = 5 },
                        new { KrpanTrailerId = 8, KrpanCraneId = 6 }
                    )

                );
        }
    }
}
