using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NGK_3_nufungerdet.Models;

namespace NGK_3_nufungerdet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
