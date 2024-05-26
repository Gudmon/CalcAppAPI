using CalcAppAPI.Models.Machine.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Cranes
{
    public static class KrpanCraneConfig
    {
        public static void ConfigureMultipleKrpanCranes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCrane>().HasData(
                new KrpanCrane
                {
                    Id = 1,
                    Name = "GD 6,6 K",
                    Description = "",
                    Price = "13715",
                    MaxReach = "6.6",
                    MaxReachWithGrabOpen = "7.2",
                    NetLiftingTorque = "40",
                    BrutLiftingTorque = "50",
                    LiftCapacityAtFourMeters = "1020",
                    LiftCapacityAtMaxReach = "600",
                    Weight = "900",
                    SlewTorque = "16",
                    SlewingAngle = "375",
                    SystemPressure = "220",
                    OilQuantityInTank = "70",
                    SlewCylinders = "4",
                    TelescopicStages = "1"
                },
                new KrpanCrane
                {
                    Id = 2,
                    Name = "GD 7,4 K",
                    Description = "",
                    Price = "24475",
                    MaxReach = "7.4",
                    MaxReachWithGrabOpen = "8.0",
                    NetLiftingTorque = "63",
                    BrutLiftingTorque = "80",
                    LiftCapacityAtFourMeters = "1860",
                    LiftCapacityAtMaxReach = "850",
                    Weight = "1516",
                    SlewTorque = "22",
                    SlewingAngle = "380",
                    SystemPressure = "230",
                    OilQuantityInTank = "100",
                    SlewCylinders = "4",
                    TelescopicStages = "1"
                },
                new KrpanCrane
                {
                    Id = 3,
                    Name = "GD 7,6 K",
                    Description = "",
                    Price = "15335",
                    MaxReach = "7.6",
                    MaxReachWithGrabOpen = "8.2",
                    NetLiftingTorque = "39",
                    BrutLiftingTorque = "49",
                    LiftCapacityAtFourMeters = "1020",
                    LiftCapacityAtMaxReach = "500",
                    Weight = "930",
                    SlewTorque = "16",
                    SlewingAngle = "375",
                    SystemPressure = "220",
                    OilQuantityInTank = "70",
                    SlewCylinders = "4",
                    TelescopicStages = "1"
                },
                new KrpanCrane
                {
                    Id = 4,
                    Name = "GD 8,6 K",
                    Description = "",
                    Price = "27150",
                    MaxReach = "8.6",
                    MaxReachWithGrabOpen = "9.2",
                    NetLiftingTorque = "58",
                    BrutLiftingTorque = "82",
                    LiftCapacityAtFourMeters = "1670",
                    LiftCapacityAtMaxReach = "680",
                    Weight = "1706",
                    SlewTorque = "19",
                    SlewingAngle = "380",
                    SystemPressure = "230",
                    OilQuantityInTank = "100",
                    SlewCylinders = "4",
                    TelescopicStages = "2"
                },
                new KrpanCrane
                {
                    Id = 5,
                    Name = "GD 7,2 Z",
                    Description = "",
                    Price = "26000",
                    MaxReach = "7.2",
                    MaxReachWithGrabOpen = "7.8",
                    NetLiftingTorque = "62",
                    BrutLiftingTorque = "82",
                    LiftCapacityAtFourMeters = "1460",
                    LiftCapacityAtMaxReach = "894",
                    Weight = "1530",
                    SlewTorque = "22",
                    SlewingAngle = "370",
                    SystemPressure = "230",
                    OilQuantityInTank = "100",
                    SlewCylinders = "4",
                    TelescopicStages = "1"
                },
                new KrpanCrane
                {
                    Id = 6,
                    Name = "GD 8,4 Z",
                    Description = "",
                    Price = "29200",
                    MaxReach = "8.4",
                    MaxReachWithGrabOpen = "9.0",
                    NetLiftingTorque = "60",
                    BrutLiftingTorque = "84",
                    LiftCapacityAtFourMeters = "1427",
                    LiftCapacityAtMaxReach = "760",
                    Weight = "1855",
                    SlewTorque = "22",
                    SlewingAngle = "370",
                    SystemPressure = "230",
                    OilQuantityInTank = "100",
                    SlewCylinders = "4",
                    TelescopicStages = "2"
                }
                );
        }
    }
}
