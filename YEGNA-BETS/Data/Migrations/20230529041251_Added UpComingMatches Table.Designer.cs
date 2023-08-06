﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YEGNA_BETS.Data;

#nullable disable

namespace YEGNA_BETS.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230529041251_Added UpComingMatches Table")]
    partial class AddedUpComingMatchesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Access")
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AvailableBets")
                        .HasColumnType("int");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Bet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BetterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<int?>("IsChecked")
                        .HasColumnType("int");

                    b.Property<int>("NoMatches")
                        .HasColumnType("int");

                    b.Property<double>("TAX")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("VAT")
                        .HasColumnType("float");

                    b.Property<Guid?>("WinnerStake")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BetId");

                    b.HasIndex("BetterId");

                    b.ToTable("Bet");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EncoderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EncoderId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Interaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpOrDown")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Interaction");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Logs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Match", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BetCodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("OddForDraw")
                        .HasColumnType("float");

                    b.Property<double>("OddForTeam1")
                        .HasColumnType("float");

                    b.Property<double>("OddForTeam2")
                        .HasColumnType("float");

                    b.Property<string>("Team1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BetCodeId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncoderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EncoderId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EncoderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EncoderId");

                    b.ToTable("Package");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Pattern", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FullName")
                        .HasColumnType("datetime2");

                    b.Property<int>("NoMatches")
                        .HasColumnType("int");

                    b.Property<string>("Patterns")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("successCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pattern");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Possibility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MatchCodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Outcome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MatchCodeId");

                    b.ToTable("Possibility");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Stake", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Luck")
                        .HasColumnType("float");

                    b.Property<string>("Pattern")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PayOut")
                        .HasColumnType("float");

                    b.Property<double>("Probability")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalOdds")
                        .HasColumnType("float");

                    b.Property<Guid>("WagerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WagerId");

                    b.ToTable("Stake");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EncoderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IsUsed")
                        .HasColumnType("int");

                    b.Property<Guid>("PackageTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TicketCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EncoderId");

                    b.HasIndex("PackageTypeId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentCodeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentCodeId");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.UpComingMatch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AwayTeam")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EncoderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("HomeTeam")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EncoderId");

                    b.ToTable("UpComingMatch");
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
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", null)
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

                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Bet", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.Bet", null)
                        .WithMany("Bets")
                        .HasForeignKey("BetId");

                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Better")
                        .WithMany()
                        .HasForeignKey("BetterId");

                    b.Navigation("Better");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Club", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Encoder")
                        .WithMany()
                        .HasForeignKey("EncoderId");

                    b.Navigation("Encoder");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Interaction", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.News", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Logs", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Match", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.Bet", "BetCode")
                        .WithMany()
                        .HasForeignKey("BetCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BetCode");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.News", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Encoder")
                        .WithMany()
                        .HasForeignKey("EncoderId");

                    b.Navigation("Encoder");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Package", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Encoder")
                        .WithMany()
                        .HasForeignKey("EncoderId");

                    b.Navigation("Encoder");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Possibility", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.Match", "MatchCode")
                        .WithMany()
                        .HasForeignKey("MatchCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MatchCode");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Stake", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.Possibility", "Wager")
                        .WithMany()
                        .HasForeignKey("WagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wager");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Ticket", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Encoder")
                        .WithMany()
                        .HasForeignKey("EncoderId");

                    b.HasOne("YEGNA_BETS.Models.Domain.Package", "PackageType")
                        .WithMany()
                        .HasForeignKey("PackageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Encoder");

                    b.Navigation("PackageType");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Transaction", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.Payment", "PaymentCode")
                        .WithMany()
                        .HasForeignKey("PaymentCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("PaymentCode");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.UpComingMatch", b =>
                {
                    b.HasOne("YEGNA_BETS.Models.Domain.ApplicationUser", "Encoder")
                        .WithMany()
                        .HasForeignKey("EncoderId");

                    b.Navigation("Encoder");
                });

            modelBuilder.Entity("YEGNA_BETS.Models.Domain.Bet", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
