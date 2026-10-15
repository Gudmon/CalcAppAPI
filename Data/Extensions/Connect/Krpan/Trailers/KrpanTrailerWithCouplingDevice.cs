using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithCouplingDevice
    {
        public static void ConnectKrpanTrailersWithCouplingDevices(this ModelBuilder modelBuilder)
        {
            // DRAWBAR
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanTrailerCouplingDevice)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanTrailerCouplingDeviceTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 1, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 2, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 3, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 4, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 5, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 6, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 7, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 8, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 6 XS
                        new { KrpanTrailerId = 9, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 9, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 7 XS
                        new { KrpanTrailerId = 10, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 10, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 8 XS
                        new { KrpanTrailerId = 11, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 11, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 8 S
                        new { KrpanTrailerId = 12, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 12, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 9 S
                        new { KrpanTrailerId = 13, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 13, KrpanTrailerCouplingDeviceId = 2 },

                        //KRPAN GP 10 S
                        new { KrpanTrailerId = 14, KrpanTrailerCouplingDeviceId = 1 },
                        new { KrpanTrailerId = 14, KrpanTrailerCouplingDeviceId = 2 }
                    )
                );
        }
    }
}
