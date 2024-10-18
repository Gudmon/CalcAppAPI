using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
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

                       //PALMS 9SC
                       new { TrailerId = 4, TyreId = 1 },
                       new { TrailerId = 4, TyreId = 2 },
                       new { TrailerId = 4, TyreId = 3 },
                       new { TrailerId = 4, TyreId = 5 },
                       new { TrailerId = 4, TyreId = 7 },

                       //PALMS 10D
                       new { TrailerId = 5, TyreId = 1 },
                       new { TrailerId = 5, TyreId = 2 },
                       new { TrailerId = 5, TyreId = 3 },
                       new { TrailerId = 5, TyreId = 5 },
                       new { TrailerId = 5, TyreId = 7 },

                       //PALMS 12D
                       new { TrailerId = 6, TyreId = 6 },
                       new { TrailerId = 6, TyreId = 8 },
                       new { TrailerId = 6, TyreId = 9 },
                       new { TrailerId = 6, TyreId = 10 },

                       //PALMS 14D
                       new { TrailerId = 7, TyreId = 6 },
                       new { TrailerId = 7, TyreId = 8 },
                       new { TrailerId = 7, TyreId = 9 },
                       new { TrailerId = 7, TyreId = 12 },

                       //PALMS 10U
                       new { TrailerId = 8, TyreId = 3 },
                       new { TrailerId = 8, TyreId = 5 },
                       new { TrailerId = 8, TyreId = 7 },

                       //PALMS 12U
                       new { TrailerId = 9, TyreId = 6 },
                       new { TrailerId = 9, TyreId = 8 },
                       new { TrailerId = 9, TyreId = 9 },
                       new { TrailerId = 9, TyreId = 10 },
                       new { TrailerId = 9, TyreId = 11 },
                       new { TrailerId = 9, TyreId = 12 },

                       //PALMS 12UAWD
                       new { TrailerId = 10, TyreId = 8 },
                       new { TrailerId = 10, TyreId = 9 },
                       new { TrailerId = 10, TyreId = 10 },
                       new { TrailerId = 10, TyreId = 11 },
                       new { TrailerId = 10, TyreId = 12 },

                       //PALMS 15U
                       new { TrailerId = 11, TyreId = 8 },
                       new { TrailerId = 11, TyreId = 9 },
                       new { TrailerId = 11, TyreId = 10 },
                       new { TrailerId = 11, TyreId = 11 },
                       new { TrailerId = 11, TyreId = 12 },

                       //PALMS 15UAWD
                       new { TrailerId = 12, TyreId = 8 },
                       new { TrailerId = 12, TyreId = 9 },
                       new { TrailerId = 12, TyreId = 10 },
                       new { TrailerId = 12, TyreId = 11 },
                       new { TrailerId = 12, TyreId = 12 },

                       //PALMS MWD3.2
                       new { TrailerId = 13, TyreId = 13 },
                       new { TrailerId = 13, TyreId = 14 },

                       //PALMS HMWD3.2
                       new { TrailerId = 14, TyreId = 13 },
                       new { TrailerId = 14, TyreId = 14 },

                       //PALMS 2D
                       new { TrailerId = 15, TyreId = 15 }
                   )
               );
        }
    }
}
