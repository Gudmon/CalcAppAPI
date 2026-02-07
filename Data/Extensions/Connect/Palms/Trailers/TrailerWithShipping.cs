using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithShipping
    {
        public static void ConnectTrailersWithShipping(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipping>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.Shipping)
                .HasForeignKey(o => o.ShippingId)
                .IsRequired(false);
        }
    }
}
