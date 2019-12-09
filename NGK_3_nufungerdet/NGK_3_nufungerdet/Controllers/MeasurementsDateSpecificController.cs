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
    public class MeasurementsDateSpecificController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<MeasurementHub> _MeasurementHub;

        public MeasurementsDateSpecificController(ApplicationDbContext context, IHubContext<MeasurementHub> measurementHub)
        {
            _MeasurementHub = measurementHub;
            _context = context;
        }


        [HttpGet("{DateSpecific}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Measurement>>> GetDateSpecificMeasurement(int day, int month)
        {
            var measurement = await _context.Measurements.Where(m => m.Date.Day == day && m.Date.Month == month).ToListAsync();

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

    }
}