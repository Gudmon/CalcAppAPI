using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithOilCooler
    {
        public static void ConnectTrailersWithOilCooler(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrailerOilCooler>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.TrailerOilCooler)
                .HasForeignKey(o => o.TrailerOilCoolerId)
                .IsRequired(false);
        }
    }
}
