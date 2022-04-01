﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SBTC1.Models;

namespace SBTC1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210613101341_AddingDisplayName")]
    partial class AddingDisplayName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusBookingSystem.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("UserType").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusOperatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BusTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusType")
                        .HasColumnType("int");

                    b.Property<string>("BusVehicleNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ratings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RouteSequence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSeat")
                        .HasColumnType("int");

                    b.HasKey("BusId");

                    b.HasIndex("BusOperatorId")
                        .IsUnique()
                        .HasFilter("[BusOperatorId] IS NOT NULL");

                    b.ToTable("Bus");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.BusRoute", b =>
                {
                    b.Property<int>("BusRouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RouteOrder")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketPrice")
                        .HasColumnType("int");

                    b.HasKey("BusRouteId");

                    b.HasIndex("BusId");

                    b.ToTable("BusRoute");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.PassengerInfo", b =>
                {
                    b.Property<int>("PassengerInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PAge")
                        .HasColumnType("int");

                    b.Property<int>("PGender")
                        .HasColumnType("int");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PSeatNo")
                        .HasColumnType("int");

                    b.HasKey("PassengerInfoId");

                    b.ToTable("PassengerInfo");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<int>("BusRouteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfJourney")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeatStructure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.HasIndex("BusRouteId")
                        .IsUnique();

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfJourney")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PBankName")
                        .HasColumnType("int");

                    b.Property<string>("PBankSecretCode")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PNRCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PPhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("PUserRatings")
                        .HasColumnType("int");

                    b.Property<int>("PassengerCount")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketPrice")
                        .HasColumnType("int");

                    b.Property<string>("TicketStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Transaction", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("PassengerInfoId")
                        .HasColumnType("int");

                    b.HasKey("TicketId", "PassengerInfoId");

                    b.HasIndex("PassengerInfoId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Admin", b =>
                {
                    b.HasBaseType("BusBookingSystem.Models.Entities.ApplicationUser");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.BusOperator", b =>
                {
                    b.HasBaseType("BusBookingSystem.Models.Entities.ApplicationUser");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Bus Operator");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Passenger", b =>
                {
                    b.HasBaseType("BusBookingSystem.Models.Entities.ApplicationUser");

                    b.HasDiscriminator().HasValue("Passenger");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Bus", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.BusOperator", "BusOperator")
                        .WithOne("Bus")
                        .HasForeignKey("BusBookingSystem.Models.Entities.Bus", "BusOperatorId");
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.BusRoute", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.Bus", "Bus")
                        .WithMany("BusRoutes")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Seat", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.BusRoute", "BusRoute")
                        .WithOne("Seat")
                        .HasForeignKey("BusBookingSystem.Models.Entities.Seat", "BusRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BusBookingSystem.Models.Entities.Transaction", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.PassengerInfo", "PassengerInfo")
                        .WithMany("Transactions")
                        .HasForeignKey("PassengerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusBookingSystem.Models.Entities.Ticket", "Ticket")
                        .WithMany("Transactions")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusBookingSystem.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BusBookingSystem.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
