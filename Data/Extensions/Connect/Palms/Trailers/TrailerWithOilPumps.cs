using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
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
                        //PALMS 8SX
                        new { TrailerId = 2, OilPumpId = 1 },
                        new { TrailerId = 2, OilPumpId = 2 },
                        new { TrailerId = 2, OilPumpId = 3 },
                        new { TrailerId = 2, OilPumpId = 4 },
                        new { TrailerId = 2, OilPumpId = 5 },
                        new { TrailerId = 2, OilPumpId = 6 },
                        new { TrailerId = 2, OilPumpId = 7 },

                        //PALMS 8D
                        new { TrailerId = 3, OilPumpId = 1 },
                        new { TrailerId = 3, OilPumpId = 2 },
                        new { TrailerId = 3, OilPumpId = 3 },
                        new { TrailerId = 3, OilPumpId = 4 },
                        new { TrailerId = 3, OilPumpId = 5 },
                        new { TrailerId = 3, OilPumpId = 6 },
                        new { TrailerId = 3, OilPumpId = 7 },

                        //PALMS 9SC
                        new { TrailerId = 4, OilPumpId = 1 },
                        new { TrailerId = 4, OilPumpId = 2 },
                        new { TrailerId = 4, OilPumpId = 3 },
                        new { TrailerId = 4, OilPumpId = 4 },
                        new { TrailerId = 4, OilPumpId = 5 },
                        new { TrailerId = 4, OilPumpId = 6 },
                        new { TrailerId = 4, OilPumpId = 7 },

                        //PALMS 10D
                        new { TrailerId = 5, OilPumpId = 1 },
                        new { TrailerId = 5, OilPumpId = 2 },
                        new { TrailerId = 5, OilPumpId = 3 },
                        new { TrailerId = 5, OilPumpId = 4 },
                        new { TrailerId = 5, OilPumpId = 5 },
                        new { TrailerId = 5, OilPumpId = 6 },
                        new { TrailerId = 5, OilPumpId = 7 },

                        //PALMS 12D
                        new { TrailerId = 6, OilPumpId = 1 },
                        new { TrailerId = 6, OilPumpId = 2 },
                        new { TrailerId = 6, OilPumpId = 3 },
                        new { TrailerId = 6, OilPumpId = 4 },
                        new { TrailerId = 6, OilPumpId = 5 },
                        new { TrailerId = 6, OilPumpId = 6 },
                        new { TrailerId = 6, OilPumpId = 7 },

                        //PALMS 14D
                        new { TrailerId = 7, OilPumpId = 1 },
                        new { TrailerId = 7, OilPumpId = 2 },
                        new { TrailerId = 7, OilPumpId = 3 },
                        new { TrailerId = 7, OilPumpId = 4 },
                        new { TrailerId = 7, OilPumpId = 5 },
                        new { TrailerId = 7, OilPumpId = 6 },
                        new { TrailerId = 7, OilPumpId = 7 },

                        //PALMS 10U
                        new { TrailerId = 8, OilPumpId = 1 },
                        new { TrailerId = 8, OilPumpId = 2 },
                        new { TrailerId = 8, OilPumpId = 3 },
                        new { TrailerId = 8, OilPumpId = 4 },
                        new { TrailerId = 8, OilPumpId = 5 },
                        new { TrailerId = 8, OilPumpId = 6 },
                        new { TrailerId = 8, OilPumpId = 7 },

                        //PALMS 12U
                        new { TrailerId = 9, OilPumpId = 1 },
                        new { TrailerId = 9, OilPumpId = 2 },
                        new { TrailerId = 9, OilPumpId = 3 },
                        new { TrailerId = 9, OilPumpId = 4 },
                        new { TrailerId = 9, OilPumpId = 5 },
                        new { TrailerId = 9, OilPumpId = 6 },
                        new { TrailerId = 9, OilPumpId = 7 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, OilPumpId = 1 },
                        new { TrailerId = 10, OilPumpId = 4 },
                        new { TrailerId = 10, OilPumpId = 5 },
                        new { TrailerId = 10, OilPumpId = 6 },
                        new { TrailerId = 10, OilPumpId = 7 },

                        //PALMS 15U
                        new { TrailerId = 11, OilPumpId = 1 },
                        new { TrailerId = 11, OilPumpId = 2 },
                        new { TrailerId = 11, OilPumpId = 3 },
                        new { TrailerId = 11, OilPumpId = 4 },
                        new { TrailerId = 11, OilPumpId = 5 },
                        new { TrailerId = 11, OilPumpId = 6 },
                        new { TrailerId = 11, OilPumpId = 7 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, OilPumpId = 1 },
                        new { TrailerId = 12, OilPumpId = 4 },
                        new { TrailerId = 12, OilPumpId = 5 },
                        new { TrailerId = 12, OilPumpId = 6 },
                        new { TrailerId = 12, OilPumpId = 7 },

                        //PALMS HMWD3.2
                        new { TrailerId = 14, OilPumpId = 8 }
                    )
                );
        }
    }
}
