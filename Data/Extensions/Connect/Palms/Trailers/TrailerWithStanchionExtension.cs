using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithStanchionExtension
    {
        public static void ConnectTrailersWithStanchionExtension(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StanchionExtension>()
               .HasMany(o => o.Trailer)
               .WithOne(o => o.StanchionExtension)
               .HasForeignKey(o => o.StanchionExtensionId)
               .IsRequired(false);
        }
    }
}
