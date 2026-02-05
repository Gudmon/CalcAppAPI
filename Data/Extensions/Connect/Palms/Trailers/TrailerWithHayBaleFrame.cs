using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithHayBaleFrame
    {
        public static void ConnectTrailersWithHayBaleFrame(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HayBaleFrame>()
                 .HasMany(o => o.Trailer)
                 .WithOne(o => o.HayBaleFrame)
                 .HasForeignKey(o => o.HayBaleFrameId)
                 .IsRequired(false);
        }
    }
}
