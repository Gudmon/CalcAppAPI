using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithLight
    {
        public static void ConnectCranesWithLight(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneLight>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.Light)
                .HasForeignKey(o => o.LightId)
                .IsRequired(false);
        }
    }
}
