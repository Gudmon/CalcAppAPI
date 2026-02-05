using CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes;
using CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers;
using CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan
{
    public static class ConfigureKrpanOptions
    {
        //TODO: REFACTOR
        public static void ConfigureAllKrpanMachineOptions(this ModelBuilder modelBuilder)
        {
            ////// KRPAN
            modelBuilder.ConfigureMultipleKrpanTrailers();
            modelBuilder.ConfigureMultipleKrpanHydraulicAdjustableChassis();
            modelBuilder.ConfigureMultipleKrpanTrailerLamps();
            modelBuilder.ConfigureMultipleKrpanChocks();
            modelBuilder.ConfigureMultipleKrpanDrawbarSteerings();
            modelBuilder.ConfigureMultipleKrpanTrailerSupportLegs();
            modelBuilder.ConfigureMultipleKrpanPropulsions();
            modelBuilder.ConfigureMultipleKrpanAdjustableDrives();
            modelBuilder.ConfigureMultipleKrpanTyres();
            modelBuilder.ConfigureMultipleKrpanBrakes();
            modelBuilder.ConfigureMultipleKrpanHandBrakes();
            modelBuilder.ConfigureMultipleKrpanExtraStanchions();
            modelBuilder.ConfigureMultipleKrpanExtraForwarderStanchions();
            modelBuilder.ConfigureMultipleKrpanTopConnections();
            modelBuilder.ConfigureMultipleKrpanClutches();
            modelBuilder.ConfigureMultipleKrpanDrawheads();
            modelBuilder.ConfigureMultipleKrpanDrawbars();
            modelBuilder.ConfigureMultipleKrpanCardanShafts();
            modelBuilder.ConfigureMultipleKrpanBBoxes();
            modelBuilder.ConfigureMultipleKrpanBaleTransportPlatforms();
            modelBuilder.ConfigureMultipleKrpanCargoSpaceExtensions();
            modelBuilder.ConfigureMultipleKrpanAxeHolders();
            modelBuilder.ConfigureMultipleKrpanChainsawHolders();
            modelBuilder.ConfigureMultipleKrpanFuelTankHolders();
            modelBuilder.ConfigureMultipleKrpanToolBoxes();
            modelBuilder.ConfigureMultipleKrpanPlatos();
            modelBuilder.ConfigureMultipleKrpanExtensions();
            modelBuilder.ConfigureMultipleKrpanHydraulicSupportLegs();
            modelBuilder.ConfigureMultipleKrpanGrappleLocations();


            modelBuilder.ConfigureMultipleKrpanCranes();

            modelBuilder.ConnectKrpanTrailersWithCranes();

            //HYDRAULIC ADJUSTABLE CHASSIS
            modelBuilder.Entity<KrpanHydraulicAdjustableChassis>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHydraulicAdjustableChassis)
                .HasForeignKey(o => o.KrpanHydraulicAdjustableChassisId)
                .IsRequired(false);

            //TRAILER LAMP
            modelBuilder.Entity<KrpanTrailerLamp>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTrailerLamp)
                .HasForeignKey(o => o.KrpanTrailerLampId)
                .IsRequired(false);

            //CHOCK
            modelBuilder.Entity<KrpanChock>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanChock)
                .HasForeignKey(o => o.KrpanChockId)
                .IsRequired(false);

            //DRAWBAR STEERING
            modelBuilder.Entity<KrpanDrawbarSteering>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanDrawbarSteering)
                .HasForeignKey(o => o.KrpanDrawbarSteeringId)
                .IsRequired(false);

            //TRAILER SUPPORT LEG
            modelBuilder.Entity<KrpanTrailerSupportLeg>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTrailerSupportLeg)
                .HasForeignKey(o => o.KrpanTrailerSupportLegId)
                .IsRequired(false);

            modelBuilder.ConnectKrpanTrailersWithBrakes();
            modelBuilder.ConnectKrpanTrailersWithPropulsions();

            //ADJUSTABLE DRIVE
            modelBuilder.Entity<KrpanAdjustableDrive>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanAdjustableDrive)
                .HasForeignKey(o => o.KrpanAdjustableDriveId)
                .IsRequired(false);

            modelBuilder.ConnectKrpanTrailersWithTyres();

            //HANDBRAKE
            modelBuilder.Entity<KrpanHandBrake>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHandBrake)
                .HasForeignKey(o => o.KrpanHandBrakeId)
                .IsRequired(false);

            //EXTRA STANCHION
            modelBuilder.Entity<KrpanExtraStanchion>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtraStanchion)
                .HasForeignKey(o => o.KrpanExtraStanchionId)
                .IsRequired(false);

            //EXTRA FORWARDER STANCHION
            modelBuilder.Entity<KrpanExtraForwarderStanchion>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtraForwarderStanchion)
                .HasForeignKey(o => o.KrpanExtraForwarderStanchionId)
                .IsRequired(false);

            //TOP CONNECTION
            modelBuilder.Entity<KrpanTopConnection>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTopConnection)
                .HasForeignKey(o => o.KrpanTopConnectionId)
                .IsRequired(false);

            modelBuilder.ConnectKrpanTrailersWithClutches();

            //DRAWHEAD
            modelBuilder.Entity<KrpanDrawhead>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanDrawHead)
                .HasForeignKey(o => o.KrpanDrawHeadId)
                .IsRequired(false);

            modelBuilder.ConnectKrpanTrailersWithDrawbars();

            //CARDAN SHAFT
            modelBuilder.Entity<KrpanCardanShaft>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanCardanShaft)
                .HasForeignKey(o => o.KrpanCardanShaftId)
                .IsRequired(false);

            //KRPAN BBOX
            modelBuilder.Entity<KrpanBBox>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanBBox)
                .HasForeignKey(o => o.KrpanBBoxId)
                .IsRequired(false);

            //BALE TRANSPORT PLATFORM
            modelBuilder.Entity<KrpanBaleTransportPlatform>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanBaleTransportPlatform)
                .HasForeignKey(o => o.KrpanBaleTransportPlatformId)
                .IsRequired(false);

            //CARGO SPACE EXTENSION
            modelBuilder.Entity<KrpanCargoSpaceExtension>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanCargoSpaceExtension)
                .HasForeignKey(o => o.KrpanCargoSpaceExtensionId)
                .IsRequired(false);

            //AXE HOLDER
            modelBuilder.Entity<KrpanAxeHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanAxeHolder)
                .HasForeignKey(o => o.KrpanAxeHolderId)
                .IsRequired(false);

            //CHAINSAW HOLDER
            modelBuilder.Entity<KrpanChainsawHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanChainsawHolder)
                .HasForeignKey(o => o.KrpanChainsawHolderId)
                .IsRequired(false);

            //FUEL TANK HOLDER
            modelBuilder.Entity<KrpanFuelTankHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanFuelTankHolder)
                .HasForeignKey(o => o.KrpanFuelTankHolderId)
                .IsRequired(false);

            //TOOLBOX
            modelBuilder.Entity<KrpanToolBox>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanToolBox)
                .HasForeignKey(o => o.KrpanToolBoxId)
                .IsRequired(false);

            //PLATO
            modelBuilder.Entity<KrpanPlato>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanPlato)
                .HasForeignKey(o => o.KrpanPlatoId)
                .IsRequired(false);

            //EXTENSION
            modelBuilder.Entity<KrpanExtension>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtension)
                .HasForeignKey(o => o.KrpanExtensionId)
                .IsRequired(false);

            //HYDRAULIC SUPPORT LEG
            modelBuilder.Entity<KrpanHydraulicSupportLeg>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHydraulicSupportLeg)
                .HasForeignKey(o => o.KrpanHydraulicSupportLegId)
                .IsRequired(false);

            //GRAPPLE LOCATION
            modelBuilder.Entity<KrpanGrappleLocation>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanGrappleLocation)
                .HasForeignKey(o => o.KrpanGrappleLocationId)
                .IsRequired(false);
        }

    }
}
