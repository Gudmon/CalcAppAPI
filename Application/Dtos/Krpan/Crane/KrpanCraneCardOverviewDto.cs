namespace CalcAppAPI.Application.Dtos.Krpan.Crane
{
    public class KrpanCraneCardOverviewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MaxReach { get; set; }
        public string MaxReachWithGrabOpen { get; set; }
        public string NetLiftingTorque { get; set; }
        public string LiftCapacityAtFourMeters { get; set; }
        public string ImageUrl { get; set; }
    }
}
