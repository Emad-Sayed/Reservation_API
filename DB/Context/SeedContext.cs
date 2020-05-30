using _DB.Model.Branch;
using _DB.Model.CONFIGURATION;
using _DB.Model.Ticket;
using DB.Model.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _DB.Context
{
    public static class SeedContext
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Configuration>().HasData(
            new Configuration
            {
                Id = 1,
                Start_Reserving_Time = TimeSpan.Parse("7:30"),
                End_Reserving_Time = TimeSpan.Parse("18:30")
            });
            builder.Entity<Branch>().HasData(
                new Branch
                {
                    Id = 1,
                    Branch_Name_En = "Cairo",
                    Branch_Name_Ar = "القاهرة",
                    Branch_Address = "108 St Number 4",
                    Branch_Phone = "101051453123"
                },
                new Branch
                {
                    Id = 2,
                    Branch_Name_En = "Giza",
                    Branch_Name_Ar = "الجيزة",
                    Branch_Address = "445 St Number 8",
                    Branch_Phone = "112323123"
                });
            builder.Entity<Departement>().HasData(
                new Departement { Id = 1, Departement_Name_En = "ACCOUNTING", Departement_Name_Ar = "محاسبة" },
                new Departement { Id = 2, Departement_Name_En = "COMPLAIGN", Departement_Name_Ar = "شكوى" },
                new Departement { Id = 3, Departement_Name_En = "REQUIREMENT", Departement_Name_Ar = "استفسار" });
            builder.Entity<BranchDepartement>().HasData(
            new BranchDepartement { Id = 1, Branch_Id = 1, Departement_Id = 1 },
            new BranchDepartement { Id = 2, Branch_Id = 1, Departement_Id = 2 },
            new BranchDepartement { Id = 3, Branch_Id = 1, Departement_Id = 3 },
            new BranchDepartement { Id = 4, Branch_Id = 2, Departement_Id = 1 },
            new BranchDepartement { Id = 5, Branch_Id = 2, Departement_Id = 2 },
            new BranchDepartement { Id = 6, Branch_Id = 2, Departement_Id = 3 });
            // any guid
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string EMPLOYEE_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e577";
            const string USER_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e578";
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = ADMIN_ID;
            const string ROLE_ID2 = EMPLOYEE_ID;
            const string ROLE_ID3 = USER_ID;
            builder.Entity<AppUserRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            },
            new IdentityRole
            {
                Id = ROLE_ID2,
                Name = "employee",
                NormalizedName = "employee"
            },
            new IdentityRole
            {
                Id = ROLE_ID3,
                Name = "client",
                NormalizedName = "client"
            }
            );

            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                BRANCH_DEPARTEMENT_ID = 1,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admindemo"),
                SecurityStamp = string.Empty
            }
            , new AppUser
            {
                Id = EMPLOYEE_ID,
                BRANCH_DEPARTEMENT_ID = 2,
                UserName = "employee",
                NormalizedUserName = "employee",
                Email = "employee@employee.com",
                NormalizedEmail = "employee@employee.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "employeedemo"),
                SecurityStamp = string.Empty
            }
            , new AppUser
            {
                Id = USER_ID,
                BRANCH_DEPARTEMENT_ID = 4,
                UserName = "client",
                NormalizedUserName = "client",
                Email = "client@client.com",
                NormalizedEmail = "client@client.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "client"),
                SecurityStamp = string.Empty
            }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLE_ID2,
                UserId = EMPLOYEE_ID
            });
            builder.Entity<Ticket_State>().HasData(
                new Ticket_State { Id = 1, State_Name = "PENDING" },
                new Ticket_State { Id = 2, State_Name = "SERVING" },
                new Ticket_State { Id = 3, State_Name = "DONE" });

        }
    }
}
