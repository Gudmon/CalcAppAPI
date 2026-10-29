using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class KrpanCranesWithSlewingDrive
    {
        public static void ConnectKrpanCranesWithSlewingDrive(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneSlewingDrive>()
                .HasMany(o => o.KrpanCranes)
                .WithOne(c => c.KrpanCraneSlewingDrive)
                .HasForeignKey(c => c.KrpanCraneSlewingDriveId)
                .IsRequired(false);
        }
    }
}
