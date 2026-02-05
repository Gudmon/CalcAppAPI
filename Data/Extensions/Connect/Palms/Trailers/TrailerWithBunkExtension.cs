using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithBunkExtension
    {
        public static void ConnectTrailersWithBunkExtension(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkExtension>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.BunkExtension)
                .HasForeignKey(o => o.BunkExtensionId)
                .IsRequired(false);
        }
    }
}
