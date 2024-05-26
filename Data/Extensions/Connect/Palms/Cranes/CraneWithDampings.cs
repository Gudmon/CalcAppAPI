using CalcAppAPI.Models.Machine.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithDampings
    {
        public static void ConnectCranesWithDampings(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Damping)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("DampingCrane")
                    .HasData
                    (
                        //PALMS 2.42            
                        //PALMS 2.54                  
                        //PALMS 3.63                    
                        //PALMS 3.67

                        //PALMS 4.71
                        new { CraneId = 5, DampingId = 1 },
                        new { CraneId = 5, DampingId = 2 },
                        new { CraneId = 5, DampingId = 3 },

                        //PALMS 5.72
                        new { CraneId = 6, DampingId = 1 },
                        new { CraneId = 6, DampingId = 2 },
                        new { CraneId = 6, DampingId = 3 },

                        //PALMS 5.85
                        new { CraneId = 7, DampingId = 1 },
                        new { CraneId = 7, DampingId = 2 },
                        new { CraneId = 7, DampingId = 3 },

                        //PALMS 5.87Z
                        new { CraneId = 8, DampingId = 1 },
                        new { CraneId = 8, DampingId = 2 },
                        new { CraneId = 8, DampingId = 3 },

                        //PALMS 7.75
                        new { CraneId = 9, DampingId = 1 },
                        new { CraneId = 9, DampingId = 2 },
                        new { CraneId = 9, DampingId = 3 },

                        //PALMS 7.86
                        new { CraneId = 10, DampingId = 1 },
                        new { CraneId = 10, DampingId = 2 },
                        new { CraneId = 10, DampingId = 3 },

                        //PALMS 7.94
                        new { CraneId = 11, DampingId = 1 },
                        new { CraneId = 11, DampingId = 2 },
                        new { CraneId = 11, DampingId = 3 },

                        //PALMS X100
                        new { CraneId = 12, DampingId = 1 },
                        new { CraneId = 12, DampingId = 2 },
                        new { CraneId = 12, DampingId = 3 }
                    )
                );
        }
    }
}
