using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithBoomGuards
    {
        public static void ConnectCranesWithBoomGuards(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.BoomGuard)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("BoomGuardCrane")
                    .HasData
                    (
                        //PALMS 2.42            
                        //PALMS 2.54                  
                        //PALMS 3.63                    
                        //PALMS 3.67
                        //PALMS 4.71

                        //PALMS 5.72
                        new { CraneId = 6, BoomGuardId = 1 },

                        //PALMS 5.85
                        new { CraneId = 7, BoomGuardId = 1 },

                        //PALMS 5.87Z

                        //PALMS 7.75
                        new { CraneId = 9, BoomGuardId = 2 },

                        //PALMS 7.86
                        new { CraneId = 10, BoomGuardId = 2 },

                        //PALMS 7.94
                        new { CraneId = 11, BoomGuardId = 2 },

                        //PALMS X100
                        new { CraneId = 12, BoomGuardId = 3 }
                    )
                );
        }
    }
}
