using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithSupportLegs
    {
        public static void ConnectTrailersWithSupportLegs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.SupportLeg)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("SupportLegTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, SupportLegId = 1 },

                        //PALMS 8SX
                        new { TrailerId = 2, SupportLegId = 2 },
                        new { TrailerId = 2, SupportLegId = 3 },

                        //PALMS 8D
                        new { TrailerId = 3, SupportLegId = 2 },
                        new { TrailerId = 3, SupportLegId = 3 },

                        //PALMS 9SC
                        new { TrailerId = 4, SupportLegId = 2 },
                        new { TrailerId = 4, SupportLegId = 3 },

                        //PALMS 10D
                        new { TrailerId = 5, SupportLegId = 2 },
                        new { TrailerId = 5, SupportLegId = 3 },

                        //PALMS 12D
                        new { TrailerId = 6, SupportLegId = 2 },
                        new { TrailerId = 6, SupportLegId = 3 },

                        //PALMS 14D
                        new { TrailerId = 7, SupportLegId = 2 },
                        new { TrailerId = 7, SupportLegId = 3 },

                        //PALMS 10UX
                        new { TrailerId = 8, SupportLegId = 2 },
                        new { TrailerId = 8, SupportLegId = 3 },

                        //PALMS 12U
                        new { TrailerId = 9, SupportLegId = 2 },
                        new { TrailerId = 9, SupportLegId = 3 },

                        //PALMS 12UAWD
                        new { TrailerId = 10, SupportLegId = 2 },
                        new { TrailerId = 10, SupportLegId = 3 },

                        //PALMS 15U
                        new { TrailerId = 11, SupportLegId = 2 },
                        new { TrailerId = 11, SupportLegId = 3 },

                        //PALMS 15UAWD
                        new { TrailerId = 12, SupportLegId = 2 },
                        new { TrailerId = 12, SupportLegId = 3 },

                        //PALMS 2D
                        new { TrailerId = 15, SupportLegId = 1 },

                        //PALMS 11U
                        new { TrailerId = 16, SupportLegId = 2 },
                        new { TrailerId = 16, SupportLegId = 3 }
                    )
                );
        }
    }
}
