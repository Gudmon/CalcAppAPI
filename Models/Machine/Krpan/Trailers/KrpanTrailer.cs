using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Krpan.Cranes;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Krpan.Trailers
{
    public class KrpanTrailer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string LoadCapacity { get; set; }
        public string CentralBeams { get; set; }
        public string LoadingLength { get; set; }
        public string LoadingLengthWithExtension { get; set; }
        public string TotalLength { get; set; }
        public string TotalLengthWithExtension { get; set; }
        public string TotalWidth { get; set; }
        public string Weight { get; set; }
        public string FrameSteeringCylinders { get; set; }
        public string DrawbarAngle { get; set; }
        public IEnumerable<KrpanCrane> KrpanCrane { get; set; }
        public IEnumerable<KrpanPropulsion> KrpanPropulsion { get; set; }
        public KrpanAdjustableDrive? KrpanAdjustableDrive { get; set; }
        public int? KrpanAdjustableDriveId { get; set; }
        public IEnumerable<KrpanTyre> KrpanTyre { get; set; }
        public IEnumerable<KrpanBrake> KrpanBrake { get; set; }
        public KrpanHandBrake? KrpanHandBrake { get; set; }
        public int? KrpanHandBrakeId { get; set; }
        public KrpanDrawhead? KrpanDrawHead { get; set; }
        public int? KrpanDrawHeadId { get; set; }
        public KrpanExtraStanchion? KrpanExtraStanchion { get; set; }
        public int? KrpanExtraStanchionId { get; set; }
        public KrpanExtraForwarderStanchion? KrpanExtraForwarderStanchion { get; set; }
        public int? KrpanExtraForwarderStanchionId { get; set; }
        public KrpanTopConnection? KrpanTopConnection { get; set; }
        public int? KrpanTopConnectionId { get; set; }
        public IEnumerable<KrpanClutch> KrpanClutch { get; set; }
        public IEnumerable<KrpanDrawbar> KrpanDrawbar { get; set; }
        public KrpanCardanShaft? KrpanCardanShaft { get; set; }
        public int? KrpanCardanShaftId { get; set; }
        public KrpanBBox? KrpanBBox { get; set; }
        public int? KrpanBBoxId { get; set; }
        public KrpanBaleTransportPlatform? KrpanBaleTransportPlatform { get; set; }
        public int? KrpanBaleTransportPlatformId { get; set; }
        public KrpanCargoSpaceExtension? KrpanCargoSpaceExtension { get; set; }
        public int? KrpanCargoSpaceExtensionId { get; set; }
        public KrpanAxeHolder? KrpanAxeHolder { get; set; }
        public int? KrpanAxeHolderId { get; set; }
        public KrpanChainsawHolder? KrpanChainsawHolder { get; set; }
        public int? KrpanChainsawHolderId { get; set; }
        public KrpanFuelTankHolder? KrpanFuelTankHolder { get; set; }
        public int? KrpanFuelTankHolderId { get; set; }
        public KrpanToolBox? KrpanToolBox { get; set; }
        public int? KrpanToolBoxId { get; set; }
        public KrpanPlato? KrpanPlato { get; set; }
        public int? KrpanPlatoId { get; set; }
        public KrpanExtension? KrpanExtension { get; set; }
        public int? KrpanExtensionId { get; set; }
        public KrpanHydraulicSupportLeg? KrpanHydraulicSupportLeg { get; set; }
        public int? KrpanHydraulicSupportLegId { get; set; }
        public KrpanGrappleLocation? KrpanGrappleLocation { get; set; }
        public int? KrpanGrappleLocationId { get; set; }
    }
}
