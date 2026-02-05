using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithTrailerLights
    {
        public static void ConnectTrailersWithLights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.Light)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("LightTrailer")
                   .HasData
                   (
                       //PALMS 6S
                       new { TrailerId = 1, LightId = 1 },
                       new { TrailerId = 1, LightId = 2 },
                       new { TrailerId = 1, LightId = 3 },

                       //PALMS 8SX
                       new { TrailerId = 2, LightId = 2 },
                       new { TrailerId = 2, LightId = 3 },

                       //PALMS 8D
                       new { TrailerId = 3, LightId = 1 },
                       new { TrailerId = 3, LightId = 2 },
                       new { TrailerId = 3, LightId = 3 },

                       //PALMS 9SC
                       new { TrailerId = 4, LightId = 1 },
                       new { TrailerId = 4, LightId = 2 },
                       new { TrailerId = 4, LightId = 3 },

                       //PALMS 10D
                       new { TrailerId = 5, LightId = 1 },
                       new { TrailerId = 5, LightId = 2 },
                       new { TrailerId = 5, LightId = 3 },

                       //PALMS 12D
                       new { TrailerId = 6, LightId = 1 },
                       new { TrailerId = 6, LightId = 2 },
                       new { TrailerId = 6, LightId = 3 },

                       //PALMS 14D
                       new { TrailerId = 7, LightId = 1 },
                       new { TrailerId = 7, LightId = 2 },
                       new { TrailerId = 7, LightId = 3 },

                       //PALMS 10UX
                       new { TrailerId = 8, LightId = 1 },
                       new { TrailerId = 8, LightId = 2 },
                       new { TrailerId = 8, LightId = 3 },

                       //PALMS 12U
                       new { TrailerId = 9, LightId = 1 },
                       new { TrailerId = 9, LightId = 2 },
                       new { TrailerId = 9, LightId = 3 },

                       //PALMS 12UAWD
                       new { TrailerId = 10, LightId = 1 },
                       new { TrailerId = 10, LightId = 2 },
                       new { TrailerId = 10, LightId = 3 },

                       //PALMS 15U
                       new { TrailerId = 11, LightId = 1 },
                       new { TrailerId = 11, LightId = 2 },
                       new { TrailerId = 11, LightId = 3 },

                       //PALMS 15UAWD
                       new { TrailerId = 12, LightId = 1 },
                       new { TrailerId = 12, LightId = 2 },
                       new { TrailerId = 12, LightId = 3 },

                       //PALMS HWD3.2
                       new { TrailerId = 13, LightId = 4 },
                       new { TrailerId = 13, LightId = 5 },

                       //PALMS HMWD3.2
                       new { TrailerId = 14, LightId = 4 },
                       new { TrailerId = 14, LightId = 5 },

                        //PALMS 2D
                       new { TrailerId = 15, LightId = 3 },

                       //PALMS 11UX
                       new { TrailerId = 16, LightId = 1 },
                       new { TrailerId = 16, LightId = 2 },
                       new { TrailerId = 16, LightId = 3 }
                   )
               );
        }
    }
}
