using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithValveBlock
    {
        public static void ConnectCranesWithValveBlock(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValveBlock>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.ValveBlock)
                .HasForeignKey(o => o.ValveBlockId)
                .IsRequired(false);
        }
    }
}
