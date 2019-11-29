using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NGK_Assignment_3.Model;
using Microsoft.Extensions.Logging;

namespace NGK_Assignment_3.Data
{
    public class DBHelper
    {
        public static void SeedData(AppDBContext db, UserManager<ApplicationUser> userManager, ILogger log)
        {
            SeedUsers(userManager, log);
        }


        public static void SeedUsers(UserManager<ApplicationUser> userManager, ILogger log)
        {
            const string adminEmail = "Admin@localhost";
            const string adminPassword = "Jesper1";

            if (userManager.FindByNameAsync(adminEmail).Result == null)
            {
                var user = new ApplicationUser();
                user.Email = adminEmail;
                user.UserName = adminEmail;
                IdentityResult result = userManager.CreateAsync(user, adminPassword).Result;
            }
        }
    }
}

