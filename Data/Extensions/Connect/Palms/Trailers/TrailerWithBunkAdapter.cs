using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithBunkAdapter
    {
        public static void ConnectTrailersWithBunkAdapter(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkAdapter>()
                 .HasMany(o => o.Trailer)
                 .WithOne(o => o.BunkAdapter)
                 .HasForeignKey(o => o.BunkAdapterId)
                 .IsRequired(false);
        }
    }
}
