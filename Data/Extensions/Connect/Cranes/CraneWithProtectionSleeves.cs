using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithProtectionSleeves
    {
        public static void ConnectCranesWithProtectionSleeves(this ModelBuilder modelBuilder)
        {
            //PROTECTION SLEEVES
            modelBuilder.Entity<ProtectionSleeves>()
                .HasMany(t => t.Crane)
                .WithMany(c => c.ProtectionSleeves)
                .UsingEntity(j => j.ToTable("ProtectionSleevesCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, ProtectionSleevesId = 1 },

                        //PALMS 2.54
                        new { CraneId = 2, ProtectionSleevesId = 1 },

                        //PALMS 3.61
                        new { CraneId = 3, ProtectionSleevesId = 1 },

                        //PALMS 3.67
                        new { CraneId = 4, ProtectionSleevesId = 1 },

                        //PALMS 4.71
                        new { CraneId = 5, ProtectionSleevesId = 2 },

                        //PALMS 5.72
                        new { CraneId = 6, ProtectionSleevesId = 3 },

                        //PALMS 5.85
                        new { CraneId = 7, ProtectionSleevesId = 3 },

                        //PALMS 5.87Z
                        new { CraneId = 8, ProtectionSleevesId = 3 },

                        //PALMS 7.75
                        new { CraneId = 9, ProtectionSleevesId = 3 },

                        //PALMS 7.86
                        new { CraneId = 10, ProtectionSleevesId = 3 },

                        //PALMS 7.94
                        new { CraneId = 11, ProtectionSleevesId = 3 },

                        //PALMS X100
                        new { CraneId = 12, ProtectionSleevesId = 4 }
                    )
                );
        }
    }
}
