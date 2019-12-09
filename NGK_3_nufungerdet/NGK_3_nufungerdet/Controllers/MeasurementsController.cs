using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class MeasurementsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<MeasurementHub> _MeasurementHub;

        public MeasurementsController(ApplicationDbContext context, IHubContext<MeasurementHub> measurementHub)
        {
            _MeasurementHub = measurementHub;
            _context = context;
        }
        

        // GET: api/Measurements
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Measurement>>> GetMeasurements()
        {
            return await _context.Measurements.ToListAsync();
        }

        // GET: api/Measurements/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Measurement>> GetIdSpecificMeasurement(long id)
        {
            var measurement = await _context.Measurements.FindAsync(id);

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

        // PUT: api/Measurements/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurement(long id, Measurement measurement)
        {
            if (id != measurement.MeasurementID)
            {
                return BadRequest();
            }

            _context.Entry(measurement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeasurementExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Measurements
        [HttpPost]
        public async Task<ActionResult<Measurement>> PostMeasurement(Measurement measurement)
        {
            measurement.Date = DateTime.Now;
            _context.Measurements.Add(measurement);
            //var location = await _context.Locations.Where(l => l.MeasurementLocationId == measurement.LocationId).Take(1).ToListAsync();
            //location[0].MeasurementsList.Add(measurement);
            //_context.Locations.Update(location[0]);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeasurements", new { id = measurement.MeasurementID }, measurement);
        }

        // POST: api/Measurements
        [HttpPost("{Backdate}")]
        public async Task<ActionResult<Measurement>> PostBackdatedMeasurement(Measurement measurement)
        {
            //DateTime s = DateTime.Now ;
            //s = new DateTime(2019, month, day, 2,2,2);
            //measurement.Date = s;

            _context.Measurements.Add(measurement);
            //var location = await _context.Locations.Where(l => l.MeasurementLocationId == measurement.LocationId).Take(1).ToListAsync();
            //location[0].MeasurementsList.Add(measurement);
            //_context.Locations.Update(location[0]);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeasurements", new { id = measurement.MeasurementID }, measurement);
        }

        // DELETE: api/Measurements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Measurement>> DeleteMeasurement(long id)
        {
            var measurement = await _context.Measurements.FindAsync(id);
            if (measurement == null)
            {
                return NotFound();
            }

            _context.Measurements.Remove(measurement);
            await _context.SaveChangesAsync();

            return measurement;
        }

        private bool MeasurementExists(long id)
        {
            return _context.Measurements.Any(e => e.MeasurementID == id);
        }
    }
}
