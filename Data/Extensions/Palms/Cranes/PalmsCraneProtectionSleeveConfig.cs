using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneProtectionSleeveConfig
    {
        public static void ConfigureMultiplePalmsProtectionSleeves(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProtectionSleeves>().HasData(
               new ProtectionSleeves
               {
                   Id = 1,
                   Name = "Védőhüvely a tömlőhöz",
                   Code = "PSH",
                   Price = "70",
               },
               new ProtectionSleeves
               {
                   Id = 2,
                   Name = "Védőhüvely a tömlőhöz",
                   Code = "PSH",
                   Price = "75",
               },
               new ProtectionSleeves
               {
                   Id = 3,
                   Name = "Védőhüvely a tömlőhöz",
                   Code = "PSH",
                   Price = "95",
               },
               new ProtectionSleeves
               {
                   Id = 4,
                   Name = "Védőhüvely a tömlőhöz",
                   Code = "PSH",
                   Price = "105",
               });
        }
    }
}
