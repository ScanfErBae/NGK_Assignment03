using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NGK_Assignment_3.Model
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }
        [Required]
        [PersonalData]
        public string Username { get; set; }
    }


}
