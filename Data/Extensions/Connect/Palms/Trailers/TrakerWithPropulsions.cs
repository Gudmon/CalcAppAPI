using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrakerWithPropulsions
    {
        public static void ConnectTrailersWithPropulsions(this ModelBuilder modelBuilder)
        {
            // PROPULSIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Propulsion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PropulsionTrailer")
                    .HasData
                    (
                        //PALMS 8D
                        new { TrailerId = 3, PropulsionId = 1 },
                        new { TrailerId = 3, PropulsionId = 2 },

                        //PALMS 8DWD
                        new { TrailerId = 4, PropulsionId = 3 },
                        new { TrailerId = 4, PropulsionId = 4 },

                        //PALMS 9SC
                        new { TrailerId = 5, PropulsionId = 1 },
                        new { TrailerId = 5, PropulsionId = 2 },

                        //PALMS 10D
                        new { TrailerId = 6, PropulsionId = 5 },
                        new { TrailerId = 6, PropulsionId = 6 },

                        //PALMS 10DWD
                        new { TrailerId = 7, PropulsionId = 3 },
                        new { TrailerId = 7, PropulsionId = 4 },

                        //PALMS 12D
                        new { TrailerId = 8, PropulsionId = 5 },
                        new { TrailerId = 8, PropulsionId = 6 },

                        //PALMS 12DWD
                        new { TrailerId = 9, PropulsionId = 3 },
                        new { TrailerId = 9, PropulsionId = 4 },

                        //PALMS 14D
                        new { TrailerId = 10, PropulsionId = 5 },
                        new { TrailerId = 10, PropulsionId = 6 },

                        //PALMS 14DWD
                        new { TrailerId = 11, PropulsionId = 3 },
                        new { TrailerId = 11, PropulsionId = 4 },

                        //PALMS 10U

                        //PALMS 10UWD
                        new { TrailerId = 13, PropulsionId = 3 },
                        new { TrailerId = 13, PropulsionId = 4 },

                        //PALMS 12U

                        //PALMS 12UWD
                        new { TrailerId = 15, PropulsionId = 3 },
                        new { TrailerId = 15, PropulsionId = 4 },

                        //PALMS 12UAWD
                        new { TrailerId = 16, PropulsionId = 7 },
                        new { TrailerId = 16, PropulsionId = 8 },

                        //PALMS 15U

                        //PALMS 15UWD
                        new { TrailerId = 18, PropulsionId = 3 },
                        new { TrailerId = 18, PropulsionId = 4 },

                        //PALMS 15UAWD
                        new { TrailerId = 19, PropulsionId = 7 },
                        new { TrailerId = 19, PropulsionId = 8 },

                        //PALMS 2D
                        new { TrailerId = 22, PropulsionId = 9 }
                    )
                );
        }
    }
}
