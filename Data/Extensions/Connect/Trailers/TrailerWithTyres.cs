using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithTyres
    {
        public static void ConnectTrailersWithTyres(this ModelBuilder modelBuilder)
        {
            // TYRE
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.Tyre)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("TyreTrailer")
                   .HasData
                   (
                       new { TrailerId = 1, TyreId = 1 },
                       new { TrailerId = 1, TyreId = 2 },

                       new { TrailerId = 2, TyreId = 1 },
                       new { TrailerId = 2, TyreId = 2 },
                       new { TrailerId = 2, TyreId = 3 },

                       new { TrailerId = 3, TyreId = 1 },
                       new { TrailerId = 3, TyreId = 2 },
                       new { TrailerId = 3, TyreId = 3 },
                       new { TrailerId = 3, TyreId = 5 },
                       new { TrailerId = 3, TyreId = 8 }
                   )

               );
        }
    }
}
