using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithControlBlocks
    {
        public static void ConnectCranesWithControlBlocks(this ModelBuilder modelBuilder)
        {
            //FRAME TYPES
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.ControlBlock)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("ControlBlockCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, ControlBlockId = 1 },

                        //PALMS 2.54
                        new { CraneId = 2, ControlBlockId = 2 },
                        new { CraneId = 2, ControlBlockId = 3 },
                        new { CraneId = 2, ControlBlockId = 4 },
                        new { CraneId = 2, ControlBlockId = 5 },
                        new { CraneId = 2, ControlBlockId = 6 },
                        new { CraneId = 2, ControlBlockId = 8 },
                        new { CraneId = 2, ControlBlockId = 9 },
                        new { CraneId = 2, ControlBlockId = 11 },

                        //PALMS 3.63
                        new { CraneId = 3, ControlBlockId = 2 },
                        new { CraneId = 3, ControlBlockId = 3 },
                        new { CraneId = 3, ControlBlockId = 5 },

                        //PALMS 3.67
                        new { CraneId = 4, ControlBlockId = 2 },
                        new { CraneId = 4, ControlBlockId = 3 },
                        new { CraneId = 4, ControlBlockId = 4 },
                        new { CraneId = 4, ControlBlockId = 5 },
                        new { CraneId = 4, ControlBlockId = 6 },
                        new { CraneId = 4, ControlBlockId = 8 },
                        new { CraneId = 4, ControlBlockId = 9 },
                        new { CraneId = 4, ControlBlockId = 11 },

                        //PALMS 4.71
                        new { CraneId = 5, ControlBlockId = 2 },
                        new { CraneId = 5, ControlBlockId = 3 },
                        new { CraneId = 5, ControlBlockId = 4 },
                        new { CraneId = 5, ControlBlockId = 5 },
                        new { CraneId = 5, ControlBlockId = 6 },
                        new { CraneId = 5, ControlBlockId = 8 },
                        new { CraneId = 5, ControlBlockId = 9 },
                        new { CraneId = 5, ControlBlockId = 11 },

                        //PALMS 5.72
                        new { CraneId = 6, ControlBlockId = 3 },
                        new { CraneId = 6, ControlBlockId = 4 },
                        new { CraneId = 6, ControlBlockId = 5 },
                        new { CraneId = 6, ControlBlockId = 6 },
                        new { CraneId = 6, ControlBlockId = 7 },
                        new { CraneId = 6, ControlBlockId = 8 },
                        new { CraneId = 6, ControlBlockId = 9 },
                        new { CraneId = 6, ControlBlockId = 10 },
                        new { CraneId = 6, ControlBlockId = 11 },
                        new { CraneId = 6, ControlBlockId = 12 },
                        new { CraneId = 6, ControlBlockId = 13 },

                        //PALMS 5.85
                        new { CraneId = 7, ControlBlockId = 3 },
                        new { CraneId = 7, ControlBlockId = 4 },
                        new { CraneId = 7, ControlBlockId = 5 },
                        new { CraneId = 7, ControlBlockId = 6 },
                        new { CraneId = 7, ControlBlockId = 7 },
                        new { CraneId = 7, ControlBlockId = 8 },
                        new { CraneId = 7, ControlBlockId = 9 },
                        new { CraneId = 7, ControlBlockId = 10 },
                        new { CraneId = 7, ControlBlockId = 11 },
                        new { CraneId = 7, ControlBlockId = 12 },
                        new { CraneId = 7, ControlBlockId = 13 },

                         //PALMS 5.87Z
                        new { CraneId = 8, ControlBlockId = 6 },
                        new { CraneId = 8, ControlBlockId = 7 },
                        new { CraneId = 8, ControlBlockId = 8 },
                        new { CraneId = 8, ControlBlockId = 9 },
                        new { CraneId = 8, ControlBlockId = 10 },
                        new { CraneId = 8, ControlBlockId = 11 },
                        new { CraneId = 8, ControlBlockId = 12 },
                        new { CraneId = 8, ControlBlockId = 13 },

                         //PALMS 7.75
                        new { CraneId = 9, ControlBlockId = 6 },
                        new { CraneId = 9, ControlBlockId = 7 },
                        new { CraneId = 9, ControlBlockId = 8 },
                        new { CraneId = 9, ControlBlockId = 9 },
                        new { CraneId = 9, ControlBlockId = 10 },
                        new { CraneId = 9, ControlBlockId = 11 },
                        new { CraneId = 9, ControlBlockId = 12 },
                        new { CraneId = 9, ControlBlockId = 13 },

                        //PALMS 7.86
                        new { CraneId = 10, ControlBlockId = 6 },
                        new { CraneId = 10, ControlBlockId = 7 },
                        new { CraneId = 10, ControlBlockId = 8 },
                        new { CraneId = 10, ControlBlockId = 9 },
                        new { CraneId = 10, ControlBlockId = 10 },
                        new { CraneId = 10, ControlBlockId = 11 },
                        new { CraneId = 10, ControlBlockId = 12 },
                        new { CraneId = 10, ControlBlockId = 13 },
                        new { CraneId = 10, ControlBlockId = 14 },

                        //PALMS 7.94
                        new { CraneId = 11, ControlBlockId = 6 },
                        new { CraneId = 11, ControlBlockId = 7 },
                        new { CraneId = 11, ControlBlockId = 8 },
                        new { CraneId = 11, ControlBlockId = 9 },
                        new { CraneId = 11, ControlBlockId = 10 },
                        new { CraneId = 11, ControlBlockId = 11 },
                        new { CraneId = 11, ControlBlockId = 12 },
                        new { CraneId = 11, ControlBlockId = 13 },
                        new { CraneId = 11, ControlBlockId = 14 },

                        //PALMS X100
                        new { CraneId = 12, ControlBlockId = 7 },
                        new { CraneId = 12, ControlBlockId = 8 },
                        new { CraneId = 12, ControlBlockId = 9 },
                        new { CraneId = 12, ControlBlockId = 10 },
                        new { CraneId = 12, ControlBlockId = 11 },
                        new { CraneId = 12, ControlBlockId = 12 },
                        new { CraneId = 12, ControlBlockId = 13 },
                        new { CraneId = 12, ControlBlockId = 14 },

                        //PALMS 1.42
                        new { CraneId = 13, ControlBlockId = 2 }
                    )

                );
        }
    }
}
