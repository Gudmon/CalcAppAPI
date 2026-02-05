using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithProtectionSleeve
    {
        public static void ConnectCranesWithProtectionSleeve(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProtectionSleeves>()
                 .HasMany(o => o.Crane)
                 .WithOne(o => o.ProtectionSleeves)
                 .HasForeignKey(o => o.ProtectionSleevesId)
                 .IsRequired(false);
        }
    }
}
