using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithCranes
    {
        public static void ConnectTrailersWithCranes(this ModelBuilder modelBuilder)
        {
            // CRANES
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Crane)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("CraneTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, CraneId = 1 },
                        new { TrailerId = 1, CraneId = 2 },

                        new { TrailerId = 2, CraneId = 1 },
                        new { TrailerId = 2, CraneId = 2 },
                        new { TrailerId = 2, CraneId = 3 },
                        new { TrailerId = 2, CraneId = 4 }
                    )

                );
        }
    }
}
