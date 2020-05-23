using _DB.Model.Branch;
using _DB.Model.CONFIGURATION;
using _DB.Model.Ticket;
using DB.Model.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Configuration>().HasData(
    new Configuration
    {
        Id = 1,
        START_RESERVING_TIME = TimeSpan.Parse("7:30"),
        END_RESERVING_TIME = TimeSpan.Parse("18:30")
    });
            builder.Entity<Branch>().HasData(
                new Branch
                {
                    Id = 1,
                    BRANCH_NAME = "Cairo",
                    BRANCH_ADDRESS = "108 St Number 4",
                    BRANCH_PHONE = "101051453123"
                },
                new Branch
                {
                    Id = 2,
                    BRANCH_NAME = "Gia",
                    BRANCH_ADDRESS = "445 St Number 8",
                    BRANCH_PHONE = "112323123"
                });
            builder.Entity<Departement>().HasData(
                new Departement { Id = 1, DEPARTEMENT_NAME = "ACCOUNTING" },
                new Departement { Id = 2, DEPARTEMENT_NAME = "COMPLAIGN" },
                new Departement { Id = 3, DEPARTEMENT_NAME = "REQUIREMENT" });
            builder.Entity<BranchDepartement>().HasData(
            new BranchDepartement { Id = 1, BRANCH_ID = 1, DEPARTEMENT_ID = 1 },
            new BranchDepartement { Id = 2, BRANCH_ID = 1, DEPARTEMENT_ID = 2 },
            new BranchDepartement { Id = 3, BRANCH_ID = 1, DEPARTEMENT_ID = 3 },
            new BranchDepartement { Id = 4, BRANCH_ID = 2, DEPARTEMENT_ID = 1 },
            new BranchDepartement { Id = 5, BRANCH_ID = 2, DEPARTEMENT_ID = 2 },
            new BranchDepartement { Id = 6, BRANCH_ID = 2, DEPARTEMENT_ID = 3 });
            // any guid
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = ADMIN_ID;
            builder.Entity<AppUserRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

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
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            builder.Entity<Ticket_State>().HasData(
                new Ticket_State { Id = 1, STATE_NAME = "PENDING" },
                new Ticket_State { Id = 2, STATE_NAME = "SERVING" },
                new Ticket_State { Id = 3, STATE_NAME = "DONE" });
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<BranchDepartement> Branch_Departements { get; set; }
        public DbSet<Configuration> Configuration { get; set; }
        public DbSet<Ticket_State> Ticket_States { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Ticket_Reserve> Ticket_Reserves { get; set; }
    }
}
