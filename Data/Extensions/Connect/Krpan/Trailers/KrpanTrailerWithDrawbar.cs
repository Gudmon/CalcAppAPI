using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithDrawbar
    {
        public static void ConnectKrpanTrailersWithDrawbars(this ModelBuilder modelBuilder)
        {
            // DRAWBAR
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanDrawbar)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanDrawbarTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 4 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 4 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 4 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 4 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 4 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 6, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 6, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 6, KrpanDrawbarId = 4 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 7, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 7, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 7, KrpanDrawbarId = 4 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 8, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 8, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 8, KrpanDrawbarId = 4 },

                        //KRPAN GP 6 XS
                        new { KrpanTrailerId = 9, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 9, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 9, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 9, KrpanDrawbarId = 4 },

                        //KRPAN GP 7 XS
                        new { KrpanTrailerId = 10, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 10, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 10, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 10, KrpanDrawbarId = 4 },

                        //KRPAN GP 8 XS
                        new { KrpanTrailerId = 11, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 11, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 11, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 11, KrpanDrawbarId = 4 },

                        //KRPAN GP 8 S
                        new { KrpanTrailerId = 12, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 12, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 12, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 12, KrpanDrawbarId = 4 },

                        //KRPAN GP 9 S
                        new { KrpanTrailerId = 13, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 13, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 13, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 13, KrpanDrawbarId = 4 },

                        //KRPAN GP 10 S
                        new { KrpanTrailerId = 14, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 14, KrpanDrawbarId = 2 },
                        new { KrpanTrailerId = 14, KrpanDrawbarId = 3 },
                        new { KrpanTrailerId = 14, KrpanDrawbarId = 4 }
                    )
                );
        }
    }
}
