using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
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
                        new { TrailerId = 11, DrawbarId = 9 },

                        //PALMS 10U
                        new { TrailerId = 12, DrawbarId = 1 },
                        new { TrailerId = 12, DrawbarId = 2 },
                        new { TrailerId = 12, DrawbarId = 3 },
                        new { TrailerId = 12, DrawbarId = 4 },
                        new { TrailerId = 12, DrawbarId = 5 },
                        new { TrailerId = 12, DrawbarId = 6 },
                        new { TrailerId = 12, DrawbarId = 8 },
                        new { TrailerId = 12, DrawbarId = 9 },

                        //PALMS 10UWD
                        new { TrailerId = 13, DrawbarId = 1 },
                        new { TrailerId = 13, DrawbarId = 2 },
                        new { TrailerId = 13, DrawbarId = 3 },
                        new { TrailerId = 13, DrawbarId = 4 },
                        new { TrailerId = 13, DrawbarId = 5 },
                        new { TrailerId = 13, DrawbarId = 6 },
                        new { TrailerId = 13, DrawbarId = 8 },
                        new { TrailerId = 13, DrawbarId = 9 },

                        //PALMS 12U
                        new { TrailerId = 14, DrawbarId = 1 },
                        new { TrailerId = 14, DrawbarId = 2 },
                        new { TrailerId = 14, DrawbarId = 3 },
                        new { TrailerId = 14, DrawbarId = 4 },
                        new { TrailerId = 14, DrawbarId = 5 },
                        new { TrailerId = 14, DrawbarId = 6 },
                        new { TrailerId = 14, DrawbarId = 8 },
                        new { TrailerId = 14, DrawbarId = 9 },

                        //PALMS 12UWD
                        new { TrailerId = 15, DrawbarId = 1 },
                        new { TrailerId = 15, DrawbarId = 2 },
                        new { TrailerId = 15, DrawbarId = 3 },
                        new { TrailerId = 15, DrawbarId = 4 },
                        new { TrailerId = 15, DrawbarId = 5 },
                        new { TrailerId = 15, DrawbarId = 6 },
                        new { TrailerId = 15, DrawbarId = 8 },
                        new { TrailerId = 15, DrawbarId = 9 },

                        //PALMS 12UAWD
                        new { TrailerId = 16, DrawbarId = 1 },
                        new { TrailerId = 16, DrawbarId = 2 },
                        new { TrailerId = 16, DrawbarId = 3 },
                        new { TrailerId = 16, DrawbarId = 4 },
                        new { TrailerId = 16, DrawbarId = 5 },
                        new { TrailerId = 16, DrawbarId = 6 },
                        new { TrailerId = 16, DrawbarId = 8 },
                        new { TrailerId = 16, DrawbarId = 9 },

                        //PALMS 15U
                        new { TrailerId = 17, DrawbarId = 1 },
                        new { TrailerId = 17, DrawbarId = 2 },
                        new { TrailerId = 17, DrawbarId = 3 },
                        new { TrailerId = 17, DrawbarId = 4 },
                        new { TrailerId = 17, DrawbarId = 5 },
                        new { TrailerId = 17, DrawbarId = 6 },
                        new { TrailerId = 17, DrawbarId = 8 },
                        new { TrailerId = 17, DrawbarId = 9 },

                        //PALMS 15UWD
                        new { TrailerId = 18, DrawbarId = 1 },
                        new { TrailerId = 18, DrawbarId = 2 },
                        new { TrailerId = 18, DrawbarId = 3 },
                        new { TrailerId = 18, DrawbarId = 4 },
                        new { TrailerId = 18, DrawbarId = 5 },
                        new { TrailerId = 18, DrawbarId = 6 },
                        new { TrailerId = 18, DrawbarId = 8 },
                        new { TrailerId = 18, DrawbarId = 9 },

                        //PALMS 15UAWD
                        new { TrailerId = 19, DrawbarId = 1 },
                        new { TrailerId = 19, DrawbarId = 2 },
                        new { TrailerId = 19, DrawbarId = 3 },
                        new { TrailerId = 19, DrawbarId = 4 },
                        new { TrailerId = 19, DrawbarId = 5 },
                        new { TrailerId = 19, DrawbarId = 6 },
                        new { TrailerId = 19, DrawbarId = 8 },
                        new { TrailerId = 19, DrawbarId = 9 },

                        //PALMS MWD3.2
                        new { TrailerId = 20, DrawbarId = 1 },
                        new { TrailerId = 20, DrawbarId = 3 },
                        new { TrailerId = 20, DrawbarId = 10 },
                        new { TrailerId = 20, DrawbarId = 11 },
                        new { TrailerId = 20, DrawbarId = 12 },
                        new { TrailerId = 20, DrawbarId = 13 },

                        //PALMS HMWD3.2
                        new { TrailerId = 21, DrawbarId = 1 },
                        new { TrailerId = 21, DrawbarId = 3 },
                        new { TrailerId = 21, DrawbarId = 10 },
                        new { TrailerId = 21, DrawbarId = 11 },
                        new { TrailerId = 21, DrawbarId = 12 },
                        new { TrailerId = 21, DrawbarId = 13 },

                        //PALMS 2D
                        new { TrailerId = 22, DrawbarId = 1 }
                    )
                );
        }
    }
}
