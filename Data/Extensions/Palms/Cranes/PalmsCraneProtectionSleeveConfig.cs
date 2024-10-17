using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
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
                   Price = "95",
               });
        }
    }
}
