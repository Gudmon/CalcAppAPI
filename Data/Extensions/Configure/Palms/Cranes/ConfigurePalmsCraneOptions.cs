using CalcAppAPI.Data.Extensions.Configure.Palms.Common;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class ConfigurePalmsCraneOptions
    {
        public static void ConfigureAllPalmsCraneOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultiplePalmsCranes();
            modelBuilder.ConfigureMultiplePalmsFrameTypes();
            modelBuilder.ConfigureMultiplePalmsControlBlocks();
            modelBuilder.ConfigureMultiplePalmsRotators();
            modelBuilder.ConfigureMultiplePalmsGrapples();
            modelBuilder.ConfigureMultiplePalmsWinches();
            modelBuilder.ConfigureMultiplePalmsProtectionSleeves();
            modelBuilder.ConfigureMultiplePalmsElectricalFloatings();
            modelBuilder.ConfigureMultiplePalmsValveBlocks();
            modelBuilder.ConfigureMultiplePalmsDampings();
            modelBuilder.ConfigureMultiplePalmsCraneLights();
            modelBuilder.ConfigureMultiplePalmsCraneOperatorSeats();
            modelBuilder.ConfigureMultiplePalmsCraneHighPerformanceOilFilters();
            modelBuilder.ConfigureMultiplePalmsCraneOilCoolers();
            modelBuilder.ConfigureMultiplePalmsCraneRotatorBrakes();
            modelBuilder.ConfigureMultiplePalmsCraneJoyStickHolders();
            modelBuilder.ConfigureMultiplePalmsCraneHoseGuards();
            modelBuilder.ConfigureMultiplePalmsCraneTurningDeviceCounterPlates();
            modelBuilder.ConfigureMultiplePalmsCraneSupportLegCounterPlates();
            modelBuilder.ConfigureMultiplePalmsCraneBoomGuards();
            modelBuilder.ConfigureMultiplePalmsCraneCovers();
            modelBuilder.ConfigureMultiplePalmsCraneWoodControls();
            modelBuilder.ConfigureMultiplePalmsCraneLinkages();
            modelBuilder.ConfigureMultiplePalmsCraneSupportBrackets();
            modelBuilder.ConfigureMultiplePalmsShippings();
        }
    }
}
