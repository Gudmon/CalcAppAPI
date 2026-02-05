namespace CalcAppAPI.Application.Services.Pdf.Mapping
{
    public class PropertyDisplayNameResolver : IPropertyDisplayNameResolver
    {
        private static readonly Dictionary<string, string> Mapping = new()
        {
            //TRAILERS
            { "Stanchion", "Rakonca" },
            { "Brake", "Fék" },
            { "Propulsion", "Hajtás" },
            { "Drawbar", "Vonórúd" },
            { "Platform", "Kezelő platform" },
            { "HydroPack", "Hydropack" },
            { "OilPump", "Olajpumpa" },
            { "OilTank", "Olajtank" },
            { "TrailerOilCooler", "Pótkocsi olajhűtő" },
            { "BolsterLock", "Rakonca rögzítő" },
            { "BBox", "Biomasszás boksz" },
            { "DBox", "Billenős boksz" },
            { "Toolbox", "Szerszámláda" },
            { "HayBaleFrame", "Szénabála keret" },
            { "WoodSorter", "Faosztályozó" },
            { "HandBrake", "Kézifék" },
            { "ChainsawHolder", "Láncfűrész tartó" },
            { "UnderrunProtection", "Aláfutásgátló" },
            { "BunkAdapter", "Bunk adapter" },
            { "BunkExtension", "Bunk kiterjesztés" },
            { "FrameExtension", "Raktér hosszabbítás" },
            { "StanchionExtension", "Rakonca hosszabbítás" },
            { "TrailerLight", "Pótkocsi világítás" },
            { "SupportLeg", "Kitámasztó láb" },
            { "Tyre", "Kerék" },
            { "TrailerShipping", "Szállítás" },
            { "MOT", "Műszaki vizsga" },

            //CRANES
            { "Crane", "Daru" },
            { "ControlBlock", "Vezértömb" },
            { "FrameType", "Talpaló" },
            { "Rotator", "Rotátor" },
            { "Grapple", "Kanál" },
            { "Grapples", "Kanál" },
            { "Winch", "Csörlő" },
            { "ProtectionSleeves", "Védőhüvely" },
            { "ElectricalFloating", "Úszó pozíció" },
            { "ValveBlock", "Vezértömb főgémhez" },
            { "Damping", "Csillapító" },
            { "CraneLight", "LED munkalámpák" },
            { "OperatorSeat", "Kezelő ülés" },
            { "HighPerformanceOilFilter", "Nagynyomású olajszűrő" },
            { "CraneOilCooler", "Olajhűtő eleketromos csatlakozással" },
            { "RotatorBrake", "Rotátor fék" },
            { "JoystickHolder", "Joystick tartó" },
            { "HoseGuard", "Tömlő védő" },
            { "TurningDeviceCounterPlate", "Fedőlap fordító szerkezethez" },
            { "SupportLegCounterPlate", "Fedőlap talpaló lábhoz" },
            { "BoomGuard", "Főgém védő" },
            { "Cover", "Védőhuzat" },
            { "WoodControl", "Fás kiegészítő" },
            { "Linkage", "Csatlakozó adapter" },
            { "CraneShipping", "Szállítás" },
    };

        public string Resolve(string propertyName)
            => Mapping.TryGetValue(propertyName, out var value)
               ? value
               : propertyName;
    }
}
