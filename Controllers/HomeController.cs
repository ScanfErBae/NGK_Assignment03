﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NGK_Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        [Route("api/[controller]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}


