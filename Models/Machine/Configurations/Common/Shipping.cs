﻿using CalcAppAPI.Models.Machine.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class Shipping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
        public IEnumerable<Trailer> Trailer { get; set; }
    }
}
