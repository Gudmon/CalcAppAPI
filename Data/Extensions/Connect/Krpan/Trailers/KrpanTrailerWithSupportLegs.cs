using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithSupportLegs
    {
        public static void ConnectKrpanTrailerWithSupportLegs(this ModelBuilder modelBuilder)
        {
            // TYRE
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanTrailerSupportLegs)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanSupportLegsTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 1, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 2, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 3, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 4, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 5, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 6, KrpanTrailerSupportLegsId  = 3 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 7, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanTrailerSupportLegsId = 2 },
                        new { KrpanTrailerId = 8, KrpanTrailerSupportLegsId = 3 },

                        //KRPAN GP 6 XS
                        new { KrpanTrailerId = 9, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 9, KrpanTrailerSupportLegsId = 2 },

                        //KRPAN GP 7 XS
                        new { KrpanTrailerId = 10, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 10, KrpanTrailerSupportLegsId = 2 },

                        //KRPAN GP 8 XS
                        new { KrpanTrailerId = 11, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 11, KrpanTrailerSupportLegsId = 2 },

                        //KRPAN GP 8 S
                        new { KrpanTrailerId = 12, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 12, KrpanTrailerSupportLegsId = 2 },

                        //KRPAN GP 9 S
                        new { KrpanTrailerId = 13, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 13, KrpanTrailerSupportLegsId = 2 },

                        //KRPAN GP 10 S
                        new { KrpanTrailerId = 14, KrpanTrailerSupportLegsId = 1 },
                        new { KrpanTrailerId = 14, KrpanTrailerSupportLegsId = 2 }
                    )
                );
        }
    }
}
