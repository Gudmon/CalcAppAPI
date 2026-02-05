using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithDBox
    {
        public static void ConnectTrailersWithDBox(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBox>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.DBox)
                .HasForeignKey(o => o.DBoxId)
                .IsRequired(false);
        }
    }
}
