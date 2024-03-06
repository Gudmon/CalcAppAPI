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
                       //PALMS 6S
                       new { TrailerId = 1, TyreId = 1 },
                       new { TrailerId = 1, TyreId = 2 },

                       //PALMS 8SX
                       new { TrailerId = 2, TyreId = 1 },
                       new { TrailerId = 2, TyreId = 2 },
                       new { TrailerId = 2, TyreId = 3 },

                       //PALMS 8D
                       new { TrailerId = 3, TyreId = 1 },
                       new { TrailerId = 3, TyreId = 2 },
                       new { TrailerId = 3, TyreId = 3 },
                       new { TrailerId = 3, TyreId = 5 },
                       new { TrailerId = 3, TyreId = 7 },

                       //PALMS 8DWD
                       new { TrailerId = 4, TyreId = 4 },
                       new { TrailerId = 4, TyreId = 6 },
                       new { TrailerId = 4, TyreId = 8 },

                       //PALMS 9SC
                       new { TrailerId = 5, TyreId = 1 },
                       new { TrailerId = 5, TyreId = 2 },
                       new { TrailerId = 5, TyreId = 3 },
                       new { TrailerId = 5, TyreId = 5 },
                       new { TrailerId = 5, TyreId = 7 },

                       //PALMS 10D
                       new { TrailerId = 6, TyreId = 1 },
                       new { TrailerId = 6, TyreId = 2 },
                       new { TrailerId = 6, TyreId = 3 },
                       new { TrailerId = 6, TyreId = 5 },
                       new { TrailerId = 6, TyreId = 7 },

                       //PALMS 10DWD
                       new { TrailerId = 7, TyreId = 4 },
                       new { TrailerId = 7, TyreId = 6 },
                       new { TrailerId = 7, TyreId = 8 },

                       //PALMS 12D
                       new { TrailerId = 8, TyreId = 6 },
                       new { TrailerId = 8, TyreId = 8 },
                       new { TrailerId = 8, TyreId = 9 },
                       new { TrailerId = 8, TyreId = 10 },

                       //PALMS 12DWD
                       new { TrailerId = 9, TyreId = 6 },
                       new { TrailerId = 9, TyreId = 8 },
                       new { TrailerId = 9, TyreId = 9 },
                       new { TrailerId = 9, TyreId = 10 },

                       //PALMS 14D
                       new { TrailerId = 10, TyreId = 6 },
                       new { TrailerId = 10, TyreId = 8 },
                       new { TrailerId = 10, TyreId = 9 },
                       new { TrailerId = 10, TyreId = 12 },

                       //PALMS 14DWD
                       new { TrailerId = 11, TyreId = 6 },
                       new { TrailerId = 11, TyreId = 8 },
                       new { TrailerId = 11, TyreId = 9 },
                       new { TrailerId = 11, TyreId = 10 },
                       new { TrailerId = 11, TyreId = 11 },
                       new { TrailerId = 11, TyreId = 12 }
                   )

               );
        }
    }
}
