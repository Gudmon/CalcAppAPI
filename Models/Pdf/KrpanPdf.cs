namespace CalcAppAPI.Models.Pdf
{
    public class KrpanPdf
    {
        public string TotalPrice { get; set; }
        //TRAILER
        public string? TrailerName { get; set; }
        public PdfItem? ExtraStanchion { get; set; }
        public PdfItem? ExtraForwarderStanchion { get; set; }
        public PdfItem? HydraulicAdjustableChassis { get; set; }
        public PdfItem? Lamp { get; set; }
        public PdfItem? Chock { get; set; }
        public PdfItem? DrawbarSteering { get; set; }
        public PdfItem? SupportLeg { get; set; }
        public PdfItem? Tyre { get; set; }
        public PdfItem? Brake { get; set; }
        public PdfItem? HandBrake { get; set; }
        public PdfItem? Propulsion { get; set; }
        public PdfItem? AdjustableDrive { get; set; }
        public PdfItem? TopConnection { get; set; }
        public PdfItem? Clutch { get; set; }
        public PdfItem? DrawHead { get; set; }
        public PdfItem? DrawBar { get; set; }
        public PdfItem? CardanShaft { get; set; }
        public PdfItem? BBox { get; set; }
        public PdfItem? BaleTransportPlatform { get; set; }
        public PdfItem? CargoSpaceExtension { get; set; }
        public PdfItem? AxeHolder { get; set; }
        public PdfItem? ChainsawHolder { get; set; }
        public PdfItem? FueltankHolder { get; set; }
        public PdfItem? ToolBox { get; set; }
        public PdfItem? Plato { get; set; }
        public PdfItem? Extension { get; set; }
        public PdfItem? HydraulicSupportLeg { get; set; }
        public PdfItem? GrappleLocation { get; set; }

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
