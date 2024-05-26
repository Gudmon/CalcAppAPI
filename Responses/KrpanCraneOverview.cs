namespace CalcAppAPI.Responses
{
    public class KrpanCraneOverview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MaxReach { get; set; }
        public string MaxReachWithGrabOpen { get; set; }
        public string NetLiftingTorque { get; set; }
        public string LiftCapacityAtFourMeters { get; set; }
    }
}
