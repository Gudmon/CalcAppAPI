using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Pdf
{
    public enum OptionGroup
    {
        // Trailer
        [Display(Name = "Rakonca")]
        Stanchion,

        [Display(Name = "Fék")]
        Brake,

        [Display(Name = "Hajtás")]
        Propulsion,

        [Display(Name = "Vonórúd")]
        Drawbar,

        [Display(Name = "Kezelő platform")]
        Platform,

        [Display(Name = "Hydropack")]
        HydroPack,

        [Display(Name = "Olajpumpa")]
        OilPump,

        [Display(Name = "Olajtank")]
        OilTank,

        [Display(Name = "Pótkocsi olajhűtő")]
        TrailerOilCooler,

        [Display(Name = "Rakonca rögzítő")]
        BolsterLock,

        [Display(Name = "Biomasszás boksz")]
        BBox,

        [Display(Name = "Billenős boksz")]
        DBox,

        [Display(Name = "Szerszámláda")]
        Toolbox,

        [Display(Name = "Szénabála keret")]
        HayBaleFrame,

        [Display(Name = "Faosztályozó")]
        WoodSorter,

        [Display(Name = "Kézifék")]
        HandBrake,

        [Display(Name = "Láncfűrész tartó")]
        ChainsawHolder,

        [Display(Name = "Aláfutásgátló")]
        UnderrunProtection,

        [Display(Name = "Bunk adapter")]
        BunkAdapter,

        [Display(Name = "Bunk szélesítés")]
        BunkExtension,

        [Display(Name = "Bunk szélesítés")]
        ManualBunkExtension,

        [Display(Name = "Raktér hosszabbítás")]
        FrameExtension,

        [Display(Name = "Rakonca hosszabbítás")]
        StanchionExtension,

        [Display(Name = "Kitámasztó láb")]
        SupportLeg,

        [Display(Name = "Pótkocsi világítás")]
        TrailerLight,

        [Display(Name = "Kerék")]
        Tyre,

        [Display(Name = "Pótkocsi szállítása")]
        TrailerShipping,

        [Display(Name = "Műszaki vizsga")]
        MOT,

        // Crane
        [Display(Name = "Daru")]
        Crane,

        [Display(Name = "Vezértömb")]
        ControlBlock,

        [Display(Name = "Talpaló")]
        FrameType,

        [Display(Name = "Kanál")]
        Grapple,

        [Display(Name = "Csörlő")]
        Winch,

        [Display(Name = "Védőhüvely")]
        ProtectionSleeves,

        [Display(Name = "Úszó pozíció")]
        ElectricalFloating,

        [Display(Name = "Vezértömb főgémhez")]
        ValveBlock,

        [Display(Name = "Csillapító")]
        Damping,

        [Display(Name = "Daru világítás")]
        CraneLight,

        [Display(Name = "Kezelő ülés")]
        OperatorSeat,

        [Display(Name = "Nagynyomású olajszűrő")]
        HighPerformanceOilFilter,

        [Display(Name = "Daru olajhűtő")]
        CraneOilCooler,

        [Display(Name = "Rotátor")]
        Rotator,

        [Display(Name = "Rotátor fék")]
        RotatorBrake,

        [Display(Name = "Joystick tartó")]
        JoystickHolder,

        [Display(Name = "Tömlő védő")]
        HoseGuard,

        [Display(Name = "Fedőlap fordító szerkezethez")]
        TurningDeviceCounterPlate,

        [Display(Name = "Fedőlap talpaló lábhoz")]
        SupportLegCounterPlate,

        [Display(Name = "Főgém védő")]
        BoomGuard,

        [Display(Name = "Védőhuzat")]
        Cover,

        [Display(Name = "Fás kiegészítő")]
        WoodControl,

        [Display(Name = "Csatlakozó adapter")]
        Linkage,

        [Display(Name = "Konzol")]
        SupportBracket,

        [Display(Name = "Daru szállítása")]
        CraneShipping
    }
}
