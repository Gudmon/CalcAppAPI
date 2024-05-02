using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithRotators
    {
        public static void ConnectCranesWithRotators(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Rotator)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("RotatorCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, RotatorId = 1 },
                        new { CraneId = 1, RotatorId = 2 },
                        new { CraneId = 1, RotatorId = 3 },
                        new { CraneId = 1, RotatorId = 4 },

                        //PALMS 2.54
                        new { CraneId = 2, RotatorId = 1 },
                        new { CraneId = 2, RotatorId = 2 },
                        new { CraneId = 2, RotatorId = 3 },
                        new { CraneId = 2, RotatorId = 4 },

                        //PALMS 3.61
                        new { CraneId = 3, RotatorId = 1 },
                        new { CraneId = 3, RotatorId = 2 },
                        new { CraneId = 3, RotatorId = 3 },
                        new { CraneId = 3, RotatorId = 4 },

                        //PALMS 3.67
                        new { CraneId = 4, RotatorId = 1 },
                        new { CraneId = 4, RotatorId = 2 },
                        new { CraneId = 4, RotatorId = 3 },
                        new { CraneId = 4, RotatorId = 4 },

                        //PALMS 4.71
                        new { CraneId = 5, RotatorId = 1 },
                        new { CraneId = 5, RotatorId = 2 },
                        new { CraneId = 5, RotatorId = 3 },
                        new { CraneId = 5, RotatorId = 4 },

                        //PALMS 5.72
                        new { CraneId = 6, RotatorId = 1 },
                        new { CraneId = 6, RotatorId = 4 },
                        new { CraneId = 6, RotatorId = 5 },
                        new { CraneId = 6, RotatorId = 6 },

                        //PALMS 5.85
                        new { CraneId = 7, RotatorId = 1 },
                        new { CraneId = 7, RotatorId = 4 },
                        new { CraneId = 7, RotatorId = 5 },
                        new { CraneId = 7, RotatorId = 6 },

                        //PALMS 5.87Z
                        new { CraneId = 8, RotatorId = 1 },
                        new { CraneId = 8, RotatorId = 4 },
                        new { CraneId = 8, RotatorId = 5 },
                        new { CraneId = 8, RotatorId = 6 },

                        //PALMS 7.75
                        new { CraneId = 9, RotatorId = 1 },
                        new { CraneId = 9, RotatorId = 5 },
                        new { CraneId = 9, RotatorId = 6 },
                        new { CraneId = 9, RotatorId = 7 },

                        //PALMS 7.86
                        new { CraneId = 10, RotatorId = 1 },
                        new { CraneId = 10, RotatorId = 5 },
                        new { CraneId = 10, RotatorId = 6 },
                        new { CraneId = 10, RotatorId = 7 },

                         //PALMS 7.94
                        new { CraneId = 11, RotatorId = 1 },
                        new { CraneId = 11, RotatorId = 5 },
                        new { CraneId = 11, RotatorId = 6 },
                        new { CraneId = 11, RotatorId = 7 },

                        //PALMS X100
                        new { CraneId = 12, RotatorId = 1 },
                        new { CraneId = 12, RotatorId = 6 },
                        new { CraneId = 12, RotatorId = 7 },

                        //PALMS 1.42
                        new { CraneId = 13, RotatorId = 8 }
                    )
                );
        }
    }
}
