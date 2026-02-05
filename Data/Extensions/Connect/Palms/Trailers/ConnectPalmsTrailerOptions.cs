using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class ConnectPalmsTrailerOptions
    {
        public static void ConnectAllPalmsTrailerOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectTrailersWithCranes();
            modelBuilder.ConnectTrailersWithBrakes();
            modelBuilder.ConnectTrailersWithDrawbars();
            modelBuilder.ConnectTrailersWithHydropacks();
            modelBuilder.ConnectTrailersWithOilPumps();
            modelBuilder.ConnectTrailersWithOilTanks();
            modelBuilder.ConnectTrailersWithPlatforms();
            modelBuilder.ConnectTrailersWithPropulsions();
            modelBuilder.ConnectTrailersWithStanchions();
            modelBuilder.ConnectTrailersWithSupplyFormats();
            modelBuilder.ConnectTrailersWithSupportLegs();
            modelBuilder.ConnectTrailersWithLights();
            modelBuilder.ConnectTrailersWithTyres();
            modelBuilder.ConnectTrailersWithOilCooler();
            modelBuilder.ConnectTrailersWithBolsterLock();
            modelBuilder.ConnectTrailersWithBBox();
            modelBuilder.ConnectTrailersWithDBox();
            modelBuilder.ConnectTrailersHydropackControl();
            modelBuilder.ConnectTrailersWithToolbox();
            modelBuilder.ConnectTrailersWithWoodSorter();
            modelBuilder.ConnectTrailersWithChainsawHolder();
            modelBuilder.ConnectTrailersWithHandBrake();
            modelBuilder.ConnectTrailersWithHayBaleFrame();
            modelBuilder.ConnectTrailersWithBunkAdapter();
            modelBuilder.ConnectTrailersWithBunkExtension();
            modelBuilder.ConnectTrailersWithFrameExtension();
            modelBuilder.ConnectTrailersWithMOT();
            modelBuilder.ConnectTrailersWithShipping(); 
            modelBuilder.ConnectTrailersWithStanchionExtension();
            modelBuilder.ConnectTrailersWithUnderrunProtection();
        }
    }
}
