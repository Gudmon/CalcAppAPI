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
                        new { CraneId = 5, RotatorId = 4 }
                    )
                );
        }
    }
}
