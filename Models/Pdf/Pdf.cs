using CalcAppAPI.Models.Machine.Configurations.Trailers;

namespace CalcAppAPI.Models.Pdf
{
    public class Pdf
    {
        //TRAILER
        public string? TrailerName { get; set; }
        public PdfItem? Stanchion { get; set; }
        public PdfItem? Brake { get; set; }
        public PdfItem? Propulsion { get; set; }
        public PdfItem? Drawbar { get; set; }
        public PdfItem? Platform { get; set; }
        public PdfItem? OilPump { get; set; }
        public PdfItem? OilTank { get; set; }
        public PdfItem? TrailerOilCooler { get; set; }
        public PdfItem? BolsterLock { get; set; }
        public PdfItem? BBox { get; set; }
        public PdfItem? WoodSorter { get; set; }
        public PdfItem? HandBrake { get; set; }
        public PdfItem? ChainsawHolder { get; set; }
        public PdfItem? UnderrunProtection { get; set; }
        public PdfItem? BunkAdapter { get; set; }
        public PdfItem? BunkExtension { get; set; }
        public PdfItem? FrameExtension { get; set; }
        public PdfItem? StanchionExtension { get; set; }
        public PdfItem? SupportLeg { get; set; }
        public PdfItem? TrailerLight { get; set; }
        public PdfItem? Tyre { get; set; }
        public PdfItem? TrailerShipping { get; set; }
        public PdfItem? MOT { get; set; }

        //CRANE
        public PdfItem? Crane { get; set; }
        public PdfItem? ControlBlock { get; set; }
        public PdfItem? FrameType { get; set; }
        public PdfItem? Rotator { get; set; }
        public PdfItem? Grapple { get; set; }
        public IEnumerable<PdfItem> Grapples { get; set; }
        public PdfItem? Winch { get; set; }
        public PdfItem? ProtectionSleeves { get; set; }
        public PdfItem? ElectricalFloating { get; set; }
        public PdfItem? ValveBlock { get; set; }
        public PdfItem? Damping { get; set; }
        public PdfItem? CraneLight { get; set; }
        public PdfItem? OperatorSeat { get; set; }
        public PdfItem? CraneOilCooler { get; set; }
        public PdfItem? RotatorBrake { get; set; }
        public PdfItem? JoystickHolder { get; set; }
        public PdfItem? HoseGuard { get; set; }
        public PdfItem? TurningDeviceCounterPlate { get; set; }
        public PdfItem? SupportLegCounterPlate { get; set; }
        public PdfItem? BoomGuard { get; set; }
        public PdfItem? Cover { get; set; }
        public PdfItem? WoodControl { get; set; }
        public PdfItem? Linkage { get; set; }
        public PdfItem? CraneShipping { get; set; }
    }
}
