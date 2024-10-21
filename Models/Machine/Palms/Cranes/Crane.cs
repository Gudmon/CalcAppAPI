using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Palms.Cranes
{
    public class Crane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Series { get; set; }
        public string MaxReach { get; set; }
        public string LiftAtFullReach240Bar { get; set; }
        public string LiftAtFullReach215Bar { get; set; }
        public string LiftAtFullReach190Bar { get; set; }
        public string LiftAtFourMeters240Bar { get; set; }
        public string LiftAtFourMeters215Bar { get; set; }
        public string LiftAtFourMeters190Bar { get; set; }
        public string BrutLiftingTorque240Bar { get; set; }
        public string BrutLiftingTorque215Bar { get; set; }
        public string BrutLiftingTorque190Bar { get; set; }
        public string TelescopeLength { get; set; }
        public string SlewingCylinder { get; set; }
        public string SlewingTorque { get; set; }
        public string WorkingPressure { get; set; }
        public string RotatorMaximumLoad { get; set; }
        public string RotatorCapacity { get; set; }
        public string RotatorType { get; set; }
        public string RotatorConnection { get; set; }
        public string CraneWeight { get; set; }
        public string PillarSlewingAngle { get; set; }
        public string RecommendedOilFlow { get; set; }
        public IEnumerable<Trailer> Trailer { get; set; }
        public IEnumerable<TrailerCraneConfiguration> TrailerConfigurations { get; set; }
        public IEnumerable<FrameType> FrameType { get; set; }
        public IEnumerable<ControlBlock> ControlBlock { get; set; }
        public IEnumerable<Rotator> Rotator { get; set; }
        public IEnumerable<Grapple> Grapple { get; set; }
        public IEnumerable<Winch> Winch { get; set; }
        public ProtectionSleeves? ProtectionSleeves { get; set; }
        public int? ProtectionSleevesId { get; set; }
        public ElectricalFloating? ElectricalFloating { get; set; }
        public int? ElectricalFloatingId { get; set; }
        public ValveBlock? ValveBlock { get; set; }
        public int? ValveBlockId { get; set; }
        public IEnumerable<Damping> Damping { get; set; }
        public CraneLight? Light { get; set; }
        public int? LightId { get; set; }
        public OperatorSeat? OperatorSeat { get; set; }
        public int? OperatorSeatId { get; set; }
        public IEnumerable<HighPerformanceOilFilter> HighPerformanceOilFilter { get; set; }
        public CraneOilCooler? CraneOilCooler { get; set; }
        public int? CraneOilCoolerId { get; set; }
        public IEnumerable<RotatorBrake> RotatorBrake { get; set; }
        public JoystickHolder? JoystickHolder { get; set; }
        public int? JoystickHolderId { get; set; }
        public IEnumerable<HoseGuard> HoseGuard { get; set; }
        public TurningDeviceCounterPlate? TurningDeviceCounterPlate { get; set; }
        public int? TurningDeviceCounterPlateId { get; set; }
        public SupportLegCounterPlate? SupportLegCounterPlate { get; set; }
        public int? SupportLegCounterPlateId { get; set; }
        public BoomGuard? BoomGuard { get; set; }
        public int? BoomGuardId { get; set; }
        public Cover? Cover { get; set; }
        public int? CoverId { get; set; }
        public WoodControl? WoodControl { get; set; }
        public int? WoodControlId { get; set; }
        public Linkage? Linkage { get; set; }
        public int? LinkageId { get; set; }
        public Shipping? Shipping { get; set; }
        public int? ShippingId { get; set; }
    }
}
