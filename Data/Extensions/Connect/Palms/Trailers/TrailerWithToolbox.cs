using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithToolbox
    {
        public static void ConnectTrailersWithToolbox(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Toolbox>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.Toolbox)
                .HasForeignKey(o => o.ToolboxId)
                .IsRequired(false);
        }
    }
}
