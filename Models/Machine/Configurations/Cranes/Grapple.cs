﻿namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class Grapple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public string? Area { get; set; }
        public string? Mass { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
