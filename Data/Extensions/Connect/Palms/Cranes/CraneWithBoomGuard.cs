using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithBoomGuard
    {
        public static void ConnectCranesWithBoomGuard(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoomGuard>()
               .HasMany(o => o.Crane)
               .WithOne(o => o.BoomGuard)
               .HasForeignKey(o => o.BoomGuardId)
               .IsRequired(false);
        }
    }
}
