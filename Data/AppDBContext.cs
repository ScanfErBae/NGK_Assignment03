using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NGK_Assignment_3.Model;

namespace NGK_Assignment_3.Data
{
    public class AppDBContext : IdentityDbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) { }

        public DbSet<MeasurementLocation> Locations { get; set; } 
        public  DbSet<Measurement>  Measurements { get; set; }

       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }


}


