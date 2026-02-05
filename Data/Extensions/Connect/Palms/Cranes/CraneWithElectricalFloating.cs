using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithElectricalFloating
    {
        public static void ConnectCranesWithElectricalFloating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElectricalFloating>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.ElectricalFloating)
                .HasForeignKey(o => o.ElectricalFloatingId)
                .IsRequired(false);
        }
    }
}
