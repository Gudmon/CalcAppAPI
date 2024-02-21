using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithStanchions
    {
        public static void ConnectTrailersWithStanchions(this ModelBuilder modelBuilder)
        {
            // STANCHIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Stanchion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("StanchionTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, StanchionId = 1 },
                        new { TrailerId = 1, StanchionId = 2 },

                        //PALMS 8SX
                        new { TrailerId = 2, StanchionId = 3 },
                        new { TrailerId = 2, StanchionId = 4 },
                        new { TrailerId = 2, StanchionId = 5 },
                        new { TrailerId = 2, StanchionId = 6 },

                        //PALMS 8D
                        new { TrailerId = 3, StanchionId = 7 },
                        new { TrailerId = 3, StanchionId = 8 },
                        new { TrailerId = 3, StanchionId = 9 },
                        new { TrailerId = 3, StanchionId = 10 },

                        //PALMS 8DWD
                        new { TrailerId = 4, StanchionId = 11 },
                        new { TrailerId = 4, StanchionId = 12 },
                        new { TrailerId = 4, StanchionId = 13 },
                        new { TrailerId = 4, StanchionId = 14 },

                        //PALMS 9SC
                        new { TrailerId = 5, StanchionId = 15 },
                        new { TrailerId = 5, StanchionId = 16 },
                        new { TrailerId = 5, StanchionId = 17 },
                        new { TrailerId = 5, StanchionId = 18 },

                        //PALMS 10D
                        new { TrailerId = 6, StanchionId = 19 },
                        new { TrailerId = 6, StanchionId = 20 },
                        new { TrailerId = 6, StanchionId = 21 },
                        new { TrailerId = 6, StanchionId = 22 },

                        //PALMS 10DWD
                        new { TrailerId = 7, StanchionId = 23 },
                        new { TrailerId = 7, StanchionId = 24 },
                        new { TrailerId = 7, StanchionId = 25 },
                        new { TrailerId = 7, StanchionId = 26 },

                        //PALMS 12D
                        new { TrailerId = 8, StanchionId = 27 },
                        new { TrailerId = 8, StanchionId = 28 },
                        new { TrailerId = 8, StanchionId = 29 },
                        new { TrailerId = 8, StanchionId = 30 },

                        //PALMS 12DWD
                        new { TrailerId = 9, StanchionId = 31 },
                        new { TrailerId = 9, StanchionId = 32 },
                        new { TrailerId = 9, StanchionId = 33 },
                        new { TrailerId = 9, StanchionId = 34 },

                        //PALMS 14D
                        new { TrailerId = 10, StanchionId = 35 },
                        new { TrailerId = 10, StanchionId = 36 },
                        new { TrailerId = 10, StanchionId = 37 },
                        new { TrailerId = 10, StanchionId = 38 },

                        //PALMS 14DWD
                        new { TrailerId = 11, StanchionId = 39 },
                        new { TrailerId = 11, StanchionId = 40 },
                        new { TrailerId = 11, StanchionId = 41 },
                        new { TrailerId = 11, StanchionId = 42 }
                    )

                );
        }
    }
}
