using CalcAppAPI.Models.Machine.Configurations.JoinEntities.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
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

                        //PALMS 9SC
                        new { TrailerId = 4, BrakeId = 1 },
                        new { TrailerId = 4, BrakeId = 2 },
                        new { TrailerId = 4, BrakeId = 3 },
                        new { TrailerId = 4, BrakeId = 4 },
                        new { TrailerId = 4, BrakeId = 5 },
                        new { TrailerId = 4, BrakeId = 6 },
                        new { TrailerId = 4, BrakeId = 7 },

                        //PALMS 10D
                        new { TrailerId = 5, BrakeId = 1 },
                        new { TrailerId = 5, BrakeId = 2 },
                        new { TrailerId = 5, BrakeId = 3 },
                        new { TrailerId = 5, BrakeId = 4 },
                        new { TrailerId = 5, BrakeId = 5 },
                        new { TrailerId = 5, BrakeId = 8 },
                        new { TrailerId = 5, BrakeId = 9 },

                        //PALMS 12D
                        new { TrailerId = 6, BrakeId = 1 },
                        new { TrailerId = 6, BrakeId = 10 },
                        new { TrailerId = 6, BrakeId = 11 },
                        new { TrailerId = 6, BrakeId = 12 },
                        new { TrailerId = 6, BrakeId = 13 },
                        new { TrailerId = 6, BrakeId = 14 },
                        new { TrailerId = 6, BrakeId = 15 },

                        //PALMS 14D
                        new { TrailerId = 7, BrakeId = 1 },
                        new { TrailerId = 7, BrakeId = 10 },
                        new { TrailerId = 7, BrakeId = 11 },
                        new { TrailerId = 7, BrakeId = 12 },
                        new { TrailerId = 7, BrakeId = 13 },
                        new { TrailerId = 7, BrakeId = 14 },
                        new { TrailerId = 7, BrakeId = 15 },

                        //PALMS 10UX
                        new { TrailerId = 8, BrakeId = 1 },
                        new { TrailerId = 8, BrakeId = 2 },
                        new { TrailerId = 8, BrakeId = 3 },
                        new { TrailerId = 8, BrakeId = 4 },
                        new { TrailerId = 8, BrakeId = 5 },
                        new { TrailerId = 8, BrakeId = 8 },
                        new { TrailerId = 8, BrakeId = 9 },

                        //PALMS 12U
                        new { TrailerId = 9, BrakeId = 1 },
                        new { TrailerId = 9, BrakeId = 10 },
                        new { TrailerId = 9, BrakeId = 11 },
                        new { TrailerId = 9, BrakeId = 12 },
                        new { TrailerId = 9, BrakeId = 13 },
                        new { TrailerId = 9, BrakeId = 14 },
                        new { TrailerId = 9, BrakeId = 15 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, BrakeId = 1 },
                        new { TrailerId = 10, BrakeId = 16 },
                        new { TrailerId = 10, BrakeId = 17 },
                        new { TrailerId = 10, BrakeId = 18 },
                        new { TrailerId = 10, BrakeId = 19 },
                        new { TrailerId = 10, BrakeId = 20 },
                        new { TrailerId = 10, BrakeId = 21 },

                        //PALMS 15U
                        new { TrailerId = 11, BrakeId = 1 },
                        new { TrailerId = 11, BrakeId = 10 },
                        new { TrailerId = 11, BrakeId = 11 },
                        new { TrailerId = 11, BrakeId = 12 },
                        new { TrailerId = 11, BrakeId = 13 },
                        new { TrailerId = 11, BrakeId = 14 },
                        new { TrailerId = 11, BrakeId = 15 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, BrakeId = 1 },
                        new { TrailerId = 12, BrakeId = 16 },
                        new { TrailerId = 12, BrakeId = 17 },
                        new { TrailerId = 12, BrakeId = 18 },
                        new { TrailerId = 12, BrakeId = 19 },
                        new { TrailerId = 12, BrakeId = 20 },
                        new { TrailerId = 12, BrakeId = 21 },

                        //PALMS MWD3.2
                        new { TrailerId = 13, BrakeId = 23 },
                        new { TrailerId = 13, BrakeId = 24 },

                        //PALMS HMWD3.2
                        new { TrailerId = 14, BrakeId = 23 },
                        new { TrailerId = 14, BrakeId = 24 },

                        //PALMS 11UX
                        new { TrailerId = 16, BrakeId = 1 },
                        new { TrailerId = 16, BrakeId = 10 },
                        new { TrailerId = 16, BrakeId = 11 },
                        new { TrailerId = 16, BrakeId = 12 },
                        new { TrailerId = 16, BrakeId = 13 },
                        new { TrailerId = 16, BrakeId = 14 },
                        new { TrailerId = 16, BrakeId = 15 }
                    )
                );
        }
    }
}
