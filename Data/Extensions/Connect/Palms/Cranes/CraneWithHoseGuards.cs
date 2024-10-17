using CalcAppAPI.Models.Machine.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithHoseGuards
    {
        public static void ConnectCranesWithHoseGuards(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.HoseGuard)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("HoseGuardCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        //PALMS 2.54
                        //PALMS 3.61

                        //PALMS 3.67
                        new { CraneId = 4, HoseGuardId = 1 },

                        //PALMS 4.71
                        new { CraneId = 5, HoseGuardId = 1 },

                        //PALMS 5.72
                        new { CraneId = 6, HoseGuardId = 1 },
                        new { CraneId = 6, HoseGuardId = 2 },

                        //PALMS 5.85
                        new { CraneId = 7, HoseGuardId = 1 },
                        new { CraneId = 7, HoseGuardId = 2 },

                        //PALMS 5.87Z

                        //PALMS 7.78
                        new { CraneId = 9, HoseGuardId = 1 },
                        new { CraneId = 9, HoseGuardId = 2 },

                        //PALMS 7.87
                        new { CraneId = 10, HoseGuardId = 1 },
                        new { CraneId = 10, HoseGuardId = 2 },

                        //PALMS 7.94
                        new { CraneId = 11, HoseGuardId = 2 },

                        //PALMS X100
                        new { CraneId = 12, HoseGuardId = 2 }
                    )
                );
        }
    }
}
