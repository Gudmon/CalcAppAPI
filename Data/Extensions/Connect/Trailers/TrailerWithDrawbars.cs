using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Trailers
{
    public static class TrailerWithDrawbars
    {
        public static void ConnectTrailersWithDrawbars(this ModelBuilder modelBuilder)
        {
            // DRAWBARS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Drawbar)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("DrawbarTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, DrawbarId = 1 },
                        new { TrailerId = 1, DrawbarId = 2 },
                        new { TrailerId = 1, DrawbarId = 3 },
                        new { TrailerId = 1, DrawbarId = 4 },
                        new { TrailerId = 1, DrawbarId = 5 },
                        new { TrailerId = 1, DrawbarId = 9 },

                        //PALMS 8SX
                        new { TrailerId = 2, DrawbarId = 1 },
                        new { TrailerId = 2, DrawbarId = 2 },
                        new { TrailerId = 2, DrawbarId = 3 },
                        new { TrailerId = 2, DrawbarId = 4 },
                        new { TrailerId = 2, DrawbarId = 5 },
                        new { TrailerId = 2, DrawbarId = 6 },
                        new { TrailerId = 2, DrawbarId = 7 },
                        new { TrailerId = 2, DrawbarId = 9 },

                        //PALMS 8D
                        new { TrailerId = 3, DrawbarId = 1 },
                        new { TrailerId = 3, DrawbarId = 2 },
                        new { TrailerId = 3, DrawbarId = 3 },
                        new { TrailerId = 3, DrawbarId = 4 },
                        new { TrailerId = 3, DrawbarId = 5 },
                        new { TrailerId = 3, DrawbarId = 6 },
                        new { TrailerId = 3, DrawbarId = 9 },

                        //PALMS 8DWD
                        new { TrailerId = 4, DrawbarId = 1 },
                        new { TrailerId = 4, DrawbarId = 2 },
                        new { TrailerId = 4, DrawbarId = 3 },
                        new { TrailerId = 4, DrawbarId = 4 },
                        new { TrailerId = 4, DrawbarId = 5 },
                        new { TrailerId = 4, DrawbarId = 6 },
                        new { TrailerId = 4, DrawbarId = 9 },

                        //PALMS 9SC
                        new { TrailerId = 5, DrawbarId = 1 },
                        new { TrailerId = 5, DrawbarId = 2 },
                        new { TrailerId = 5, DrawbarId = 3 },
                        new { TrailerId = 5, DrawbarId = 4 },
                        new { TrailerId = 5, DrawbarId = 5 },
                        new { TrailerId = 5, DrawbarId = 6 },
                        new { TrailerId = 5, DrawbarId = 9 },

                        //PALMS 10D
                        new { TrailerId = 6, DrawbarId = 1 },
                        new { TrailerId = 6, DrawbarId = 2 },
                        new { TrailerId = 6, DrawbarId = 3 },
                        new { TrailerId = 6, DrawbarId = 4 },
                        new { TrailerId = 6, DrawbarId = 5 },
                        new { TrailerId = 6, DrawbarId = 6 },
                        new { TrailerId = 6, DrawbarId = 9 },

                        //PALMS 10DWD
                        new { TrailerId = 7, DrawbarId = 1 },
                        new { TrailerId = 7, DrawbarId = 2 },
                        new { TrailerId = 7, DrawbarId = 3 },
                        new { TrailerId = 7, DrawbarId = 4 },
                        new { TrailerId = 7, DrawbarId = 5 },
                        new { TrailerId = 7, DrawbarId = 6 },
                        new { TrailerId = 7, DrawbarId = 9 },

                        //PALMS 12D
                        new { TrailerId = 8, DrawbarId = 1 },
                        new { TrailerId = 8, DrawbarId = 2 },
                        new { TrailerId = 8, DrawbarId = 3 },
                        new { TrailerId = 8, DrawbarId = 4 },
                        new { TrailerId = 8, DrawbarId = 5 },
                        new { TrailerId = 8, DrawbarId = 6 },
                        new { TrailerId = 8, DrawbarId = 8 },
                        new { TrailerId = 8, DrawbarId = 9 },

                        //PALMS 12DWD
                        new { TrailerId = 9, DrawbarId = 1 },
                        new { TrailerId = 9, DrawbarId = 2 },
                        new { TrailerId = 9, DrawbarId = 3 },
                        new { TrailerId = 9, DrawbarId = 4 },
                        new { TrailerId = 9, DrawbarId = 5 },
                        new { TrailerId = 9, DrawbarId = 6 },
                        new { TrailerId = 9, DrawbarId = 8 },
                        new { TrailerId = 9, DrawbarId = 9 },

                        //PALMS 14D
                        new { TrailerId = 10, DrawbarId = 1 },
                        new { TrailerId = 10, DrawbarId = 2 },
                        new { TrailerId = 10, DrawbarId = 3 },
                        new { TrailerId = 10, DrawbarId = 4 },
                        new { TrailerId = 10, DrawbarId = 5 },
                        new { TrailerId = 10, DrawbarId = 6 },
                        new { TrailerId = 10, DrawbarId = 8 },
                        new { TrailerId = 10, DrawbarId = 9 },

                        //PALMS 14DWD
                        new { TrailerId = 11, DrawbarId = 1 },
                        new { TrailerId = 11, DrawbarId = 2 },
                        new { TrailerId = 11, DrawbarId = 3 },
                        new { TrailerId = 11, DrawbarId = 4 },
                        new { TrailerId = 11, DrawbarId = 5 },
                        new { TrailerId = 11, DrawbarId = 6 },
                        new { TrailerId = 11, DrawbarId = 8 },
                        new { TrailerId = 11, DrawbarId = 9 }
                    )

                );
        }
    }
}
