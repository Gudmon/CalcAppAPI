using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class ConnectPalmsCraneOptions
    {
        public static void ConnectAllPalmsCraneOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectCranesWithControlBlocks();
            modelBuilder.ConnectCranesWithDampings();
            modelBuilder.ConnectCranesWithFrameTypes();
            modelBuilder.ConnectCranesWithGrapples();
            modelBuilder.ConnectCranesWithHighPerformanceOilFilters();
            modelBuilder.ConnectCranesWithHoseGuards();
            modelBuilder.ConnectCranesWithRotatorBrakes();
            modelBuilder.ConnectCranesWithRotators();
            modelBuilder.ConnectCranesWithWinches();
            modelBuilder.ConnectCranesWithBoomGuard();
            modelBuilder.ConnectCranesWithCover();
            modelBuilder.ConnectCranesWithElectricalFloating();
            modelBuilder.ConnectCranesWithJoystickHolder();
            modelBuilder.ConnectCranesWithLight();
            modelBuilder.ConnectCranesWithLinkage();
            modelBuilder.ConnectCranesWithOilCooler();
            modelBuilder.ConnectCranesWithOperatorSeat();
            modelBuilder.ConnectCranesWithProtectionSleeve();
            modelBuilder.ConnectCranesWithShipping();
            modelBuilder.ConnectCranesWithSupportLegCounterPlate();
            modelBuilder.ConnectCranesWithTurningDeviceCounterPlate();
            modelBuilder.ConnectCranesWithValveBlock();
            modelBuilder.ConnectCranesWithWoodControl();
        }
    }
}
