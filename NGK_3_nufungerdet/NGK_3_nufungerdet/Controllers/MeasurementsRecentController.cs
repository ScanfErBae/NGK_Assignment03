using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NGK_3_nufungerdet.Data;
using NGK_3_nufungerdet.Models;

namespace NGK_3_nufungerdet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MeasurementsRecentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MeasurementsRecentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{Recent}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Measurement>>> GetRecentMeasurement()
        {
            var measurement = await _context.Measurements.OrderByDescending(m => m.Date).Take(3).ToListAsync();

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

    }
}