using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithCover
    {
        public static void ConnectCranesWithCover(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cover>()
               .HasMany(o => o.Crane)
               .WithOne(o => o.Cover)
               .HasForeignKey(o => o.CoverId)
               .IsRequired(false);
        }
    }
}
