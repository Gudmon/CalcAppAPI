using CalcAppAPI.Application.Dtos.Palms.Trailer;

namespace CalcAppAPI.Application.Dtos.Palms.Crane
{
    public class PalmsCraneDetailsDto
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
        public string[]? ImageUrls { get; set; }
        public string[]? VideoUrls { get; set; }
        public IEnumerable<PalmsTrailerCardOverviewDto> Trailers { get; set; }
    }
}
