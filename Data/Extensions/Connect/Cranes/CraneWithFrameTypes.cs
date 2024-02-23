using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithFrameTypes
    {
        public static void ConnectCranesWithFrameTypes(this ModelBuilder modelBuilder)
        {
            // FRAME TYPES
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

                        //PALMS 3.61
                        new { CraneId = 3, FrameTypeId = 2 },
                        new { CraneId = 3, FrameTypeId = 1 },

                        //PALMS 3.67
                        new { CraneId = 4, FrameTypeId = 1 },
                        new { CraneId = 4, FrameTypeId = 3 },
                        new { CraneId = 4, FrameTypeId = 4 },
                        new { CraneId = 4, FrameTypeId = 5 },

                        //PALMS 4.71
                        new { CraneId = 5, FrameTypeId = 1 },
                        new { CraneId = 5, FrameTypeId = 3 },
                        new { CraneId = 5, FrameTypeId = 5 }
                    )

                );
        }
    }
}
