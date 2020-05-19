﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sygic.Corona.Infrastructure;

namespace Sygic.Corona.Infrastructure.Migrations
{
    [DbContext(typeof(CoronaContext))]
    [Migration("20200519080322_ChangeLatLonPrecision")]
    partial class ChangeLatLonPrecision
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sygic.Corona.Domain.Alert", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.AreaExit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RecordDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("AreaExits");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Accuracy")
                        .HasColumnType("float");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<long>("SeenProfileId")
                        .HasColumnType("bigint");

                    b.Property<string>("SourceDeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Timestamp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.ExposureKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<int>("RollingDuration")
                        .HasColumnType("int");

                    b.Property<int>("RollingStartNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExposureKeys");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Accuracy")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.PresenceCheck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadLineCheck")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProfileId");

                    b.ToTable("PresenceChecks");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Profile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BorderCrossedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ConfirmedInfection")
                        .HasColumnType("bit");

                    b.Property<string>("CovidPass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInQuarantine")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastInactivityNotificationSendTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastPositionReportTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PushToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("QuarantineBeginning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("QuarantineEnd")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.PushNonce", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("PushNonces");
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Alert", b =>
                {
                    b.HasOne("Sygic.Corona.Domain.Profile", null)
                        .WithMany("Alerts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sygic.Corona.Domain.AreaExit", b =>
                {
                    b.HasOne("Sygic.Corona.Domain.Profile", null)
                        .WithMany("AreaExits")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Contact", b =>
                {
                    b.HasOne("Sygic.Corona.Domain.Profile", null)
                        .WithMany("Contacts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Location", b =>
                {
                    b.HasOne("Sygic.Corona.Domain.Profile", null)
                        .WithMany("Locations")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sygic.Corona.Domain.PresenceCheck", b =>
                {
                    b.HasOne("Sygic.Corona.Domain.Profile", null)
                        .WithMany("PresenceChecks")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sygic.Corona.Domain.Profile", b =>
                {
                    b.OwnsOne("Sygic.Corona.Domain.Address", "QuarantineAddress", b1 =>
                        {
                            b1.Property<long>("ProfileId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("CountryCode")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("Latitude")
                                .HasColumnType("decimal(11, 8)");

                            b1.Property<decimal>("Longitude")
                                .HasColumnType("decimal(11, 8)");

                            b1.Property<string>("StreetName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProfileId");

                            b1.ToTable("Profiles");

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });

                    b.OwnsOne("Sygic.Corona.Domain.ClientInfo", "ClientInfo", b1 =>
                        {
                            b1.Property<long>("ProfileId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Integrator")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("OperationSystem")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Version")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProfileId");

                            b1.ToTable("Profiles");

                            b1.WithOwner()
                                .HasForeignKey("ProfileId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
