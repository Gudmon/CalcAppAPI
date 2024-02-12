namespace CalcAppAPI.Models.Machine.Configurations.Trailers
{
    public class OilTankCooler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public IEnumerable<OilTank> OilTank { get; set; }
    }
}
