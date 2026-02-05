using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithOilTanks
    {
        public static void ConnectTrailersWithOilTanks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.OilTank)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("OilTankTrailer")
                    .HasData
                    (
                        //PALMS 8SX
                        new { TrailerId = 2, OilTankId = 1 },
                        new { TrailerId = 2, OilTankId = 2 },
                        new { TrailerId = 2, OilTankId = 3 },
                        new { TrailerId = 2, OilTankId = 4 },

                        //PALMS 8D
                        new { TrailerId = 3, OilTankId = 1 },
                        new { TrailerId = 3, OilTankId = 2 },
                        new { TrailerId = 3, OilTankId = 3 },
                        new { TrailerId = 3, OilTankId = 4 },

                        //PALMS 9SC
                        new { TrailerId = 4, OilTankId = 1 },
                        new { TrailerId = 4, OilTankId = 2 },
                        new { TrailerId = 4, OilTankId = 3 },
                        new { TrailerId = 4, OilTankId = 4 },

                        //PALMS 10D
                        new { TrailerId = 5, OilTankId = 1 },
                        new { TrailerId = 5, OilTankId = 2 },
                        new { TrailerId = 5, OilTankId = 3 },
                        new { TrailerId = 5, OilTankId = 4 },

                        //PALMS 12D
                        new { TrailerId = 6, OilTankId = 1 },
                        new { TrailerId = 6, OilTankId = 2 },
                        new { TrailerId = 6, OilTankId = 3 },
                        new { TrailerId = 6, OilTankId = 4 },

                        //PALMS 14D
                        new { TrailerId = 7, OilTankId = 1 },
                        new { TrailerId = 7, OilTankId = 2 },
                        new { TrailerId = 7, OilTankId = 3 },
                        new { TrailerId = 7, OilTankId = 4 },

                        //PALMS 10UX
                        new { TrailerId = 8, OilTankId = 1 },
                        new { TrailerId = 8, OilTankId = 2 },
                        new { TrailerId = 8, OilTankId = 3 },
                        new { TrailerId = 8, OilTankId = 4 },

                        //PALMS 12U
                        new { TrailerId = 9, OilTankId = 1 },
                        new { TrailerId = 9, OilTankId = 2 },
                        new { TrailerId = 9, OilTankId = 3 },
                        new { TrailerId = 9, OilTankId = 4 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, OilTankId = 1 },
                        new { TrailerId = 10, OilTankId = 2 },
                        new { TrailerId = 10, OilTankId = 3 },
                        new { TrailerId = 10, OilTankId = 4 },

                        //PALMS 15U
                        new { TrailerId = 11, OilTankId = 1 },
                        new { TrailerId = 11, OilTankId = 2 },
                        new { TrailerId = 11, OilTankId = 3 },
                        new { TrailerId = 11, OilTankId = 4 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, OilTankId = 1 },
                        new { TrailerId = 12, OilTankId = 2 },
                        new { TrailerId = 12, OilTankId = 3 },
                        new { TrailerId = 12, OilTankId = 4 },

                        //PALMS HMWD3.2
                        new { TrailerId = 14, OilTankId = 7 },

                        //PALMS 11UX
                        new { TrailerId = 16, OilTankId = 1 },
                        new { TrailerId = 16, OilTankId = 2 },
                        new { TrailerId = 16, OilTankId = 3 },
                        new { TrailerId = 16, OilTankId = 4 }
                    )
                );
        }

    }
}
