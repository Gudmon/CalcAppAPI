using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithUnderrunProtection
    {
        public static void ConnectTrailersWithUnderrunProtection(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnderrunProtection>()
               .HasMany(o => o.Trailer)
               .WithOne(o => o.UnderrunProtection)
               .HasForeignKey(o => o.UnderrunProtectionId)
               .IsRequired(false);
        }
    }
}
