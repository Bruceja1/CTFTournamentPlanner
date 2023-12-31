﻿// <auto-generated />
using System;
using CTFTournamentPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CTFTournamentPlanner.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231016130233_UserSeeding3")]
    partial class UserSeeding3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BracketTeam", b =>
                {
                    b.Property<int>("BracketsId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("BracketsId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("BracketTeam");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Bracket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGenerated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brackets");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Matchup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("RoundId")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreA")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int?>("ScoreB")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.ToTable("Matchups");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Player", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTeamLeader")
                        .HasColumnType("bit");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

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

                    b.HasIndex("TeamId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96d7a7a9-4514-4d3b-a7f1-e6ff07315804",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEOIb3H1UBdUWQOQkCz6q+KDy4O9o0j8yPz2KWGYdyrk7pCD1lDoqnEkVrZ2M2JYfgg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29c5b718-a749-4f80-a8b6-1718cf7e841f",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "b69991be-85c6-4c5a-a451-27238d2136dd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2626ea2-2d02-4945-9e0f-a19c919cdc1f",
                            Email = "bruce@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEEIILSSNoyrz7KTF3IgGpmSXHThU03Wqx9wDyKiJC/APh59hf7fm56zblYkDDtYWjw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b031b0d9-52b0-45ce-9ad0-7eae551f9ebf",
                            TeamId = 1,
                            TwoFactorEnabled = false,
                            UserName = "Bruce"
                        },
                        new
                        {
                            Id = "a247298c-9361-43ae-9c41-f978ad61b9f8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c54de00f-5ede-4d20-b91b-74a84b7743ee",
                            Email = "bruce2@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKGuGeZ6PNl6rAZOJSEOWO+eboiMxcMKX3eFynU1Pv1G+F87ZQthMKbx19HB9LA2cA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2850062-93ce-446a-b932-dfc3a4c29202",
                            TeamId = 1,
                            TwoFactorEnabled = false,
                            UserName = "Bruce2"
                        },
                        new
                        {
                            Id = "7ad91e70-ace2-4941-bd40-dc22081d0b0b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bb9644a2-a440-427e-86ab-45815fb5bb4b",
                            Email = "octane@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = true,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEA/WdNgWZh4ujNZYyky2iJq8Gq/boSCsjj0DewGKVg6ZPvnIz2oQIxu5zAxC2VNiWQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "157046a0-e030-498a-b95a-5038192f30bf",
                            TeamId = 2,
                            TwoFactorEnabled = false,
                            UserName = "Octane"
                        },
                        new
                        {
                            Id = "23ac7e40-815c-4e13-be35-d86aa12b6885",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "666a5d74-bedc-40c6-9eda-a8f16c8d3789",
                            Email = "breakout@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEM2k7+dk/p0PDjvJVTXI+McaLiJ4jK6G7C+U8X+yvyacUfYChCr1we+XnAo3tU6oJQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e19cd1d8-ce2b-4374-8197-31fda8bcb68b",
                            TeamId = 2,
                            TwoFactorEnabled = false,
                            UserName = "Breakout"
                        },
                        new
                        {
                            Id = "1fd80bdd-8ffc-42ec-8d88-5bb2fb5ef599",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "103ea004-df86-4a97-892e-50ef8f323349",
                            Email = "dominus@example.com",
                            EmailConfirmed = false,
                            IsTeamLeader = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEFfO+smMkOLeBb6jXaYLxicv0XOkkVMlr9tpPI3S3+3HcrJWwXF69XViiiovzIRrtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d35ed7d-86b3-464c-9f7e-b252d98eaaac",
                            TeamId = 2,
                            TwoFactorEnabled = false,
                            UserName = "Dominus"
                        });
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BracketId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BracketId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Het beste team.",
                            Name = "Fireboss"
                        },
                        new
                        {
                            Id = 2,
                            Description = "glhf",
                            Name = "Flip Reset"
                        });
                });

            modelBuilder.Entity("MatchupTeam", b =>
                {
                    b.Property<int>("MatchupsId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("MatchupsId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("MatchupTeam");
                });

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

                    b.HasData(
                        new
                        {
                            Id = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5",
                            Name = "Administrators",
                            NormalizedName = "ADMINISTRATORS"
                        });
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "372725a0-0897-4dd1-a77a-0f9cce9ca7ad",
                            RoleId = "e0f4adb4-8c3d-45ff-a814-62c3c873fba5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BracketTeam", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Bracket", null)
                        .WithMany()
                        .HasForeignKey("BracketsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFTournamentPlanner.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Matchup", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Round", null)
                        .WithMany("Matchups")
                        .HasForeignKey("RoundId");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Player", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Round", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Bracket", null)
                        .WithMany("Rounds")
                        .HasForeignKey("BracketId");
                });

            modelBuilder.Entity("MatchupTeam", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Matchup", null)
                        .WithMany()
                        .HasForeignKey("MatchupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFTournamentPlanner.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
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
                    b.HasOne("CTFTournamentPlanner.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Player", null)
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

                    b.HasOne("CTFTournamentPlanner.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CTFTournamentPlanner.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Bracket", b =>
                {
                    b.Navigation("Rounds");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Round", b =>
                {
                    b.Navigation("Matchups");
                });

            modelBuilder.Entity("CTFTournamentPlanner.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
