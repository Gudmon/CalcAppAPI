using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithCovers
    {
        public static void ConnectCranesWithCovers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Covers)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("CoverCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, CoversId = 1 },
                        new { CraneId = 1, CoversId = 2 },

                        //PALMS 2.54
                        new { CraneId = 2, CoversId = 1 },
                        new { CraneId = 2, CoversId = 2 },

                        //PALMS 3.63
                        new { CraneId = 3, CoversId = 1 },
                        new { CraneId = 3, CoversId = 2 },

                        //PALMS 3.67
                        new { CraneId = 4, CoversId = 1 },
                        new { CraneId = 4, CoversId = 2 },

                        //PALMS 4.71
                        new { CraneId = 5, CoversId = 1 },
                        new { CraneId = 5, CoversId = 2 },

                        //PALMS 5.75
                        new { CraneId = 6, CoversId = 1 },
                        new { CraneId = 6, CoversId = 2 },

                        //PALMS 5.85
                        new { CraneId = 7, CoversId = 1 },
                        new { CraneId = 7, CoversId = 2 },

                        //PALMS 6.83Z
                        new { CraneId = 8, CoversId = 1 },
                        new { CraneId = 8, CoversId = 2 },

                        //PALMS 7.78
                        new { CraneId = 9, CoversId = 1 },
                        new { CraneId = 9, CoversId = 2 },

                        //PALMS 7.87
                        new { CraneId = 10, CoversId = 1 },
                        new { CraneId = 10, CoversId = 2 },

                        //PALMS 7.94
                        new { CraneId = 11, CoversId = 1 },
                        new { CraneId = 11, CoversId = 2 },

                        //PALMS X100
                        new { CraneId = 12, CoversId = 1 },
                        new { CraneId = 12, CoversId = 2 },

                        //PALMS 1.42

                        //PALMS 8.87Z
                        new { CraneId = 14, CoversId = 1 },
                        new { CraneId = 14, CoversId = 2 }
                    )
                );
        }
    }
}
