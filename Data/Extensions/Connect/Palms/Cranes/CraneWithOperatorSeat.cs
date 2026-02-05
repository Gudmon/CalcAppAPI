using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithOperatorSeat
    {
        public static void ConnectCranesWithOperatorSeat(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatorSeat>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.OperatorSeat)
                .HasForeignKey(o => o.OperatorSeatId)
                .IsRequired(false);
        }
    }
}
