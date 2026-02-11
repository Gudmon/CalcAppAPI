using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class ConfigurePalmsTrailerOptions
    {
        public static void ConfigureAllPalmsTrailerOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultiplePalmsTrailers();
            modelBuilder.ConfigureMultiplePalmsStanchions();
            modelBuilder.ConfigureMultiplePalmsBrakes();
            modelBuilder.ConfigureMultiplePalmsDrawbars();
            modelBuilder.ConfigureMultiplePalmsPropulsions();
            modelBuilder.ConfigureMultiplePalmsPlatforms();
            modelBuilder.ConfigureMultiplePalmsOilPumps();
            modelBuilder.ConfigureMultiplePalmsOilTanks();
            modelBuilder.ConfigureMultiplePalmsTrailerOilCoolers();
            modelBuilder.ConfigureMultiplePalmsBolsterLocks();
            modelBuilder.ConfigureMultiplePalmsBBoxes();
            modelBuilder.ConfigureMultiplePalmsDBoxes();
            modelBuilder.ConfigureMultiplePalmsHayBaleFrames();
            modelBuilder.ConfigureMultiplePalmsWoodSorters();
            modelBuilder.ConfigureMultiplePalmsHandBrakes();
            modelBuilder.ConfigureMultiplePalmsChainsawHolders();
            modelBuilder.ConfigureMultiplePalmsUnderrunProtections();
            modelBuilder.ConfigureMultiplePalmsSupportLegs();
            modelBuilder.ConfigureMultiplePalmsTrailerLights();
            modelBuilder.ConfigureMultiplePalmsTyres();
            modelBuilder.ConfigureMultiplePalmsBunkAdapters();
            modelBuilder.ConfigureMultiplePalmsBunkExtensions();
            modelBuilder.ConfigureMultiplePalmsManualBunkExtensions();
            modelBuilder.ConfigureMultiplePalmsFrameExtensions();
            modelBuilder.ConfigureMultiplePalmsStanchionExtensions();
            modelBuilder.ConfigureMultiplePalmsHydropacks();
            modelBuilder.ConfigureMultiplePalmsHydropackControls();
            modelBuilder.ConfigureMultiplePalmsMOTs();
            modelBuilder.ConfigureMultiplePalmsSupplyFormats();
            modelBuilder.ConfigureMultiplePalmsToolboxes();
        }
    }
}
