﻿using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanTrailerConfig
    {
        public static void ConfigureMultipleKrpanTrailers(this ModelBuilder modelBuilder)
        {
            //TODO: HYDRAULIC SUPPORT LEG ID CHECK FOR "GP" TRAILERS, NULL NOW, NEEDS CLARIFICATION
            modelBuilder.Entity<KrpanTrailer>().HasData(
                new KrpanTrailer
                {
                    Id = 1,
                    Name = "GP 8 DF",
                    Description = "",
                    Price = "10300",
                    LoadCapacity = "8000",
                    CentralBeams = "2/180×100x6",
                    LoadingLength = "3582",
                    LoadingLengthWithExtension = "4477",
                    TotalLength = "5919",
                    TotalLengthWithExtension = "6814",
                    TotalWidth = "2067",
                    Weight = "1690",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = null,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 1,
                    KrpanExtraForwarderStanchionId = null,
                    KrpanTopConnectionId = 1,
                    KrpanDrawHeadId = 1,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 1,
                    KrpanBaleTransportPlatformId = 1,
                    KrpanCargoSpaceExtensionId = 2,
                    KrpanAxeHolderId = 2,
                    KrpanChainsawHolderId = 2,
                    KrpanFuelTankHolderId = 2,
                    KrpanToolBoxId = 2,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 2,
                    Name = "GP 9 DF",
                    Description = "",
                    Price = "10865",
                    LoadCapacity = "9000",
                    CentralBeams = "2/180×100x6",
                    LoadingLength = "3582",
                    LoadingLengthWithExtension = "4477",
                    TotalLength = "5919",
                    TotalLengthWithExtension = "6814",
                    TotalWidth = "2067",
                    Weight = "1690",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = null,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 1,
                    KrpanExtraForwarderStanchionId = null,
                    KrpanTopConnectionId = 1,
                    KrpanDrawHeadId = 1,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 1,
                    KrpanBaleTransportPlatformId = 1,
                    KrpanCargoSpaceExtensionId = 2,
                    KrpanAxeHolderId = 2,
                    KrpanChainsawHolderId = 2,
                    KrpanFuelTankHolderId = 2,
                    KrpanToolBoxId = 2,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 3,
                    Name = "GP 10 DF",
                    Description = "",
                    Price = "11430",
                    LoadCapacity = "10000",
                    CentralBeams = "2/180×100x6",
                    LoadingLength = "3582",
                    LoadingLengthWithExtension = "4477",
                    TotalLength = "5919",
                    TotalLengthWithExtension = "6814",
                    TotalWidth = "2067",
                    Weight = "1690",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = null,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 1,
                    KrpanExtraForwarderStanchionId = null,
                    KrpanTopConnectionId = 1,
                    KrpanDrawHeadId = 1,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 1,
                    KrpanBaleTransportPlatformId = 1,
                    KrpanCargoSpaceExtensionId = 2,
                    KrpanAxeHolderId = 2,
                    KrpanChainsawHolderId = 2,
                    KrpanFuelTankHolderId = 2,
                    KrpanToolBoxId = 2,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 4,
                    Name = "GP 12 DF",
                    Description = "",
                    Price = "13060",
                    LoadCapacity = "12000",
                    CentralBeams = "2/180×100x6",
                    LoadingLength = "3975",
                    LoadingLengthWithExtension = "4755",
                    TotalLength = "6209",
                    TotalLengthWithExtension = "7100",
                    TotalWidth = "2122",
                    Weight = "2100",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = null,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 1,
                    KrpanExtraForwarderStanchionId = 1,
                    KrpanTopConnectionId = 1,
                    KrpanDrawHeadId = 1,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 1,
                    KrpanBaleTransportPlatformId = 1,
                    KrpanCargoSpaceExtensionId = 2,
                    KrpanAxeHolderId = 2,
                    KrpanChainsawHolderId = 2,
                    KrpanFuelTankHolderId = 2,
                    KrpanToolBoxId = 2,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 5,
                    Name = "GP 14 DF",
                    Description = "",
                    Price = "14915",
                    LoadCapacity = "14000",
                    CentralBeams = "2/200×100x8",
                    LoadingLength = "4325",
                    LoadingLengthWithExtension = "5105",
                    TotalLength = "6559",
                    TotalLengthWithExtension = "7545",
                    TotalWidth = "2222",
                    Weight = "2300",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = null,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 1,
                    KrpanExtraForwarderStanchionId = 1,
                    KrpanTopConnectionId = 1,
                    KrpanDrawHeadId = 1,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 1,
                    KrpanBaleTransportPlatformId = 1,
                    KrpanCargoSpaceExtensionId = 2,
                    KrpanAxeHolderId = 2,
                    KrpanChainsawHolderId = 2,
                    KrpanFuelTankHolderId = 2,
                    KrpanToolBoxId = 2,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },

                new KrpanTrailer
                {
                    Id = 6,
                    Name = "GP 11 D",
                    Description = "",
                    Price = "13510",
                    LoadCapacity = "11000",
                    CentralBeams = "2/180×100x6",
                    LoadingLength = "3707",
                    LoadingLengthWithExtension = "4487",
                    TotalLength = "5944",
                    TotalLengthWithExtension = "6724",
                    TotalWidth = "2152",
                    Weight = "1734",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = 1,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 2,
                    KrpanExtraForwarderStanchionId = null,
                    KrpanTopConnectionId = null,
                    KrpanDrawHeadId = 2,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 2,
                    KrpanBaleTransportPlatformId = 2,
                    KrpanCargoSpaceExtensionId = null,
                    KrpanAxeHolderId = 1,
                    KrpanChainsawHolderId = 1,
                    KrpanFuelTankHolderId = 1,
                    KrpanToolBoxId = 1,
                    KrpanPlatoId = null,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 7,
                    Name = "GP 13 D",
                    Description = "",
                    Price = "15310",
                    LoadCapacity = "13000",
                    CentralBeams = "2/200×100x6",
                    LoadingLength = "3975",
                    LoadingLengthWithExtension = "4755",
                    TotalLength = "6334",
                    TotalLengthWithExtension = "7144",
                    TotalWidth = "2200",
                    Weight = "2144",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = 1,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 2,
                    KrpanExtraForwarderStanchionId = 1,
                    KrpanTopConnectionId = null,
                    KrpanDrawHeadId = 2,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 3,
                    KrpanBaleTransportPlatformId = 3,
                    KrpanCargoSpaceExtensionId = null,
                    KrpanAxeHolderId = 1,
                    KrpanChainsawHolderId = 1,
                    KrpanFuelTankHolderId = 1,
                    KrpanToolBoxId = 1,
                    KrpanPlatoId = 1,
                    KrpanExtensionId = null,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                },
                new KrpanTrailer
                {
                    Id = 8,
                    Name = "GP 15 D",
                    Description = "",
                    Price = "16960",
                    LoadCapacity = "14800",
                    CentralBeams = "2/200×100x8",
                    LoadingLength = "4325",
                    LoadingLengthWithExtension = "5105",
                    TotalLength = "6686",
                    TotalLengthWithExtension = "6686",
                    TotalWidth = "2318",
                    Weight = "2352",
                    FrameSteeringCylinders = "2",
                    DrawbarAngle = "40",
                    KrpanHydraulicAdjustableChassisId = 1,
                    KrpanTrailerLampId = 1,
                    KrpanChockId = 1,
                    KrpanDrawbarSteeringId = 1,
                    KrpanTrailerSupportLegId = 1,
                    KrpanAdjustableDriveId = 1,
                    KrpanHandBrakeId = 1,
                    KrpanExtraStanchionId = 2,
                    KrpanExtraForwarderStanchionId = 1,
                    KrpanTopConnectionId = null,
                    KrpanDrawHeadId = 2,
                    KrpanCardanShaftId = 1,
                    KrpanBBoxId = 4,
                    KrpanBaleTransportPlatformId = 4,
                    KrpanCargoSpaceExtensionId = null,
                    KrpanAxeHolderId = 1,
                    KrpanChainsawHolderId = 1,
                    KrpanFuelTankHolderId = 1,
                    KrpanToolBoxId = 1,
                    KrpanPlatoId = 1,
                    KrpanExtensionId = 1,
                    KrpanHydraulicSupportLegId = null,
                    KrpanGrappleLocationId = 1,
                }
                );
        }
    }
}
