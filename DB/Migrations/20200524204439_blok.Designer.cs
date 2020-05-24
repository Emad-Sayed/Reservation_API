﻿// <auto-generated />
using System;
using DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace _DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200524204439_blok")]
    partial class blok
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB.Model.Auth.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("BRANCH_DEPARTEMENT_ID");

                    b.Property<bool>("Block");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Confirmation_Code");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BRANCH_DEPARTEMENT_ID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            AccessFailedCount = 0,
                            BRANCH_DEPARTEMENT_ID = 1,
                            Block = false,
                            ConcurrencyStamp = "448778e8-b529-487a-b7bf-a4b307e65a70",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@admin.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEGKAVlWvijPPwCGuGgZYSi7SmrzkaQDqmOz1PyUi3Z/M3MfdEVfopynINIbyN+aVMg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                            AccessFailedCount = 0,
                            BRANCH_DEPARTEMENT_ID = 2,
                            Block = false,
                            ConcurrencyStamp = "08aef4a4-13ab-42f6-ba40-f78c54139c30",
                            Email = "employee@employee.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "employee@employee.com",
                            NormalizedUserName = "employee",
                            PasswordHash = "AQAAAAEAACcQAAAAEMEN28pqGJ33T0iXbDBWNkSKauhkf5Ea8ryPuRnuMPvvZlRAC4ZpQ+a1rCiS5NbCdQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "employee"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                            AccessFailedCount = 0,
                            BRANCH_DEPARTEMENT_ID = 4,
                            Block = false,
                            ConcurrencyStamp = "7e291e82-463c-4344-8af5-3f38fd2d1612",
                            Email = "client@client.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "client@client.com",
                            NormalizedUserName = "client",
                            PasswordHash = "AQAAAAEAACcQAAAAEG5X677dp2h4m0hWptFRTvrqGl4XNo9yhcEH35jqAI10jwnijC+bM4Zq8PYCwjvq+g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "client"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575"
                        },
                        new
                        {
                            UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                            RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e577"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("_DB.Model.Branch.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch_Address");

                    b.Property<string>("Branch_Name");

                    b.Property<string>("Branch_Phone");

                    b.Property<DateTime>("Created_Date");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Branch_Address = "108 St Number 4",
                            Branch_Name = "Cairo",
                            Branch_Phone = "101051453123",
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(1123),
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 2,
                            Branch_Address = "445 St Number 8",
                            Branch_Name = "Gia",
                            Branch_Phone = "112323123",
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(3142),
                            Is_Deleted = false
                        });
                });

            modelBuilder.Entity("_DB.Model.Branch.BranchDepartement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Branch_Id");

                    b.Property<DateTime>("Created_Date");

                    b.Property<int>("Departement_Id");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.HasKey("Id");

                    b.HasIndex("Branch_Id");

                    b.HasIndex("Departement_Id");

                    b.ToTable("Branch_Departements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Branch_Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(6268),
                            Departement_Id = 1,
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 2,
                            Branch_Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7622),
                            Departement_Id = 2,
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 3,
                            Branch_Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7635),
                            Departement_Id = 3,
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 4,
                            Branch_Id = 2,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7637),
                            Departement_Id = 1,
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 5,
                            Branch_Id = 2,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7639),
                            Departement_Id = 2,
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 6,
                            Branch_Id = 2,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(7640),
                            Departement_Id = 3,
                            Is_Deleted = false
                        });
                });

            modelBuilder.Entity("_DB.Model.Branch.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date");

                    b.Property<string>("Departement_Name");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.HasKey("Id");

                    b.ToTable("Departements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(4402),
                            Departement_Name = "ACCOUNTING",
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(5031),
                            Departement_Name = "COMPLAIGN",
                            Is_Deleted = false
                        },
                        new
                        {
                            Id = 3,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 184, DateTimeKind.Local).AddTicks(5040),
                            Departement_Name = "REQUIREMENT",
                            Is_Deleted = false
                        });
                });

            modelBuilder.Entity("_DB.Model.CONFIGURATION.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date");

                    b.Property<TimeSpan>("End_Reserving_Time");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.Property<TimeSpan>("Start_Reserving_Time");

                    b.HasKey("Id");

                    b.ToTable("Configuration");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 181, DateTimeKind.Local).AddTicks(8743),
                            End_Reserving_Time = new TimeSpan(0, 18, 30, 0, 0),
                            Is_Deleted = false,
                            Start_Reserving_Time = new TimeSpan(0, 7, 30, 0, 0)
                        });
                });

            modelBuilder.Entity("_DB.Model.Ticket.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Branch_Departement_Id");

                    b.Property<string>("Client_Id");

                    b.Property<DateTime>("Created_Date");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.Property<int>("State_Id");

                    b.Property<int>("Ticket_Number");

                    b.HasKey("Id");

                    b.HasIndex("Branch_Departement_Id");

                    b.HasIndex("Client_Id");

                    b.HasIndex("State_Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("_DB.Model.Ticket.Ticket_Reserve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date");

                    b.Property<string>("Employee_Id");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.Property<int>("Ticket_Id");

                    b.HasKey("Id");

                    b.HasIndex("Employee_Id");

                    b.HasIndex("Ticket_Id");

                    b.ToTable("Ticket_Reserves");
                });

            modelBuilder.Entity("_DB.Model.Ticket.Ticket_State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_Date");

                    b.Property<bool>("Is_Deleted");

                    b.Property<DateTime?>("Last_Update");

                    b.Property<string>("State_Name");

                    b.HasKey("Id");

                    b.ToTable("Ticket_States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(5148),
                            Is_Deleted = false,
                            State_Name = "PENDING"
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(6303),
                            Is_Deleted = false,
                            State_Name = "SERVING"
                        },
                        new
                        {
                            Id = 3,
                            Created_Date = new DateTime(2020, 5, 24, 22, 44, 39, 226, DateTimeKind.Local).AddTicks(6315),
                            Is_Deleted = false,
                            State_Name = "DONE"
                        });
                });

            modelBuilder.Entity("DB.Model.Auth.AppUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("AppUserRole");

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            ConcurrencyStamp = "6f7fca15-4841-4171-922b-f79defcea979",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e577",
                            ConcurrencyStamp = "12cb932b-2e28-42a8-8348-f57b45b2d751",
                            Name = "employee",
                            NormalizedName = "employee"
                        },
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e578",
                            ConcurrencyStamp = "851ada55-d6ec-4d4b-8bb1-f19b53463774",
                            Name = "client",
                            NormalizedName = "client"
                        });
                });

            modelBuilder.Entity("DB.Model.Auth.AppUser", b =>
                {
                    b.HasOne("_DB.Model.Branch.BranchDepartement", "BRANCH_DEPARTEMENT")
                        .WithMany()
                        .HasForeignKey("BRANCH_DEPARTEMENT_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DB.Model.Auth.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DB.Model.Auth.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DB.Model.Auth.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DB.Model.Auth.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_DB.Model.Branch.BranchDepartement", b =>
                {
                    b.HasOne("_DB.Model.Branch.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("Branch_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_DB.Model.Branch.Departement", "Departement")
                        .WithMany()
                        .HasForeignKey("Departement_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_DB.Model.Ticket.Ticket", b =>
                {
                    b.HasOne("_DB.Model.Branch.BranchDepartement", "Branch_Departement")
                        .WithMany()
                        .HasForeignKey("Branch_Departement_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DB.Model.Auth.AppUser", "Client")
                        .WithMany()
                        .HasForeignKey("Client_Id");

                    b.HasOne("_DB.Model.Ticket.Ticket_State", "State")
                        .WithMany()
                        .HasForeignKey("State_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("_DB.Model.Ticket.Ticket_Reserve", b =>
                {
                    b.HasOne("DB.Model.Auth.AppUser", "Employee")
                        .WithMany()
                        .HasForeignKey("Employee_Id");

                    b.HasOne("_DB.Model.Ticket.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("Ticket_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
