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
                       new { TrailerId = 11, TyreId = 12 },

                       //PALMS 10U
                       new { TrailerId = 12, TyreId = 3 },
                       new { TrailerId = 12, TyreId = 5 },
                       new { TrailerId = 12, TyreId = 7 },

                       //PALMS 10UWD
                       new { TrailerId = 13, TyreId = 6 },
                       new { TrailerId = 13, TyreId = 8 },
                       new { TrailerId = 13, TyreId = 9 },
                       new { TrailerId = 13, TyreId = 10 },

                       //PALMS 12U
                       new { TrailerId = 14, TyreId = 6 },
                       new { TrailerId = 14, TyreId = 8 },
                       new { TrailerId = 14, TyreId = 9 },
                       new { TrailerId = 14, TyreId = 10 },
                       new { TrailerId = 14, TyreId = 11 },
                       new { TrailerId = 14, TyreId = 12 },

                       //PALMS 12UWD
                       new { TrailerId = 15, TyreId = 6 },
                       new { TrailerId = 15, TyreId = 8 },
                       new { TrailerId = 15, TyreId = 9 },
                       new { TrailerId = 15, TyreId = 10 },
                       new { TrailerId = 15, TyreId = 11 },
                       new { TrailerId = 15, TyreId = 12 },

                       //PALMS 12UAWD
                       new { TrailerId = 16, TyreId = 8 },
                       new { TrailerId = 16, TyreId = 9 },
                       new { TrailerId = 16, TyreId = 10 },
                       new { TrailerId = 16, TyreId = 11 },
                       new { TrailerId = 16, TyreId = 12 },

                       //PALMS 15U
                       new { TrailerId = 17, TyreId = 8 },
                       new { TrailerId = 17, TyreId = 9 },
                       new { TrailerId = 17, TyreId = 10 },
                       new { TrailerId = 17, TyreId = 11 },
                       new { TrailerId = 17, TyreId = 12 },

                       //PALMS 15UWD
                       new { TrailerId = 18, TyreId = 8 },
                       new { TrailerId = 18, TyreId = 9 },
                       new { TrailerId = 18, TyreId = 10 },
                       new { TrailerId = 18, TyreId = 11 },
                       new { TrailerId = 18, TyreId = 12 },

                       //PALMS 15UAWD
                       new { TrailerId = 19, TyreId = 8 },
                       new { TrailerId = 19, TyreId = 9 },
                       new { TrailerId = 19, TyreId = 10 },
                       new { TrailerId = 19, TyreId = 11 },
                       new { TrailerId = 19, TyreId = 12 },

                       //PALMS MWD3.2
                       new { TrailerId = 20, TyreId = 13 },
                       new { TrailerId = 20, TyreId = 14 },

                       //PALMS MWD3.2L
                       new { TrailerId = 21, TyreId = 13 },
                       new { TrailerId = 21, TyreId = 14 },

                       //PALMS HMWD3.2
                       new { TrailerId = 22, TyreId = 13 },
                       new { TrailerId = 22, TyreId = 14 },

                       //PALMS HMWD3.2L
                       new { TrailerId = 23, TyreId = 13 },
                       new { TrailerId = 23, TyreId = 14 }
                   )
               );
        }
    }
}
