namespace CalcAppAPI.Application.Dtos.Palms.Crane
{
    public class CraneNestedDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Series { get; set; }
        public string MaxReach { get; set; }
        public string BrutLiftingTorque240Bar { get; set; }
        public string BrutLiftingTorque215Bar { get; set; }
        public string BrutLiftingTorque190Bar { get; set; }
        public string TelescopeLength { get; set; }
        public string SlewingCylinder { get; set; }
        public string SlewingTorque { get; set; }
    }
}
