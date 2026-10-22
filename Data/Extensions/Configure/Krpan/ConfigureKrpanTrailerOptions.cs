using CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan
{
    public static class ConfigureKrpanTrailerOptions
    {
        public static void ConfigureAllKrpanTrailerOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultipleKrpanTrailers();
            modelBuilder.ConfigureMultipleKrpanHydraulicAdjustableChassis();
            modelBuilder.ConfigureMultipleKrpanTrailerLamps();
            modelBuilder.ConfigureMultipleKrpanChocks();
            modelBuilder.ConfigureMultipleKrpanWheelChocks();
            modelBuilder.ConfigureMultipleKrpanDrawbarSteerings();
            modelBuilder.ConfigureMultipleKrpanTrailerSupportLegs();
            modelBuilder.ConfigureMultipleKrpanPropulsions();
            modelBuilder.ConfigureMultipleKrpanAdjustableDrives();
            modelBuilder.ConfigureMultipleKrpanTyres();
            modelBuilder.ConfigureMultipleKrpanBrakes();
            modelBuilder.ConfigureMultipleKrpanHandBrakes();
            modelBuilder.ConfigureMultipleKrpanStanchions();
            modelBuilder.ConfigureMultipleKrpanTopConnections();
            modelBuilder.ConfigureMultipleKrpanClutches();
            modelBuilder.ConfigureMultipleKrpanDrawheads();
            modelBuilder.ConfigureMultipleKrpanDrawbars();
            modelBuilder.ConfigureMultipleKrpanTrailerCouplingDevices();
            modelBuilder.ConfigureMultipleKrpanCardanShafts();
            modelBuilder.ConfigureMultipleKrpanBBoxes();
            modelBuilder.ConfigureMultipleKrpanBaleTransportPlatforms();
            modelBuilder.ConfigureMultipleKrpanCargoSpaceExtensions();
            modelBuilder.ConfigureMultipleKrpanAxeHolders();
            modelBuilder.ConfigureMultipleKrpanChainsawHolders();
            modelBuilder.ConfigureMultipleKrpanFuelTankHolders();
            modelBuilder.ConfigureMultipleKrpanToolBoxes();
            modelBuilder.ConfigureMultipleKrpanPlatos();
            modelBuilder.ConfigureMultipleKrpanExtensions();
            modelBuilder.ConfigureMultipleKrpanGrappleLocations();
            modelBuilder.ConfigureMultipleKrpanMechanicalAdjustableFrames();
        }

    }
}
