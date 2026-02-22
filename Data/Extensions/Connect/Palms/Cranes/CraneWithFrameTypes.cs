using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithFrameTypes
    {
        public static void ConnectCranesWithFrameTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.FrameType)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("FrameTypeCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, FrameTypeId = 1 },
                        new { CraneId = 1, FrameTypeId = 2 },

                        //PALMS 2.54
                        new { CraneId = 2, FrameTypeId = 1 },
                        new { CraneId = 2, FrameTypeId = 2 },

                        //PALMS 3.63
                        new { CraneId = 3, FrameTypeId = 1 },
                        new { CraneId = 3, FrameTypeId = 2 },

                        //PALMS 3.67
                        new { CraneId = 4, FrameTypeId = 1 },
                        new { CraneId = 4, FrameTypeId = 3 },
                        new { CraneId = 4, FrameTypeId = 4 },
                        new { CraneId = 4, FrameTypeId = 5 },

                        //PALMS 4.71
                        new { CraneId = 5, FrameTypeId = 1 },
                        new { CraneId = 5, FrameTypeId = 3 },
                        new { CraneId = 5, FrameTypeId = 4 },
                        new { CraneId = 5, FrameTypeId = 5 },

                        //PALMS 5.75
                        new { CraneId = 6, FrameTypeId = 1 },
                        new { CraneId = 6, FrameTypeId = 3 },
                        new { CraneId = 6, FrameTypeId = 5 },
                        new { CraneId = 6, FrameTypeId = 6 },
                        new { CraneId = 6, FrameTypeId = 8 },

                        //PALMS 5.85
                        new { CraneId = 7, FrameTypeId = 1 },
                        new { CraneId = 7, FrameTypeId = 3 },
                        new { CraneId = 7, FrameTypeId = 5 },
                        new { CraneId = 7, FrameTypeId = 6 },
                        new { CraneId = 7, FrameTypeId = 8 },

                        //PALMS 5.87Z
                        new { CraneId = 8, FrameTypeId = 7 },

                        //PALMS 7.78
                        new { CraneId = 9, FrameTypeId = 1 },
                        new { CraneId = 9, FrameTypeId = 5 },
                        new { CraneId = 9, FrameTypeId = 6 },
                        new { CraneId = 9, FrameTypeId = 8 },

                        //PALMS 7.87
                        new { CraneId = 10, FrameTypeId = 1 },
                        new { CraneId = 10, FrameTypeId = 5 },
                        new { CraneId = 10, FrameTypeId = 6 },
                        new { CraneId = 10, FrameTypeId = 8 },

                        //PALMS 7.94
                        new { CraneId = 11, FrameTypeId = 1 },
                        new { CraneId = 11, FrameTypeId = 6 },
                        new { CraneId = 11, FrameTypeId = 8 },

                        //PALMS X100
                        new { CraneId = 12, FrameTypeId = 1 },
                        new { CraneId = 12, FrameTypeId = 6 },
                        new { CraneId = 12, FrameTypeId = 8 },

                        //PALMS 1.42
                        new { CraneId = 13, FrameTypeId = 9 }
                    )
                );
        }
    }
}
