using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
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
                  Name = "A3.1 6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar",
                  Code = "A3.1",
                  Price = "870",
                  Description = "Egyszerű és megbízható szelepblokk kisebb daruk számára"
              },
              new ControlBlock
              {
                  Id = 2,
                  Name = "A4 4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar",
                  Code = "A4",
                  Price = "1500",
                  Description = "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára"
              },
              new ControlBlock
              {
                  Id = 3,
                  Name = "A4.2 4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar",
                  Code = "A4.2",
                  Price = "1500",
                  Description = "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára"
              },
              new ControlBlock
              {
                  Id = 4,
                  Name = "A7 4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)",
                  Code = "A7",
                  Price = "1480",
                  Description = "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára"
              },
              new ControlBlock
              {
                  Id = 5,
                  Name = "A12 2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF",
                  Code = "A12",
                  Price = "4720",
                  Description = "Leginkább a PALMS 5. és 7. sorozatú darukkal használható"
              },
              new ControlBlock
              {
                   Id = 6,
                   Name = "A14 2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF",
                   Code = "A14",
                   Price = "6295",
                   Description = "Leginkább a PALMS 5. és 7. sorozatú darukkal használható"
              },
              new ControlBlock
              {
                  Id = 7,
                  Name = "A19 El.propo 8 szekciós, Walvoil DPX100, joystick, 215 bar + HPF",
                  Code = "A19",
                  Price = "6295",
                  Description = "Leginkább a PALMS 5. és 7. sorozatú darukkal használható"
              },
              new ControlBlock
              {
                  Id = 8,
                  Name = "A23 El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF",
                  Code = "A23",
                  Price = "8470",
                  Description = "Parker LC6 mini joystickek. Leginkább PALMS 5., 7. és X-sorozatú darukhoz használják"
              },
              new ControlBlock
              {
                  Id = 9,
                  Name = "A235 El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF",
                  Code = "A235",
                  Price = "8470",
                  Description = "Leginkább a PALMS 5. és 7. sorozatú darukkal használható"
              },
              new ControlBlock
              {
                  Id = 10,
                  Name = "A25.1 El.propo 8 szekciós (A23) + MD3 kijelző + HPF",
                  Code = "A25.1",
                  Price = "9415",
                  Description = "Parker LC6 mini joystick kijelzővel"
              },
              new ControlBlock
              {
                  Id = 11,
                  Name = "A26 IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF",
                  Code = "A26",
                  Price = "9110",
                  Description = "IMET rádió vezérlés PALMS erdészeti daruhoz"
              },
              new ControlBlock
              {
                  Id = 12,
                  Name = "A36 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF",
                  Code = "A36",
                  Price = "11840",
                  Description = "IMET rádióvezérlés Parker LC6 mini joystickekkel"
              },
              new ControlBlock
              {
                  Id = 13,
                  Name = "A36.1 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF",
                  Code = "A36.1",
                  Price = "12785",
                  Description = "IMET rádióvezérlés és Parker LC6 mini joystick kijelzővel"
              },
              new ControlBlock
              {
                  Id = 14,
                  Name = "A42 Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF",
                  Code = "A42",
                  Price = "14660",
                  Description = "Standard üzemmód, ahol a fő emelőhenger, a hosszabbító gém hengere és a teleszkóp hengere külön vezérelhető.\r\nPTC mód, ahol a markoló lineárisan mozgatható X, Y és Z irányban."
              },
              new ControlBlock
              {
                  Id = 15,
                  Name = "A3.1 - 6/8 XY vezértömb, BLB BM50 (50 l/min.) 195 bar",
                  Code = "A3.1",
                  Price = "805",
                  Description = "Egyszerű és megbízható szelepblokk kisebb daruk számára"
              }
              );

        }
    }
}
