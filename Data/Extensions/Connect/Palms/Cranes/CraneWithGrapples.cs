using CalcAppAPI.Models.Machine.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithGrapples
    {
        public static void ConnectCranesWithGrapples(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Grapple)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("GrappleCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, GrappleId = 1 },
                        new { CraneId = 1, GrappleId = 2 },
                        new { CraneId = 1, GrappleId = 3 },
                        new { CraneId = 1, GrappleId = 13 },
                        new { CraneId = 1, GrappleId = 14 },

                        //PALMS 2.54
                        new { CraneId = 2, GrappleId = 1 },
                        new { CraneId = 2, GrappleId = 2 },
                        new { CraneId = 2, GrappleId = 3 },
                        new { CraneId = 2, GrappleId = 13 },
                        new { CraneId = 2, GrappleId = 14 },

                        //PALMS 3.63
                        new { CraneId = 3, GrappleId = 1 },
                        new { CraneId = 3, GrappleId = 2 },
                        new { CraneId = 3, GrappleId = 3 },
                        new { CraneId = 3, GrappleId = 13 },
                        new { CraneId = 3, GrappleId = 14 },

                        //PALMS 3.67
                        new { CraneId = 4, GrappleId = 1 },
                        new { CraneId = 4, GrappleId = 2 },
                        new { CraneId = 4, GrappleId = 3 },
                        new { CraneId = 4, GrappleId = 4 },
                        new { CraneId = 4, GrappleId = 7 },
                        new { CraneId = 4, GrappleId = 13 },
                        new { CraneId = 4, GrappleId = 14 },
                        new { CraneId = 4, GrappleId = 15 },

                        //PALMS 4.71
                        new { CraneId = 5, GrappleId = 1 },
                        new { CraneId = 5, GrappleId = 2 },
                        new { CraneId = 5, GrappleId = 3 },
                        new { CraneId = 5, GrappleId = 4 },
                        new { CraneId = 5, GrappleId = 7 },
                        new { CraneId = 5, GrappleId = 12 },
                        new { CraneId = 5, GrappleId = 13 },
                        new { CraneId = 5, GrappleId = 14 },
                        new { CraneId = 5, GrappleId = 15 },

                        //PALMS 5.75
                        new { CraneId = 6, GrappleId = 1 },
                        new { CraneId = 6, GrappleId = 3 },
                        new { CraneId = 6, GrappleId = 4 },
                        new { CraneId = 6, GrappleId = 5 },
                        new { CraneId = 6, GrappleId = 6 },
                        new { CraneId = 6, GrappleId = 7 },
                        new { CraneId = 6, GrappleId = 8 },
                        new { CraneId = 6, GrappleId = 9 },
                        new { CraneId = 6, GrappleId = 10 },
                        new { CraneId = 6, GrappleId = 11 },
                        new { CraneId = 6, GrappleId = 12 },
                        new { CraneId = 6, GrappleId = 14 },
                        new { CraneId = 6, GrappleId = 15 },

                        //PALMS 5.85
                        new { CraneId = 7, GrappleId = 1 },
                        new { CraneId = 7, GrappleId = 3 },
                        new { CraneId = 7, GrappleId = 4 },
                        new { CraneId = 7, GrappleId = 5 },
                        new { CraneId = 7, GrappleId = 6 },
                        new { CraneId = 7, GrappleId = 7 },
                        new { CraneId = 7, GrappleId = 8 },
                        new { CraneId = 7, GrappleId = 9 },
                        new { CraneId = 7, GrappleId = 10 },
                        new { CraneId = 7, GrappleId = 11 },
                        new { CraneId = 7, GrappleId = 12 },
                        new { CraneId = 7, GrappleId = 14 },
                        new { CraneId = 7, GrappleId = 15 },

                        //PALMS 5.87Z
                        new { CraneId = 8, GrappleId = 1 },
                        new { CraneId = 8, GrappleId = 3 },
                        new { CraneId = 8, GrappleId = 4 },
                        new { CraneId = 8, GrappleId = 5 },
                        new { CraneId = 8, GrappleId = 6 },
                        new { CraneId = 8, GrappleId = 7 },
                        new { CraneId = 8, GrappleId = 8 },
                        new { CraneId = 8, GrappleId = 9 },
                        new { CraneId = 8, GrappleId = 10 },
                        new { CraneId = 8, GrappleId = 11 },
                        new { CraneId = 8, GrappleId = 14 },
                        new { CraneId = 8, GrappleId = 15 },

                        //PALMS 7.78
                        new { CraneId = 9, GrappleId = 1 },
                        new { CraneId = 9, GrappleId = 4 },
                        new { CraneId = 9, GrappleId = 5 },
                        new { CraneId = 9, GrappleId = 6 },
                        new { CraneId = 9, GrappleId = 7 },
                        new { CraneId = 9, GrappleId = 8 },
                        new { CraneId = 9, GrappleId = 9 },
                        new { CraneId = 9, GrappleId = 10 },
                        new { CraneId = 9, GrappleId = 11 },
                        new { CraneId = 9, GrappleId = 15 },

                        //PALMS 7.87
                        new { CraneId = 10, GrappleId = 1 },
                        new { CraneId = 10, GrappleId = 4 },
                        new { CraneId = 10, GrappleId = 5 },
                        new { CraneId = 10, GrappleId = 6 },
                        new { CraneId = 10, GrappleId = 7 },
                        new { CraneId = 10, GrappleId = 8 },
                        new { CraneId = 10, GrappleId = 9 },
                        new { CraneId = 10, GrappleId = 10 },
                        new { CraneId = 10, GrappleId = 11 },
                        new { CraneId = 10, GrappleId = 15 },

                        //PALMS 7.94
                        new { CraneId = 11, GrappleId = 1 },
                        new { CraneId = 11, GrappleId = 4 },
                        new { CraneId = 11, GrappleId = 5 },
                        new { CraneId = 11, GrappleId = 6 },
                        new { CraneId = 11, GrappleId = 7 },
                        new { CraneId = 11, GrappleId = 8 },
                        new { CraneId = 11, GrappleId = 9 },
                        new { CraneId = 11, GrappleId = 10 },
                        new { CraneId = 11, GrappleId = 11 },
                        new { CraneId = 11, GrappleId = 15 },

                        //PALMS X100
                        new { CraneId = 12, GrappleId = 1 },
                        new { CraneId = 12, GrappleId = 4 },
                        new { CraneId = 12, GrappleId = 5 },
                        new { CraneId = 12, GrappleId = 6 },
                        new { CraneId = 12, GrappleId = 7 },
                        new { CraneId = 12, GrappleId = 8 },
                        new { CraneId = 12, GrappleId = 9 },
                        new { CraneId = 12, GrappleId = 10 },
                        new { CraneId = 12, GrappleId = 11 },
                        new { CraneId = 12, GrappleId = 15 },

                        //PALMS 1.42
                        new { CraneId = 13, GrappleId = 16 }
                    )
                );
        }
    }
}
