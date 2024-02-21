using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithBrakes
    {
        public static void ConnectTrailersWithBrakes(this ModelBuilder modelBuilder)
        {
            // BRAKES
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Brake)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("BrakeTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, BrakeId = 1 },
                        new { TrailerId = 1, BrakeId = 2 },
                        new { TrailerId = 1, BrakeId = 3 },
                        new { TrailerId = 1, BrakeId = 4 },
                        new { TrailerId = 1, BrakeId = 5 },
                        new { TrailerId = 1, BrakeId = 6 },
                        new { TrailerId = 1, BrakeId = 7 },

                        //PALMS 8SX
                        new { TrailerId = 2, BrakeId = 1 },
                        new { TrailerId = 2, BrakeId = 2 },
                        new { TrailerId = 2, BrakeId = 3 },
                        new { TrailerId = 2, BrakeId = 4 },
                        new { TrailerId = 2, BrakeId = 5 },
                        new { TrailerId = 2, BrakeId = 6 },
                        new { TrailerId = 2, BrakeId = 7 },

                        //PALMS 8D
                        new { TrailerId = 3, BrakeId = 1 },
                        new { TrailerId = 3, BrakeId = 2 },
                        new { TrailerId = 3, BrakeId = 3 },
                        new { TrailerId = 3, BrakeId = 4 },
                        new { TrailerId = 3, BrakeId = 5 },
                        new { TrailerId = 3, BrakeId = 8 },
                        new { TrailerId = 3, BrakeId = 9 },

                        //PALMS 8DWD
                        new { TrailerId = 4, BrakeId = 1 },
                        new { TrailerId = 4, BrakeId = 10 },
                        new { TrailerId = 4, BrakeId = 11 },
                        new { TrailerId = 4, BrakeId = 12 },
                        new { TrailerId = 4, BrakeId = 13 },
                        new { TrailerId = 4, BrakeId = 14 },
                        new { TrailerId = 4, BrakeId = 15 },

                        //PALMS 9SC
                        new { TrailerId = 5, BrakeId = 1 },
                        new { TrailerId = 5, BrakeId = 2 },
                        new { TrailerId = 5, BrakeId = 3 },
                        new { TrailerId = 5, BrakeId = 4 },
                        new { TrailerId = 5, BrakeId = 5 },
                        new { TrailerId = 5, BrakeId = 6 },
                        new { TrailerId = 5, BrakeId = 7 },

                        //PALMS 10D
                        new { TrailerId = 6, BrakeId = 1 },
                        new { TrailerId = 6, BrakeId = 2 },
                        new { TrailerId = 6, BrakeId = 3 },
                        new { TrailerId = 6, BrakeId = 4 },
                        new { TrailerId = 6, BrakeId = 5 },
                        new { TrailerId = 6, BrakeId = 8 },
                        new { TrailerId = 6, BrakeId = 9 },

                        //PALMS 10DWD
                        new { TrailerId = 7, BrakeId = 1 },
                        new { TrailerId = 7, BrakeId = 10 },
                        new { TrailerId = 7, BrakeId = 11 },
                        new { TrailerId = 7, BrakeId = 12 },
                        new { TrailerId = 7, BrakeId = 13 },
                        new { TrailerId = 7, BrakeId = 14 },
                        new { TrailerId = 7, BrakeId = 15 },

                        //PALMS 12D
                        new { TrailerId = 8, BrakeId = 1 },
                        new { TrailerId = 8, BrakeId = 10 },
                        new { TrailerId = 8, BrakeId = 16 },
                        new { TrailerId = 8, BrakeId = 12 },
                        new { TrailerId = 8, BrakeId = 17 },
                        new { TrailerId = 8, BrakeId = 18 },
                        new { TrailerId = 8, BrakeId = 19 },

                        //PALMS 12DWD
                        new { TrailerId = 9, BrakeId = 1 },
                        new { TrailerId = 9, BrakeId = 10 },
                        new { TrailerId = 9, BrakeId = 11 },
                        new { TrailerId = 9, BrakeId = 12 },
                        new { TrailerId = 9, BrakeId = 13 },
                        new { TrailerId = 9, BrakeId = 14 },
                        new { TrailerId = 9, BrakeId = 15 },

                        //PALMS 14D
                        new { TrailerId = 10, BrakeId = 1 },
                        new { TrailerId = 10, BrakeId = 10 },
                        new { TrailerId = 10, BrakeId = 16 },
                        new { TrailerId = 10, BrakeId = 12 },
                        new { TrailerId = 10, BrakeId = 17 },
                        new { TrailerId = 10, BrakeId = 18 },
                        new { TrailerId = 10, BrakeId = 19 },

                        //PALMS 14DWD
                        new { TrailerId = 11, BrakeId = 1 },
                        new { TrailerId = 11, BrakeId = 10 },
                        new { TrailerId = 11, BrakeId = 11 },
                        new { TrailerId = 11, BrakeId = 12 },
                        new { TrailerId = 11, BrakeId = 13 },
                        new { TrailerId = 11, BrakeId = 14 },
                        new { TrailerId = 11, BrakeId = 15 }
                    )
                );
        }
    }
}
