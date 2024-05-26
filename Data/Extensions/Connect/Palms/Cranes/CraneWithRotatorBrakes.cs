using CalcAppAPI.Models.Machine.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithRotatorBrakes
    {
        public static void ConnectCranesWithRotatorBrakes(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.RotatorBrake)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("RotatorBrakeCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, RotatorBrakeId = 1 },
                        new { CraneId = 1, RotatorBrakeId = 2 },
                        new { CraneId = 1, RotatorBrakeId = 4 },

                        //PALMS 2.54
                        new { CraneId = 2, RotatorBrakeId = 1 },
                        new { CraneId = 2, RotatorBrakeId = 2 },
                        new { CraneId = 2, RotatorBrakeId = 4 },

                        //PALMS 3.61
                        new { CraneId = 3, RotatorBrakeId = 1 },
                        new { CraneId = 3, RotatorBrakeId = 2 },
                        new { CraneId = 3, RotatorBrakeId = 4 },

                        //PALMS 3.67
                        new { CraneId = 4, RotatorBrakeId = 1 },
                        new { CraneId = 4, RotatorBrakeId = 2 },
                        new { CraneId = 4, RotatorBrakeId = 4 },

                        //PALMS 4.71
                        new { CraneId = 5, RotatorBrakeId = 1 },
                        new { CraneId = 5, RotatorBrakeId = 2 },
                        new { CraneId = 5, RotatorBrakeId = 4 },

                        //PALMS 5.72
                        new { CraneId = 6, RotatorBrakeId = 1 },
                        new { CraneId = 6, RotatorBrakeId = 3 },
                        new { CraneId = 6, RotatorBrakeId = 5 },

                        //PALMS 5.85
                        new { CraneId = 7, RotatorBrakeId = 1 },
                        new { CraneId = 7, RotatorBrakeId = 3 },
                        new { CraneId = 7, RotatorBrakeId = 5 },

                        //PALMS 5.87Z
                        new { CraneId = 8, RotatorBrakeId = 1 },
                        new { CraneId = 8, RotatorBrakeId = 3 },
                        new { CraneId = 8, RotatorBrakeId = 5 },

                        //PALMS 7.75
                        new { CraneId = 9, RotatorBrakeId = 1 },
                        new { CraneId = 9, RotatorBrakeId = 3 },
                        new { CraneId = 9, RotatorBrakeId = 5 },

                        //PALMS 7.86
                        new { CraneId = 10, RotatorBrakeId = 1 },
                        new { CraneId = 10, RotatorBrakeId = 3 },
                        new { CraneId = 10, RotatorBrakeId = 5 },

                        //PALMS 7.94
                        new { CraneId = 11, RotatorBrakeId = 1 },
                        new { CraneId = 11, RotatorBrakeId = 3 },
                        new { CraneId = 11, RotatorBrakeId = 5 },

                        //PALMS X100
                        new { CraneId = 12, RotatorBrakeId = 1 },
                        new { CraneId = 12, RotatorBrakeId = 3 },
                        new { CraneId = 12, RotatorBrakeId = 5 }
                    )
                );
        }
    }
}
