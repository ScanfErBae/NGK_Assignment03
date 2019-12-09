using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using NGK_3_nufungerdet.Data;
using NGK_3_nufungerdet.hub;
using NGK_3_nufungerdet.Models;

namespace NGK_3_nufungerdet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MeasurementsDateRangeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<MeasurementHub> _MeasurementHub;

        public MeasurementsDateRangeController(ApplicationDbContext context, IHubContext<MeasurementHub> measurementHub)
        {
            _MeasurementHub = measurementHub;
            _context = context;
        }


     [HttpGet("{DateRange}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Measurement>>> GetDateRangeMeasurement(int day1, int month1, int year1, int day2, int month2, int year2)
        {
            DateTime obj1 = new DateTime(year1, month1, day1);
            DateTime obj2 = new DateTime(year2, month2, day2);

            var measurement = await _context.Measurements.Where(m => m.Date >= obj1 && m.Date <= obj2).ToListAsync();

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

    }
}