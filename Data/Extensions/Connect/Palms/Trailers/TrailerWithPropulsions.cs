using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithPropulsions
    {
        public static void ConnectTrailersWithPropulsions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Propulsion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PropulsionTrailer")
                    .HasData
                    (
                        //PALMS 8D
                        new { TrailerId = 3, PropulsionId = 1 },
                        new { TrailerId = 3, PropulsionId = 2 },
                        new { TrailerId = 3, PropulsionId = 3 },
                        new { TrailerId = 3, PropulsionId = 4 },

                        //PALMS 9SC
                        new { TrailerId = 4, PropulsionId = 1 },
                        new { TrailerId = 4, PropulsionId = 2 },
                        new { TrailerId = 4, PropulsionId = 3 },
                        new { TrailerId = 4, PropulsionId = 4 },

                        //PALMS 10D
                        new { TrailerId = 5, PropulsionId = 5 },
                        new { TrailerId = 5, PropulsionId = 6 },
                        new { TrailerId = 5, PropulsionId = 3 },
                        new { TrailerId = 5, PropulsionId = 4 },
                        new { TrailerId = 5, PropulsionId = 7 },
                        new { TrailerId = 5, PropulsionId = 8 },
                        new { TrailerId = 5, PropulsionId = 9 },
                        new { TrailerId = 5, PropulsionId = 10 },

                        //PALMS 12D
                        new { TrailerId = 6, PropulsionId = 5 },
                        new { TrailerId = 6, PropulsionId = 6 },
                        new { TrailerId = 6, PropulsionId = 12 },
                        new { TrailerId = 6, PropulsionId = 13 },
                        new { TrailerId = 6, PropulsionId = 14 },
                        new { TrailerId = 6, PropulsionId = 15 },

                        //PALMS 14D
                        new { TrailerId = 7, PropulsionId = 5 },
                        new { TrailerId = 7, PropulsionId = 6 },
                        new { TrailerId = 7, PropulsionId = 12 },
                        new { TrailerId = 7, PropulsionId = 13 },
                        new { TrailerId = 7, PropulsionId = 14 },
                        new { TrailerId = 7, PropulsionId = 15 },

                        //PALMS 10U
                        new { TrailerId = 8, PropulsionId = 7 },
                        new { TrailerId = 8, PropulsionId = 8 },
                        new { TrailerId = 8, PropulsionId = 9 },
                        new { TrailerId = 8, PropulsionId = 10 },

                        //PALMS 12U
                        new { TrailerId = 9, PropulsionId = 16 },
                        new { TrailerId = 9, PropulsionId = 17 },
                        new { TrailerId = 9, PropulsionId = 18 },
                        new { TrailerId = 9, PropulsionId = 19 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, PropulsionId = 20 },
                        new { TrailerId = 10, PropulsionId = 21 },

                        //PALMS 15U
                        new { TrailerId = 11, PropulsionId = 16 },
                        new { TrailerId = 11, PropulsionId = 17 },
                        new { TrailerId = 11, PropulsionId = 18 },
                        new { TrailerId = 11, PropulsionId = 19 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, PropulsionId = 20 },
                        new { TrailerId = 12, PropulsionId = 21 },

                        //PALMS 2D
                        new { TrailerId = 15, PropulsionId = 22 },

                        //PALMS 11UX
                        new { TrailerId = 16, PropulsionId = 5 },
                        new { TrailerId = 16, PropulsionId = 6 },
                        new { TrailerId = 16, PropulsionId = 12 },
                        new { TrailerId = 16, PropulsionId = 13 },
                        new { TrailerId = 16, PropulsionId = 14 },
                        new { TrailerId = 16, PropulsionId = 15 }
                    )
                );
        }
    }
}
