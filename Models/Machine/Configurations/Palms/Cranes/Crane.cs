using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public class Crane
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Series { get; set; } = string.Empty;
        public string MaxReach { get; set; } = string.Empty;
        public string LiftAtFullReach240Bar { get; set; } = string.Empty;
        public string LiftAtFullReach215Bar { get; set; } = string.Empty;
        public string LiftAtFullReach190Bar { get; set; } = string.Empty;
        public string LiftAtFourMeters240Bar { get; set; } = string.Empty;
        public string LiftAtFourMeters215Bar { get; set; } = string.Empty;
        public string LiftAtFourMeters190Bar { get; set; } = string.Empty;
        public string BrutLiftingTorque240Bar { get; set; } = string.Empty;
        public string BrutLiftingTorque215Bar { get; set; } = string.Empty;
        public string BrutLiftingTorque190Bar { get; set; } = string.Empty;
        public string TelescopeLength { get; set; } = string.Empty;
        public string SlewingCylinder { get; set; } = string.Empty;
        public string SlewingTorque { get; set; } = string.Empty;
        public string WorkingPressure { get; set; } = string.Empty;
        public string RotatorMaximumLoad { get; set; } = string.Empty;
        public string RotatorCapacity { get; set; } = string.Empty;
        public string RotatorType { get; set; } = string.Empty;
        public string RotatorConnection { get; set; } = string.Empty;
        public string CraneWeight { get; set; } = string.Empty;
        public string PillarSlewingAngle { get; set; } = string.Empty;
        public string RecommendedOilFlow { get; set; } = string.Empty;
        public ICollection<Trailer> Trailer { get; set; } = new List<Trailer>();
        public ICollection<FrameType> FrameType { get; set; } = new List<FrameType>();
        public ICollection<ControlBlock> ControlBlock { get; set; } = new List<ControlBlock>();
        public ICollection<Rotator> Rotator { get; set; } = new List<Rotator>();
        public ICollection<Grapple> Grapple { get; set; } = new List<Grapple>();
        public ICollection<Winch> Winch { get; set; } = new List<Winch>();
        public ProtectionSleeves? ProtectionSleeves { get; set; }
        public int? ProtectionSleevesId { get; set; }
        public ElectricalFloating? ElectricalFloating { get; set; }
        public int? ElectricalFloatingId { get; set; }
        public ValveBlock? ValveBlock { get; set; }
        public int? ValveBlockId { get; set; }
        public ICollection<Damping> Damping { get; set; } = new List<Damping>();
        public CraneLight? Light { get; set; }
        public int? LightId { get; set; }
        public OperatorSeat? OperatorSeat { get; set; }
        public int? OperatorSeatId { get; set; }
        public ICollection<HighPerformanceOilFilter> HighPerformanceOilFilter { get; set; } = new List<HighPerformanceOilFilter>();
        public CraneOilCooler? CraneOilCooler { get; set; }
        public int? CraneOilCoolerId { get; set; }
        public ICollection<RotatorBrake> RotatorBrake { get; set; } = new List<RotatorBrake>();
        public JoystickHolder? JoystickHolder { get; set; }
        public int? JoystickHolderId { get; set; }
        public ICollection<HoseGuard> HoseGuard { get; set; } = new List<HoseGuard>();
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
        public string[]? ImageUrls { get; set; }
    }
}
