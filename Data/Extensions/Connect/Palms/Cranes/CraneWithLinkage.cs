using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithLinkage
    {
        public static void ConnectCranesWithLinkage(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Linkage>()
               .HasMany(o => o.Crane)
               .WithOne(o => o.Linkage)
               .HasForeignKey(o => o.LinkageId)
               .IsRequired(false);
        }
    }
}
