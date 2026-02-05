using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithFrameExtension
    {
        public static void ConnectTrailersWithFrameExtension(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrameExtension>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.FrameExtension)
                .HasForeignKey(o => o.FrameExtensionId)
                .IsRequired(false);
        }
    }
}
