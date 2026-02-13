using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithWinches
    {
        public static void ConnectCranesWithWinches(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Winch)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("WinchCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, WinchId = 1 },
                        new { CraneId = 1, WinchId = 2 },

                        //PALMS 2.54
                        new { CraneId = 2, WinchId = 1 },
                        new { CraneId = 2, WinchId = 2 },

                        //PALMS 3.61
                        new { CraneId = 3, WinchId = 1 },
                        new { CraneId = 3, WinchId = 2 },

                        //PALMS 3.67
                        new { CraneId = 4, WinchId = 1 },
                        new { CraneId = 4, WinchId = 2 },
                        new { CraneId = 4, WinchId = 3 },

                        //PALMS 4.71
                        new { CraneId = 5, WinchId = 1 },
                        new { CraneId = 5, WinchId = 2 },
                        new { CraneId = 5, WinchId = 3 },

                        //PALMS 5.72
                        new { CraneId = 6, WinchId = 1 },
                        new { CraneId = 6, WinchId = 2 },
                        new { CraneId = 6, WinchId = 3 },

                        //PALMS 5.85
                        new { CraneId = 7, WinchId = 1 },
                        new { CraneId = 7, WinchId = 2 },
                        new { CraneId = 7, WinchId = 3 },

                        //PALMS 5.87Z
                        new { CraneId = 8, WinchId = 1 },
                        new { CraneId = 8, WinchId = 2 },
                        new { CraneId = 8, WinchId = 3 },

                        //PALMS 7.75
                        new { CraneId = 9, WinchId = 1 },
                        new { CraneId = 9, WinchId = 2 },
                        new { CraneId = 9, WinchId = 3 },

                        //PALMS 7.86
                        new { CraneId = 10, WinchId = 1 },
                        new { CraneId = 10, WinchId = 2 },
                        new { CraneId = 10, WinchId = 3 },

                        //PALMS 7.94
                        new { CraneId = 11, WinchId = 1 },
                        new { CraneId = 11, WinchId = 2 },
                        new { CraneId = 11, WinchId = 3 },

                        //PALMS X100
                        new { CraneId = 12, WinchId = 1 },
                        new { CraneId = 12, WinchId = 2 },
                        new { CraneId = 12, WinchId = 3 },

                        //PALMS 1.42
                        new { CraneId = 13, WinchId = 4 }
                    )
                );
        }
    }
}
