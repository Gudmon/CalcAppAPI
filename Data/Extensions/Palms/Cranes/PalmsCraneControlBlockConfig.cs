using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneControlBlockConfig
    {
        public static void ConfigureMultiplePalmsControlBlocks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ControlBlock>().HasData(
              new ControlBlock
              {
                  Id = 1,
                  Name = "5/7 XY vezértömb, 195 bar",
                  Code = "A2",
                  Price = "795",
              },
              new ControlBlock
              {
                  Id = 2,
                  Name = "6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar",
                  Code = "A3.1",
                  Price = "805",
              },
              new ControlBlock
              {
                  Id = 3,
                  Name = "4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar",
                  Code = "A4",
                  Price = "1390",
              },
              new ControlBlock
              {
                  Id = 4,
                  Name = "4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar",
                  Code = "A4.2",
                  Price = "1500",
              },
              new ControlBlock
              {
                  Id = 5,
                  Name = "4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)",
                  Code = "A7",
                  Price = "1360",
              },
              new ControlBlock
              {
                  Id = 6,
                  Name = "2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF",
                  Code = "A12",
                  Price = "4720",
              },
              new ControlBlock
              {
                   Id = 7,
                   Name = "2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF",
                   Code = "A14",
                   Price = "6635",
              },
              new ControlBlock
              {
                  Id = 8,
                  Name = "El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF",
                  Code = "A23",
                  Price = "8470",
              },
              new ControlBlock
              {
                  Id = 9,
                  Name = "El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF",
                  Code = "A235",
                  Price = "8470",
              },
              new ControlBlock
              {
                  Id = 10,
                  Name = "El.propo 8 szekciós (A23) + MD3 kijelző + HPF",
                  Code = "A25.1",
                  Price = "9415",
              },
              new ControlBlock
              {
                  Id = 11,
                  Name = "IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF",
                  Code = "A26",
                  Price = "9110",
              },
              new ControlBlock
              {
                  Id = 12,
                  Name = "Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF",
                  Code = "A36",
                  Price = "11840",
              },
              new ControlBlock
              {
                  Id = 13,
                  Name = "Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF",
                  Code = "A36.1",
                  Price = "12785",
              },
              new ControlBlock
              {
                  Id = 14,
                  Name = "Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF",
                  Code = "A42",
                  Price = "14660",
              }
              );

        }
    }
}
