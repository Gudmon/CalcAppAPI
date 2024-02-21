using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithLights
    {
        public static void ConnectTrailersWithLights(this ModelBuilder modelBuilder)
        {
            // LIGHT
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.Light)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("LightTrailer")
                   .HasData
                   (
                       new { TrailerId = 1, LightId = 1 },
                       new { TrailerId = 1, LightId = 2 },
                       new { TrailerId = 1, LightId = 3 },

                       new { TrailerId = 2, LightId = 2 },
                       new { TrailerId = 2, LightId = 3 },

                       new { TrailerId = 3, LightId = 1 },
                       new { TrailerId = 3, LightId = 2 },
                       new { TrailerId = 3, LightId = 3 },

                       new { TrailerId = 4, LightId = 1 },
                       new { TrailerId = 4, LightId = 2 },
                       new { TrailerId = 4, LightId = 3 },

                       new { TrailerId = 5, LightId = 1 },
                       new { TrailerId = 5, LightId = 2 },
                       new { TrailerId = 5, LightId = 3 },

                       new { TrailerId = 6, LightId = 1 },
                       new { TrailerId = 6, LightId = 2 },
                       new { TrailerId = 6, LightId = 3 },

                       new { TrailerId = 7, LightId = 1 },
                       new { TrailerId = 7, LightId = 2 },
                       new { TrailerId = 7, LightId = 3 },

                       new { TrailerId = 8, LightId = 1 },
                       new { TrailerId = 8, LightId = 2 },
                       new { TrailerId = 8, LightId = 3 },

                       new { TrailerId = 9, LightId = 1 },
                       new { TrailerId = 9, LightId = 2 },
                       new { TrailerId = 9, LightId = 3 },

                       new { TrailerId = 10, LightId = 1 },
                       new { TrailerId = 10, LightId = 2 },
                       new { TrailerId = 10, LightId = 3 },

                       new { TrailerId = 11, LightId = 1 },
                       new { TrailerId = 11, LightId = 2 },
                       new { TrailerId = 11, LightId = 3 }
                   )
               );
        }
    }
}
