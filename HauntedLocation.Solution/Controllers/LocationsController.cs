using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HauntedLocation.Models;

namespace HauntedLocation.Controllers.v1
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
        {
            private readonly HauntedLocationContext _db;

            public LocationsController(HauntedLocationContext db)
            {
                _db = db;
            }

        [HttpGet("Version")]
        public IActionResult GetVersion()
        {
            return new OkObjectResult("v1 controller");
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<Location>>> Get()
        {
            return await _db.Locations.ToListAsync();
        }

        //GET api/destinations
        [HttpGet("Query")]
            public async Task<List<Location>> Get(string name, string keyword, string city, string address, string description, string link)
            {
                IQueryable<Location> query = _db.Locations.AsQueryable();

                if (name != null)
                {
                    query = query.Where(entry => entry.Name == name);
                }

                if (keyword != null)
                {
                    query = query.Where(entry => entry.Keyword == keyword);
                }

                if (city != null)
                {
                    query = query.Where(entry => entry.City == city);
                }

                return await query.ToListAsync();
            }

            //POST api/destinations
            [HttpPost]
            public async Task<ActionResult<Location>> Post(Location location)
            {
                _db.Locations.Add(location);
                await _db.SaveChangesAsync();

                return CreatedAtAction(nameof(GetLocation), new { id = location.LocationId }, location);
            }
            // GET: api/Destinations/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Location>> GetLocation(int id)
            {
                var location = await _db.Locations.FindAsync(id);

                if (location == null)
                {
                    return NotFound();
                }

                return location;
            }
            // PUT: api/Destinations/5
            [HttpPut("{id}")]
            public async Task<IActionResult> Put(int id, Location location)
            {
                if (id != location.LocationId)
                {
                    return BadRequest();
                }

                _db.Entry(location).State = EntityState.Modified;

                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationExists(id))
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
            private bool LocationExists(int id)
            {
                return _db.Locations.Any(e => e.LocationId == id);
            }
            // DELETE: api/Destinations/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteLocation(int id)
            {
                var location = await _db.Locations.FindAsync(id);
                if (location == null)
                {
                    return NotFound();
                }

                _db.Locations.Remove(location);
                await _db.SaveChangesAsync();

                return NoContent();
            }
        }
}
