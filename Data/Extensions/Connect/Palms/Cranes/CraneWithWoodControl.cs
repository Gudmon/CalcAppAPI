using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithWoodControl
    {
        public static void ConnectCranesWithWoodControl(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WoodControl>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.WoodControl)
                .HasForeignKey(o => o.WoodControlId)
                .IsRequired(false);
        }
    }
}
