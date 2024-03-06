using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithCranes
    {
        public static void ConnectTrailersWithCranes(this ModelBuilder modelBuilder)
        {
            // CRANES
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Crane)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("CraneTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, CraneId = 1 },
                        new { TrailerId = 1, CraneId = 2 },

                        //PALMS 8SX
                        new { TrailerId = 2, CraneId = 1 },
                        new { TrailerId = 2, CraneId = 2 },
                        new { TrailerId = 2, CraneId = 3 },
                        new { TrailerId = 2, CraneId = 4 },

                        //PALMS 8D
                        new { TrailerId = 3, CraneId = 4 },
                        new { TrailerId = 3, CraneId = 5 },
                        new { TrailerId = 3, CraneId = 6 },
                        new { TrailerId = 3, CraneId = 7 },
                        new { TrailerId = 3, CraneId = 8 },
                        new { TrailerId = 3, CraneId = 9 },

                        //PALMS 8DWD
                        new { TrailerId = 4, CraneId = 4 },
                        new { TrailerId = 4, CraneId = 5 },
                        new { TrailerId = 4, CraneId = 6 },
                        new { TrailerId = 4, CraneId = 7 },
                        new { TrailerId = 4, CraneId = 8 },
                        new { TrailerId = 4, CraneId = 9 },

                        //PALMS 9SC
                        new { TrailerId = 5, CraneId = 4 },
                        new { TrailerId = 5, CraneId = 5 },
                        new { TrailerId = 5, CraneId = 6 },
                        new { TrailerId = 5, CraneId = 7 },

                        //PALMS 10D
                        new { TrailerId = 6, CraneId = 4 },
                        new { TrailerId = 6, CraneId = 5 },
                        new { TrailerId = 6, CraneId = 6 },
                        new { TrailerId = 6, CraneId = 7 },
                        new { TrailerId = 6, CraneId = 8 },
                        new { TrailerId = 6, CraneId = 9 },
                        new { TrailerId = 6, CraneId = 10 },

                        //PALMS 10DWD
                        new { TrailerId = 7, CraneId = 4 },
                        new { TrailerId = 7, CraneId = 5 },
                        new { TrailerId = 7, CraneId = 6 },
                        new { TrailerId = 7, CraneId = 7 },
                        new { TrailerId = 7, CraneId = 8 },
                        new { TrailerId = 7, CraneId = 9 },
                        new { TrailerId = 7, CraneId = 10 },

                        //PALMS 12D
                        new { TrailerId = 8, CraneId = 5 },
                        new { TrailerId = 8, CraneId = 6 },
                        new { TrailerId = 8, CraneId = 7 },
                        new { TrailerId = 8, CraneId = 8 },
                        new { TrailerId = 8, CraneId = 9 },
                        new { TrailerId = 8, CraneId = 10 },
                        new { TrailerId = 8, CraneId = 11 },

                        //PALMS 12DWD
                        new { TrailerId = 9, CraneId = 5 },
                        new { TrailerId = 9, CraneId = 6 },
                        new { TrailerId = 9, CraneId = 7 },
                        new { TrailerId = 9, CraneId = 8 },
                        new { TrailerId = 9, CraneId = 9 },
                        new { TrailerId = 9, CraneId = 10 },
                        new { TrailerId = 9, CraneId = 11 },

                        //PALMS 14D
                        new { TrailerId = 10, CraneId = 5 },
                        new { TrailerId = 10, CraneId = 6 },
                        new { TrailerId = 10, CraneId = 7 },
                        new { TrailerId = 10, CraneId = 8 },
                        new { TrailerId = 10, CraneId = 9 },
                        new { TrailerId = 10, CraneId = 10 },
                        new { TrailerId = 10, CraneId = 11 },
                        new { TrailerId = 10, CraneId = 12 },

                        //PALMS 14DWD
                        new { TrailerId = 11, CraneId = 5 },
                        new { TrailerId = 11, CraneId = 6 },
                        new { TrailerId = 11, CraneId = 7 },
                        new { TrailerId = 11, CraneId = 8 },
                        new { TrailerId = 11, CraneId = 9 },
                        new { TrailerId = 11, CraneId = 10 },
                        new { TrailerId = 11, CraneId = 11 },
                        new { TrailerId = 11, CraneId = 12 }
                    )

                );
        }
    }
}
