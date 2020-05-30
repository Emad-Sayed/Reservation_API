using _DB.Context;
using _DB.Model;
using _DB.Model.Branch;
using _DB.Model.CONFIGURATION;
using _DB.Model.Ticket;
using _DB.Model.Views.Users;
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
            builder.Seed();

            //VIEWS MAPPING
            builder.Query<VwUser>().ToView("VwUsers");
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<BranchDepartement> Branch_Departements { get; set; }
        public DbSet<Configuration> Configuration { get; set; }
        public DbSet<Ticket_State> Ticket_States { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Ticket_Reserve> Ticket_Reserves { get; set; }



        public DbQuery<VwUser> VwUsers { get; set; }
    }
}
