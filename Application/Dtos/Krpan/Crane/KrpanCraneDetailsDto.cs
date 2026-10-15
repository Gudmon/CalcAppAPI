using CalcAppAPI.Application.Dtos.Krpan.Trailer;

namespace CalcAppAPI.Application.Dtos.Krpan.Crane
{
    public class KrpanCraneDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string MaxReach { get; set; }
        public string MaxReachWithGrabOpen { get; set; }
        public string NetLiftingTorque { get; set; }
        public string BrutLiftingTorque { get; set; }
        public string LiftCapacityAtFourMeters { get; set; }
        public string LiftCapacityAtMaxReach { get; set; }
        public string Weight { get; set; }
        public string SlewTorque { get; set; }
        public string SlewingAngle { get; set; }
        public string SystemPressure { get; set; }
        public string OilQuantityInTank { get; set; }
        public string SlewCylinders { get; set; }
        public string TelescopicStages { get; set; }
        public IEnumerable<KrpanTrailerCardOverviewDto> Trailers { get; set; }
    }
}
