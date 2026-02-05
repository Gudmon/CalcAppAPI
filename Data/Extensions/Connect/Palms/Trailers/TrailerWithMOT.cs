using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithMOT
    {
        public static void ConnectTrailersWithMOT(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOT>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.MOT)
                .HasForeignKey(o => o.MOTId)
                .IsRequired(false);
        }
    }
}
