using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithShipping
    {
        public static void ConnectCranesWithShipping(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipping>()
                 .HasMany(o => o.Cranes)
                 .WithOne(o => o.Shipping)
                 .HasForeignKey(o => o.ShippingId)
                 .IsRequired(false);
        }
    }
}
