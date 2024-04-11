using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithOilPumps
    {
        public static void ConnectTrailersWithOilPumps(this ModelBuilder modelBuilder)
        {
            // OIL PUMPS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.OilPump)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("OilPumpTrailer")
                    .HasData
                    (
                        new { TrailerId = 2, OilPumpId = 1 },
                        new { TrailerId = 2, OilPumpId = 2 },
                        new { TrailerId = 2, OilPumpId = 3 },
                        new { TrailerId = 2, OilPumpId = 4 },
                        new { TrailerId = 2, OilPumpId = 5 },
                        new { TrailerId = 2, OilPumpId = 6 },
                        new { TrailerId = 2, OilPumpId = 7 },


                        new { TrailerId = 3, OilPumpId = 1 },
                        new { TrailerId = 3, OilPumpId = 2 },
                        new { TrailerId = 3, OilPumpId = 3 },
                        new { TrailerId = 3, OilPumpId = 4 },
                        new { TrailerId = 3, OilPumpId = 5 },
                        new { TrailerId = 3, OilPumpId = 6 },
                        new { TrailerId = 3, OilPumpId = 7 },

                        new { TrailerId = 4, OilPumpId = 1 },
                        new { TrailerId = 4, OilPumpId = 2 },
                        new { TrailerId = 4, OilPumpId = 3 },
                        new { TrailerId = 4, OilPumpId = 4 },
                        new { TrailerId = 4, OilPumpId = 5 },
                        new { TrailerId = 4, OilPumpId = 6 },
                        new { TrailerId = 4, OilPumpId = 7 },

                        new { TrailerId = 5, OilPumpId = 1 },
                        new { TrailerId = 5, OilPumpId = 2 },
                        new { TrailerId = 5, OilPumpId = 3 },
                        new { TrailerId = 5, OilPumpId = 4 },
                        new { TrailerId = 5, OilPumpId = 5 },
                        new { TrailerId = 5, OilPumpId = 6 },
                        new { TrailerId = 5, OilPumpId = 7 },

                        new { TrailerId = 6, OilPumpId = 1 },
                        new { TrailerId = 6, OilPumpId = 2 },
                        new { TrailerId = 6, OilPumpId = 3 },
                        new { TrailerId = 6, OilPumpId = 4 },
                        new { TrailerId = 6, OilPumpId = 5 },
                        new { TrailerId = 6, OilPumpId = 6 },
                        new { TrailerId = 6, OilPumpId = 7 },

                        new { TrailerId = 7, OilPumpId = 1 },
                        new { TrailerId = 7, OilPumpId = 2 },
                        new { TrailerId = 7, OilPumpId = 3 },
                        new { TrailerId = 7, OilPumpId = 4 },
                        new { TrailerId = 7, OilPumpId = 5 },
                        new { TrailerId = 7, OilPumpId = 6 },
                        new { TrailerId = 7, OilPumpId = 7 },

                        new { TrailerId = 8, OilPumpId = 1 },
                        new { TrailerId = 8, OilPumpId = 2 },
                        new { TrailerId = 8, OilPumpId = 3 },
                        new { TrailerId = 8, OilPumpId = 4 },
                        new { TrailerId = 8, OilPumpId = 5 },
                        new { TrailerId = 8, OilPumpId = 6 },
                        new { TrailerId = 8, OilPumpId = 7 },

                        new { TrailerId = 9, OilPumpId = 1 },
                        new { TrailerId = 9, OilPumpId = 2 },
                        new { TrailerId = 9, OilPumpId = 3 },
                        new { TrailerId = 9, OilPumpId = 4 },
                        new { TrailerId = 9, OilPumpId = 5 },
                        new { TrailerId = 9, OilPumpId = 6 },
                        new { TrailerId = 9, OilPumpId = 7 },

                        new { TrailerId = 10, OilPumpId = 1 },
                        new { TrailerId = 10, OilPumpId = 2 },
                        new { TrailerId = 10, OilPumpId = 3 },
                        new { TrailerId = 10, OilPumpId = 4 },
                        new { TrailerId = 10, OilPumpId = 5 },
                        new { TrailerId = 10, OilPumpId = 6 },
                        new { TrailerId = 10, OilPumpId = 7 },

                        new { TrailerId = 11, OilPumpId = 1 },
                        new { TrailerId = 11, OilPumpId = 2 },
                        new { TrailerId = 11, OilPumpId = 3 },
                        new { TrailerId = 11, OilPumpId = 4 },
                        new { TrailerId = 11, OilPumpId = 5 },
                        new { TrailerId = 11, OilPumpId = 6 },
                        new { TrailerId = 11, OilPumpId = 7 },

                        new { TrailerId = 12, OilPumpId = 1 },
                        new { TrailerId = 12, OilPumpId = 2 },
                        new { TrailerId = 12, OilPumpId = 3 },
                        new { TrailerId = 12, OilPumpId = 4 },
                        new { TrailerId = 12, OilPumpId = 5 },
                        new { TrailerId = 12, OilPumpId = 6 },
                        new { TrailerId = 12, OilPumpId = 7 },

                        new { TrailerId = 13, OilPumpId = 1 },
                        new { TrailerId = 13, OilPumpId = 3 },
                        new { TrailerId = 13, OilPumpId = 4 },
                        new { TrailerId = 13, OilPumpId = 5 },
                        new { TrailerId = 13, OilPumpId = 6 },
                        new { TrailerId = 13, OilPumpId = 7 },

                        new { TrailerId = 14, OilPumpId = 1 },
                        new { TrailerId = 14, OilPumpId = 2 },
                        new { TrailerId = 14, OilPumpId = 3 },
                        new { TrailerId = 14, OilPumpId = 4 },
                        new { TrailerId = 14, OilPumpId = 5 },
                        new { TrailerId = 14, OilPumpId = 6 },
                        new { TrailerId = 14, OilPumpId = 7 },

                        new { TrailerId = 15, OilPumpId = 1 },
                        new { TrailerId = 15, OilPumpId = 3 },
                        new { TrailerId = 15, OilPumpId = 4 },
                        new { TrailerId = 15, OilPumpId = 5 },
                        new { TrailerId = 15, OilPumpId = 6 },
                        new { TrailerId = 15, OilPumpId = 7 },

                        new { TrailerId = 16, OilPumpId = 1 },
                        new { TrailerId = 16, OilPumpId = 4 },
                        new { TrailerId = 16, OilPumpId = 5 },
                        new { TrailerId = 16, OilPumpId = 6 },
                        new { TrailerId = 16, OilPumpId = 7 },

                        new { TrailerId = 17, OilPumpId = 1 },
                        new { TrailerId = 17, OilPumpId = 2 },
                        new { TrailerId = 17, OilPumpId = 3 },
                        new { TrailerId = 17, OilPumpId = 4 },
                        new { TrailerId = 17, OilPumpId = 5 },
                        new { TrailerId = 17, OilPumpId = 6 },
                        new { TrailerId = 17, OilPumpId = 7 },

                        new { TrailerId = 18, OilPumpId = 1 },
                        new { TrailerId = 18, OilPumpId = 3 },
                        new { TrailerId = 18, OilPumpId = 4 },
                        new { TrailerId = 18, OilPumpId = 5 },
                        new { TrailerId = 18, OilPumpId = 6 },
                        new { TrailerId = 18, OilPumpId = 7 },

                        new { TrailerId = 19, OilPumpId = 1 },
                        new { TrailerId = 19, OilPumpId = 4 },
                        new { TrailerId = 19, OilPumpId = 5 },
                        new { TrailerId = 19, OilPumpId = 6 },
                        new { TrailerId = 19, OilPumpId = 7 },

                        new { TrailerId = 22, OilPumpId = 8 },

                        new { TrailerId = 23, OilPumpId = 8 }
                    )
                );
        }
    }
}
