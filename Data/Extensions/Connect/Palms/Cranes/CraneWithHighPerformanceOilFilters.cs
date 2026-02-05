using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithHighPerformanceOilFilters
    {
        public static void ConnectCranesWithHighPerformanceOilFilters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.HighPerformanceOilFilter)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("HighPerformanceOilFilterCrane")
                    .HasData
                    (
                        //PALMS 2.42

                        //PALMS 2.54
                        new { CraneId = 2, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 2, HighPerformanceOilFilterId = 2 },

                        //PALMS 3.61
                        new { CraneId = 3, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 3, HighPerformanceOilFilterId = 2 },

                        //PALMS 3.67
                        new { CraneId = 4, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 4, HighPerformanceOilFilterId = 2 },

                        //PALMS 4.71
                        new { CraneId = 5, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 5, HighPerformanceOilFilterId = 2 },

                        //PALMS 5.72
                        new { CraneId = 6, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 6, HighPerformanceOilFilterId = 2 },

                        //PALMS 5.85
                        new { CraneId = 7, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 7, HighPerformanceOilFilterId = 2 },

                        //PALMS 5.87Z
                        new { CraneId = 8, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 8, HighPerformanceOilFilterId = 2 },

                        //PALMS 7.75
                        new { CraneId = 9, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 9, HighPerformanceOilFilterId = 2 },

                        //PALMS 7.86
                        new { CraneId = 10, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 10, HighPerformanceOilFilterId = 2 },

                        //PALMS 7.94
                        new { CraneId = 11, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 11, HighPerformanceOilFilterId = 2 },

                        //PALMS X100
                        new { CraneId = 12, HighPerformanceOilFilterId = 1 },
                        new { CraneId = 12, HighPerformanceOilFilterId = 2 }

                        //PALMS 1.42
                    )
                );
        }
    }
}
