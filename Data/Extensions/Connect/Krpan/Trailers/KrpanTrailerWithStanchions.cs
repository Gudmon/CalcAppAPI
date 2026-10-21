using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithStanchions
    {
        public static void ConnectKrpanTrailersWithStanchions(this ModelBuilder modelBuilder)
        {
            // STANCHIONS
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanStanchions)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanStanchionTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 1, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 1, KrpanStanchionsId = 4 },
                        new { KrpanTrailerId = 1, KrpanStanchionsId = 5 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 2, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 2, KrpanStanchionsId = 4 },
                        new { KrpanTrailerId = 2, KrpanStanchionsId = 5 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 3, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 3, KrpanStanchionsId = 4 },
                        new { KrpanTrailerId = 3, KrpanStanchionsId = 5 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 4, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 4, KrpanStanchionsId = 6 },
                        new { KrpanTrailerId = 4, KrpanStanchionsId = 7 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 5, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 5, KrpanStanchionsId = 6 },
                        new { KrpanTrailerId = 5, KrpanStanchionsId = 7 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 6, KrpanStanchionsId = 3 },
                        new { KrpanTrailerId = 6, KrpanStanchionsId = 4 },
                        new { KrpanTrailerId = 6, KrpanStanchionsId = 5 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanStanchionsId = 8 },
                        new { KrpanTrailerId = 7, KrpanStanchionsId = 9 },
                        new { KrpanTrailerId = 7, KrpanStanchionsId = 10 },
                        new { KrpanTrailerId = 7, KrpanStanchionsId = 11 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanStanchionsId = 8 },
                        new { KrpanTrailerId = 8, KrpanStanchionsId = 9 },
                        new { KrpanTrailerId = 8, KrpanStanchionsId = 10 },
                        new { KrpanTrailerId = 8, KrpanStanchionsId = 11 },

                        //KRPAN GP 6 XS
                        new { KrpanTrailerId = 9, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 9, KrpanStanchionsId = 2 },

                        //KRPAN GP 7 XS
                        new { KrpanTrailerId = 10, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 10, KrpanStanchionsId = 2 },

                        //KRPAN GP 8 XS
                        new { KrpanTrailerId = 11, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 11, KrpanStanchionsId = 2 },

                        //KRPAN GP 8 S
                        new { KrpanTrailerId = 12, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 12, KrpanStanchionsId = 2 },

                        //KRPAN GP 9 S
                        new { KrpanTrailerId = 13, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 13, KrpanStanchionsId = 2 },

                        //KRPAN GP 10 S
                        new { KrpanTrailerId = 14, KrpanStanchionsId = 1 },
                        new { KrpanTrailerId = 14, KrpanStanchionsId = 2 }
                    )
                );
        }
    }
}
