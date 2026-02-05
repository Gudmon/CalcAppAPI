using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithOilCooler
    {
        public static void ConnectCranesWithOilCooler(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneOilCooler>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.CraneOilCooler)
                .HasForeignKey(o => o.CraneOilCoolerId)
                .IsRequired(false);
        }
    }
}
