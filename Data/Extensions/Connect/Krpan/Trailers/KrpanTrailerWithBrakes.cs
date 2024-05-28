using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithBrakes
    {
        public static void ConnectKrpanTrailersWithBrakes(this ModelBuilder modelBuilder)
        {
            // BRAKE
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanBrake)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanBrakeTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 1, KrpanBrakeId = 2 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 2, KrpanBrakeId = 2 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 3, KrpanBrakeId = 2 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 4, KrpanBrakeId = 2 },
                        new { KrpanTrailerId = 4, KrpanBrakeId = 3 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 5, KrpanBrakeId = 2 },
                        new { KrpanTrailerId = 5, KrpanBrakeId = 3 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 6, KrpanBrakeId = 2 },
                        new { KrpanTrailerId = 6, KrpanBrakeId = 4 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 7, KrpanBrakeId = 2 },
                        new { KrpanTrailerId = 7, KrpanBrakeId = 4 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanBrakeId = 1 },
                        new { KrpanTrailerId = 8, KrpanBrakeId = 2 },
                        new { KrpanTrailerId = 8, KrpanBrakeId = 4 }
                    )
                );
        }
    }
}
