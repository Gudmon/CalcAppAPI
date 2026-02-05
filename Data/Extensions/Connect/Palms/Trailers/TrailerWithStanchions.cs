using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithStanchions
    {
        public static void ConnectTrailersWithStanchions(this ModelBuilder modelBuilder)
        {
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
                        new { TrailerId = 3, StanchionId = 11 },
                        new { TrailerId = 3, StanchionId = 12 },
                        new { TrailerId = 3, StanchionId = 13 },
                        new { TrailerId = 3, StanchionId = 14 },

                        //PALMS 9SC
                        new { TrailerId = 4, StanchionId = 15 },
                        new { TrailerId = 4, StanchionId = 16 },
                        new { TrailerId = 4, StanchionId = 17 },
                        new { TrailerId = 4, StanchionId = 18 },

                        //PALMS 10D
                        new { TrailerId = 5, StanchionId = 19 },
                        new { TrailerId = 5, StanchionId = 20 },
                        new { TrailerId = 5, StanchionId = 21 },
                        new { TrailerId = 5, StanchionId = 22 },

                        //PALMS 12D
                        new { TrailerId = 6, StanchionId = 23 },
                        new { TrailerId = 6, StanchionId = 24 },
                        new { TrailerId = 6, StanchionId = 25 },
                        new { TrailerId = 6, StanchionId = 26 },

                        //PALMS 14D
                        new { TrailerId = 7, StanchionId = 27 },
                        new { TrailerId = 7, StanchionId = 28 },
                        new { TrailerId = 7, StanchionId = 29 },
                        new { TrailerId = 7, StanchionId = 30 },

                        //PALMS 10UX
                        new { TrailerId = 8, StanchionId = 32 },
                        new { TrailerId = 8, StanchionId = 34 },
                        new { TrailerId = 8, StanchionId = 36 },
                        new { TrailerId = 8, StanchionId = 38 },

                        //PALMS 12U
                        new { TrailerId = 9, StanchionId = 39 },
                        new { TrailerId = 9, StanchionId = 40 },
                        new { TrailerId = 9, StanchionId = 41 },
                        new { TrailerId = 9, StanchionId = 42 },
                        new { TrailerId = 9, StanchionId = 43 },
                        new { TrailerId = 9, StanchionId = 44 },
                        new { TrailerId = 9, StanchionId = 45 },
                        new { TrailerId = 9, StanchionId = 46 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, StanchionId = 47 },
                        new { TrailerId = 10, StanchionId = 48 },
                        new { TrailerId = 10, StanchionId = 49 },
                        new { TrailerId = 10, StanchionId = 50 },
                        new { TrailerId = 10, StanchionId = 51 },
                        new { TrailerId = 10, StanchionId = 52 },
                        new { TrailerId = 10, StanchionId = 53 },
                        new { TrailerId = 10, StanchionId = 54 },

                        //PALMS 15U
                        new { TrailerId = 11, StanchionId = 55 },
                        new { TrailerId = 11, StanchionId = 56 },
                        new { TrailerId = 11, StanchionId = 57 },
                        new { TrailerId = 11, StanchionId = 58 },
                        new { TrailerId = 11, StanchionId = 59 },
                        new { TrailerId = 11, StanchionId = 60 },
                        new { TrailerId = 11, StanchionId = 61 },
                        new { TrailerId = 11, StanchionId = 62 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, StanchionId = 63 },
                        new { TrailerId = 12, StanchionId = 64 },
                        new { TrailerId = 12, StanchionId = 65 },
                        new { TrailerId = 12, StanchionId = 66 },
                        new { TrailerId = 12, StanchionId = 67 },
                        new { TrailerId = 12, StanchionId = 68 },
                        new { TrailerId = 12, StanchionId = 69 },
                        new { TrailerId = 12, StanchionId = 70 },

                        //PALMS MWD3.2
                        new { TrailerId = 13, StanchionId = 71 },
                        new { TrailerId = 13, StanchionId = 72 },
                        new { TrailerId = 13, StanchionId = 73 },
                        new { TrailerId = 13, StanchionId = 74 },

                        //PALMS HMWD3.2
                        new { TrailerId = 14, StanchionId = 75 },
                        new { TrailerId = 14, StanchionId = 76 },
                        new { TrailerId = 14, StanchionId = 77 },
                        new { TrailerId = 14, StanchionId = 78 },

                        //PALMS 2D
                        new { TrailerId = 15, StanchionId = 79 },
                        new { TrailerId = 15, StanchionId = 80 },
                        new { TrailerId = 15, StanchionId = 81 },

                        //PALMS 11UX
                        new { TrailerId = 16, StanchionId = 82 },
                        new { TrailerId = 16, StanchionId = 83 },
                        new { TrailerId = 16, StanchionId = 84 },
                        new { TrailerId = 16, StanchionId = 85 }
                    )
                );
        }
    }
}
