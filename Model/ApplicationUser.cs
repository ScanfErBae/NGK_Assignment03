using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NGK_Assignment_3.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
