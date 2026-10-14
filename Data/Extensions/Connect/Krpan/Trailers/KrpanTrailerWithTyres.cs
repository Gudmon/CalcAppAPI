using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{

    public static class KrpanTrailerWithTyres
    {
        public static void ConnectKrpanTrailersWithTyres(this ModelBuilder modelBuilder)
        {
            // TYRE
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanTyre)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanTyreTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 1, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 1, KrpanTyreId = 7 },
                        new { KrpanTrailerId = 1, KrpanTyreId = 8 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 2, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 2, KrpanTyreId = 7 },
                        new { KrpanTrailerId = 2, KrpanTyreId = 8 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 3, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 3, KrpanTyreId = 7 },
                        new { KrpanTrailerId = 3, KrpanTyreId = 8 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 5 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 10 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 11 },
                        new { KrpanTrailerId = 4, KrpanTyreId = 12 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 5 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 10 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 11 },
                        new { KrpanTrailerId = 5, KrpanTyreId = 12 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 6, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 6, KrpanTyreId = 7 },
                        new { KrpanTrailerId = 6, KrpanTyreId = 8 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 7, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 7, KrpanTyreId = 5 },
                        new { KrpanTrailerId = 7, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 7, KrpanTyreId = 10 },
                        new { KrpanTrailerId = 7, KrpanTyreId = 11 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 8, KrpanTyreId = 3 },
                        new { KrpanTrailerId = 8, KrpanTyreId = 5 },
                        new { KrpanTrailerId = 8, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 8, KrpanTyreId = 10 },
                        new { KrpanTrailerId = 8, KrpanTyreId = 11 },

                        //KRPAN GP 6 XS
                        new { KrpanTrailerId = 9, KrpanTyreId = 1 },
                        new { KrpanTrailerId = 9, KrpanTyreId = 4 },

                        //KRPAN GP 7 XS
                        new { KrpanTrailerId = 10, KrpanTyreId = 1 },
                        new { KrpanTrailerId = 10, KrpanTyreId = 4 },

                        //KRPAN GP 8 XS
                        new { KrpanTrailerId = 11, KrpanTyreId = 1 },
                        new { KrpanTrailerId = 11, KrpanTyreId = 4 },

                        //KRPAN GP 8 S
                        new { KrpanTrailerId = 12, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 12, KrpanTyreId = 4 },
                        new { KrpanTrailerId = 12, KrpanTyreId = 6 },
                        new { KrpanTrailerId = 12, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 12, KrpanTyreId = 9 },

                        //KRPAN GP 9 S
                        new { KrpanTrailerId = 13, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 13, KrpanTyreId = 4 },
                        new { KrpanTrailerId = 13, KrpanTyreId = 6 },
                        new { KrpanTrailerId = 13, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 13, KrpanTyreId = 9 },

                        //KRPAN GP 10 S
                        new { KrpanTrailerId = 14, KrpanTyreId = 2 },
                        new { KrpanTrailerId = 14, KrpanTyreId = 4 },
                        new { KrpanTrailerId = 14, KrpanTyreId = 6 },
                        new { KrpanTrailerId = 14, KrpanTyreId = 8 },
                        new { KrpanTrailerId = 14, KrpanTyreId = 9 }
                    )
                );
        }
    }
}
