using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithOilTanks
    {
        public static void ConnectTrailersWithOilTanks(this ModelBuilder modelBuilder)
        {
            // OIL TANKS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.OilTank)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("OilTankTrailer")
                    .HasData
                    (
                        new { TrailerId = 2, OilTankId = 1 },
                        new { TrailerId = 2, OilTankId = 2 },
                        new { TrailerId = 2, OilTankId = 3 },
                        new { TrailerId = 2, OilTankId = 4 },


                        new { TrailerId = 3, OilTankId = 1 },
                        new { TrailerId = 3, OilTankId = 2 },
                        new { TrailerId = 3, OilTankId = 3 },
                        new { TrailerId = 3, OilTankId = 4 },

                        new { TrailerId = 4, OilTankId = 1 },
                        new { TrailerId = 4, OilTankId = 2 },
                        new { TrailerId = 4, OilTankId = 3 },
                        new { TrailerId = 4, OilTankId = 4 },


                        new { TrailerId = 5, OilTankId = 1 },
                        new { TrailerId = 5, OilTankId = 2 },
                        new { TrailerId = 5, OilTankId = 3 },
                        new { TrailerId = 5, OilTankId = 4 },

                        new { TrailerId = 6, OilTankId = 1 },
                        new { TrailerId = 6, OilTankId = 2 },
                        new { TrailerId = 6, OilTankId = 3 },
                        new { TrailerId = 6, OilTankId = 4 },


                        new { TrailerId = 7, OilTankId = 1 },
                        new { TrailerId = 7, OilTankId = 2 },
                        new { TrailerId = 7, OilTankId = 3 },
                        new { TrailerId = 7, OilTankId = 4 },

                        new { TrailerId = 8, OilTankId = 1 },
                        new { TrailerId = 8, OilTankId = 2 },
                        new { TrailerId = 8, OilTankId = 3 },
                        new { TrailerId = 8, OilTankId = 4 },


                        new { TrailerId = 9, OilTankId = 1 },
                        new { TrailerId = 9, OilTankId = 2 },
                        new { TrailerId = 9, OilTankId = 3 },
                        new { TrailerId = 9, OilTankId = 4 },

                        new { TrailerId = 10, OilTankId = 1 },
                        new { TrailerId = 10, OilTankId = 2 },
                        new { TrailerId = 10, OilTankId = 3 },
                        new { TrailerId = 10, OilTankId = 4 },


                        new { TrailerId = 11, OilTankId = 1 },
                        new { TrailerId = 11, OilTankId = 2 },
                        new { TrailerId = 11, OilTankId = 3 },
                        new { TrailerId = 11, OilTankId = 4 }
                    )

                );
        }

    }
}
