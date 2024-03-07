using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithSupportLegs
    {
        public static void ConnectTrailersWithSupportLegs(this ModelBuilder modelBuilder)
        {
            // SUPPORT LEG
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.SupportLeg)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("SupportLegTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, SupportLegId = 1 },

                        new { TrailerId = 2, SupportLegId = 2 },
                        new { TrailerId = 2, SupportLegId = 3 },

                        new { TrailerId = 3, SupportLegId = 2 },
                        new { TrailerId = 3, SupportLegId = 3 },

                        new { TrailerId = 4, SupportLegId = 2 },
                        new { TrailerId = 4, SupportLegId = 3 },

                        new { TrailerId = 5, SupportLegId = 2 },
                        new { TrailerId = 5, SupportLegId = 3 },

                        new { TrailerId = 6, SupportLegId = 2 },
                        new { TrailerId = 6, SupportLegId = 3 },

                        new { TrailerId = 7, SupportLegId = 2 },
                        new { TrailerId = 7, SupportLegId = 3 },

                        new { TrailerId = 8, SupportLegId = 2 },
                        new { TrailerId = 8, SupportLegId = 3 },

                        new { TrailerId = 9, SupportLegId = 2 },
                        new { TrailerId = 9, SupportLegId = 3 },

                        new { TrailerId = 10, SupportLegId = 2 },
                        new { TrailerId = 10, SupportLegId = 3 },

                        new { TrailerId = 11, SupportLegId = 2 },
                        new { TrailerId = 11, SupportLegId = 3 },

                        new { TrailerId = 12, SupportLegId = 2 },
                        new { TrailerId = 12, SupportLegId = 3 },

                        new { TrailerId = 13, SupportLegId = 2 },
                        new { TrailerId = 13, SupportLegId = 3 },

                        new { TrailerId = 14, SupportLegId = 2 },
                        new { TrailerId = 14, SupportLegId = 3 },

                        new { TrailerId = 15, SupportLegId = 2 },
                        new { TrailerId = 15, SupportLegId = 3 },

                        new { TrailerId = 16, SupportLegId = 2 },
                        new { TrailerId = 16, SupportLegId = 3 },

                        new { TrailerId = 17, SupportLegId = 2 },
                        new { TrailerId = 17, SupportLegId = 3 },

                        new { TrailerId = 18, SupportLegId = 2 },
                        new { TrailerId = 18, SupportLegId = 3 },

                        new { TrailerId = 19, SupportLegId = 2 },
                        new { TrailerId = 19, SupportLegId = 3 }
                    )
                );
        }
    }
}
