namespace CalcAppAPI.Application.Dtos.Krpan.Trailer.Options
{
    public class SimpleOptionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
    }

    public class PropulsionDto : SimpleOptionDto { }
    public class KrpanBrakeDto : SimpleOptionDto { }
    public class KrpanTyreDto : SimpleOptionDto { }
    public class KrpanTrailerSupportLegDto : SimpleOptionDto { }
    public class KrpanAdjustableDriveDto : SimpleOptionDto { }
    public class KrpanTrailerLampDto : SimpleOptionDto { }
    public class KrpanChockDto : SimpleOptionDto { }
    public class KrpanDrawbarSteeringDto : SimpleOptionDto { }
    public class KrpanHandBrakeDto : SimpleOptionDto { }
    public class KrpanDrawheadDto : SimpleOptionDto { }
    public class KrpanStanchionDto : SimpleOptionDto { }
    public class KrpanExtraForwarderStanchionDto : SimpleOptionDto { }
    public class KrpanTopConnectionDto : SimpleOptionDto { }
    public class KrpanClutchDto : SimpleOptionDto { }
    public class KrpanDrawbarDto : SimpleOptionDto { }
    public class KrpanTrailerCouplingDeviceDto : SimpleOptionDto { }
    public class KrpanCardanShaftDto : SimpleOptionDto { }
    public class KrpanBBoxDto : SimpleOptionDto { }
    public class KrpanBaleTransportPlatformDto : SimpleOptionDto { }
    public class KrpanCargoSpaceExtensionDto : SimpleOptionDto { }
    public class KrpanAxeHolderDto : SimpleOptionDto { }
    public class KrpanChainsawHolderDto : SimpleOptionDto { }
    public class KrpanFuelTankHolderDto : SimpleOptionDto { }
    public class KrpanToolBoxDto : SimpleOptionDto { }
    public class KrpanPlatoDto : SimpleOptionDto { }
    public class KrpanExtensionDto : SimpleOptionDto { }
    public class KrpanGrappleLocationDto : SimpleOptionDto { }
    public class KrpanMechanicalAdjustableFrameDto : SimpleOptionDto { }
    public class KrpanCardanShaftSimpleDto : SimpleOptionDto { }
}
