using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithPlatforms
    {
        public static void ConnectTrailersWithPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Platform)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PlatformTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, PlatformId = 1 },
                        new { TrailerId = 1, PlatformId = 2 },

                        //PALMS 8SX
                        new { TrailerId = 2, PlatformId = 1 },
                        new { TrailerId = 2, PlatformId = 2 },

                        //PALMS 8D
                        new { TrailerId = 3, PlatformId = 1 },
                        new { TrailerId = 3, PlatformId = 2 },

                        //PALMS 9SC
                        new { TrailerId = 4, PlatformId = 1 },

                        //PALMS 10D
                        new { TrailerId = 5, PlatformId = 1 },

                        //PALMS 12D
                        new { TrailerId = 6, PlatformId = 1 },

                        //PALMS 14D
                        new { TrailerId = 7, PlatformId = 1 },

                        //PALMS 10UX
                        new { TrailerId = 8, PlatformId = 1 },

                        //PALMS 12U
                        new { TrailerId = 9, PlatformId = 1 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, PlatformId = 1 },

                        //PALMS 15U
                        new { TrailerId = 11, PlatformId = 1 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, PlatformId = 1 },

                        //PALMS 11UX
                        new { TrailerId = 16, PlatformId = 1 }
                    )
                );
        }
    }
}
