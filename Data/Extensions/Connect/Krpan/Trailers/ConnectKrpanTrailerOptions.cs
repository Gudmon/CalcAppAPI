using CalcAppAPI.Data.Extensions.Connect.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class ConnectKrpanTrailerOptions
    {
        public static void ConnectAllKrpanTrailerOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectKrpanTrailersWithCranes();
            modelBuilder.ConnectKrpanTrailersWithBrakes();
            modelBuilder.ConnectKrpanTrailersWithClutches();
            modelBuilder.ConnectKrpanTrailersWithDrawbars();
            modelBuilder.ConnectKrpanTrailersWithCouplingDevices();
            modelBuilder.ConnectKrpanTrailersWithPropulsions();
            modelBuilder.ConnectKrpanTrailersWithTyres();
            modelBuilder.ConnectKrpanTrailerWithHydraulicAdjustableChassis();
            modelBuilder.ConnectKrpanTrailerWithTrailerLamp();
            modelBuilder.ConnectKrpanTrailerWithChock();
            modelBuilder.ConnectKrpanTrailerWithWheelChock();
            modelBuilder.ConnectKrpanTrailerWithDrawbarSteering();
            modelBuilder.ConnectKrpanTrailerWithSupportLegs();
            modelBuilder.ConnectKrpanTrailerWithAdjustableDrive();
            modelBuilder.ConnectKrpanTrailerWithHandBrake();
            modelBuilder.ConnectKrpanTrailersWithStanchions();
            modelBuilder.ConnectKrpanTrailerWithCardanShaft();
            modelBuilder.ConnectKrpanTrailerWithBBox();
            modelBuilder.ConnectKrpanTrailerWithBaleTransportPlatform();
            modelBuilder.ConnectKrpanTrailerWithCargoSpaceExtension();
            modelBuilder.ConnectKrpanTrailerWithAxeHolder();
            modelBuilder.ConnectKrpanTrailerWithChainsawHolder();
            modelBuilder.ConnectKrpanTrailerWithFuelTankHolder();
            modelBuilder.ConnectKrpanTrailerWithToolBox();
            modelBuilder.ConnectKrpanTrailerWithPlato();
            modelBuilder.ConnectKrpanTrailerWithExtension();
            modelBuilder.ConnectKrpanTrailerWithGrappleLocation();
            modelBuilder.ConnectKrpanTrailerWithMechanicalAdjustableFrame();
        }
    }
}
