﻿// <auto-generated />
using CalcAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalcAppAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalcAppAPI.Models.Crane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrutLiftingTorque190Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrutLiftingTorque215Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrutLiftingTorque240Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CraneWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFourMeters190Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFourMeters215Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFourMeters240Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFullReach190Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFullReach215Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiftAtFullReach240Bar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxReach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PillarSlewingAngle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendedOilFLow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RotatorMaximumLoad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlewingCylinder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlewingTorque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingPressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Crane");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrutLiftingTorque190Bar = "26",
                            BrutLiftingTorque215Bar = "-",
                            BrutLiftingTorque240Bar = "-",
                            CraneWeight = "360",
                            Description = "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.",
                            LiftAtFourMeters190Bar = "570",
                            LiftAtFourMeters215Bar = "-",
                            LiftAtFourMeters240Bar = "-",
                            LiftAtFullReach190Bar = "540",
                            LiftAtFullReach215Bar = "-",
                            LiftAtFullReach240Bar = "-",
                            MaxReach = "4.2",
                            Name = "Forest crane PALMS 2.42",
                            PillarSlewingAngle = "370",
                            Price = "5165",
                            RecommendedOilFLow = "20-35",
                            RotatorMaximumLoad = "45",
                            Series = "2",
                            SlewingCylinder = "4",
                            SlewingTorque = "7.8",
                            WorkingPressure = "190"
                        });
                });

            modelBuilder.Entity("CalcAppAPI.Models.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BeamType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurbWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrawbarControlCylinders")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrameExtensionLength")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrossWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoadingAreaCross")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoadingAreaLength")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxCraneSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StanchionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandardWheelSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalLength")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WidthWithStandardWheels")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trailer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeamType = "Single",
                            CurbWeight = "890",
                            Description = "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.",
                            DrawbarControlCylinders = "1",
                            Frame = "140x140x6",
                            FrameExtensionLength = "-",
                            GrossWeight = "8500",
                            LoadingAreaCross = "1.5",
                            LoadingAreaLength = "3000",
                            MaxCraneSize = "35",
                            Name = "PALMS 6S",
                            Price = "5285",
                            StanchionNumber = "3",
                            StandardWheelSize = "400/60-15,5",
                            TotalLength = "4900",
                            WidthWithStandardWheels = "1950"
                        });
                });

            modelBuilder.Entity("CraneTrailer", b =>
                {
                    b.Property<int>("CraneId")
                        .HasColumnType("int");

                    b.Property<int>("TrailerId")
                        .HasColumnType("int");

                    b.HasKey("CraneId", "TrailerId");

                    b.HasIndex("TrailerId");

                    b.ToTable("CraneTrailer", (string)null);

                    b.HasData(
                        new
                        {
                            CraneId = 1,
                            TrailerId = 1
                        });
                });

            modelBuilder.Entity("CraneTrailer", b =>
                {
                    b.HasOne("CalcAppAPI.Models.Crane", null)
                        .WithMany()
                        .HasForeignKey("CraneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalcAppAPI.Models.Trailer", null)
                        .WithMany()
                        .HasForeignKey("TrailerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
