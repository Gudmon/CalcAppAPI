using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithHydropackControl
    {
        public static void ConnectTrailersHydropackControl(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HydroPackControl>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.HydropackControl)
                .HasForeignKey(o => o.HydropackControlId)
                .IsRequired(false);
        }
    }
}
