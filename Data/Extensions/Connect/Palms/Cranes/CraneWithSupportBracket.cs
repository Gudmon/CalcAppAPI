using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithSupportBracket
    {
        public static void ConnectCranesWithSupportBracket(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportBracket>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.SupportBracket)
                .HasForeignKey(o => o.SupportBracketId)
                .IsRequired(false);
        }
    }
}
