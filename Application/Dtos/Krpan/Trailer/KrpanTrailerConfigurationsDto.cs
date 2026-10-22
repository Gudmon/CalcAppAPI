using CalcAppAPI.Application.Dtos.Krpan.Trailer.Options;

namespace CalcAppAPI.Application.Dtos.Krpan.Trailer
{
    public class KrpanTrailerConfigurationsDto
    {
        public IEnumerable<KrpanBrakeDto> Brakes { get; set; }
        public IEnumerable<KrpanTyreDto> Tyres { get; set; }
        public IEnumerable<KrpanTrailerSupportLegDto> SupportLegs { get; set; }
        public IEnumerable<PropulsionDto> Propulsions { get; set; }
        public IEnumerable<KrpanDrawbarDto> Drawbars { get; set; }
        public KrpanAdjustableDriveDto AdjustableDrive { get; set; }
        public KrpanTrailerLampDto TrailerLamp { get; set; }
        public IEnumerable<KrpanTrailerBrakeLampDto> TrailerBrakeLamps { get; set; }
        public KrpanChockDto Chock { get; set; }
        public KrpanWheelChockDto WheelChock { get; set; }
        public KrpanDrawbarSteeringDto DrawbarSteering { get; set; }
        public IEnumerable<KrpanClutchDto> Clutches { get; set; }
        public IEnumerable<KrpanTrailerCouplingDeviceDto> TrailerCouplingDevices { get; set; }
        public KrpanCardanShaftDto CardanShaft { get; set; }
        public KrpanBBoxDto BBox { get; set; }
        public KrpanBaleTransportPlatformDto BaleTransportPlatform { get; set; }
        public KrpanCargoSpaceExtensionDto CargoSpaceExtension { get; set; }
        public KrpanAxeHolderDto AxeHolder { get; set; }
        public KrpanChainsawHolderDto ChainsawHolder { get; set; }
        public KrpanFuelTankHolderDto FuelTankHolder { get; set; }
        public KrpanToolBoxDto ToolBox { get; set; }
        public KrpanPlatoDto Plato { get; set; }
        public KrpanExtensionDto Extension { get; set; }
        public KrpanGrappleLocationDto GrappleLocation { get; set; }
        public KrpanFrameDto Frame { get; set; }
        public IEnumerable<KrpanStanchionDto> Stanchions { get; set; }
        public KrpanHandBrakeDto HandBrake { get; set; }
    }
}
