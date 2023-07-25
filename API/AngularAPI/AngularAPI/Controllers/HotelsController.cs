using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AngularAPI.Models;
using AngularAPI.Services.HotelRepo;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly Ihotels _context;

        public HotelsController(Ihotels context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.GetHotels();
        }

        
        // GET: api/Hotels/5
        [HttpGet("ByLocation{location}")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelsByLocation(string location)
        {
            return await _context.GetHotelsByLocation(location);
        }

        [HttpGet("ById{id}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsById(int id)
        {
            return await _context.GetHotelsById(id);
        }

        [HttpPost]
        public async Task<List<Hotel>> PostHotel(Hotel hotel)
        {
            return await _context.PostHotel(hotel);
        }
        [HttpPut("{id}")]
        public async Task<List<Hotel>> PutHotel(int id, Hotel hotel)
        {
            return await _context.PutHotel(id, hotel);
        }

        [HttpDelete("{id}")]
        public async Task<List<Hotel>> DeleteHotel(int id)
        {
            return await _context.DeleteHotel(id);
        }



            /*
            // PUT: api/Hotels/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            
                if (id != hotel.HotelId)
                {
                    return BadRequest();
                }

                _context.Entry(hotel).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(id))
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

            // POST: api/Hotels
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

              if (_context.Hotels == null)
              {
                  return Problem("Entity set 'AngularApiContext.Hotels'  is null.");
              }
                _context.Hotels.Add(hotel);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetHotel", new { id = hotel.HotelId }, hotel);
            }

            // DELETE: api/Hotels/5
            
                if (_context.Hotels == null)
                {
                    return NotFound();
                }
                var hotel = await _context.Hotels.FindAsync(id);
                if (hotel == null)
                {
                    return NotFound();
                }

                _context.Hotels.Remove(hotel);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool HotelExists(int id)
            {
                return (_context.Hotels?.Any(e => e.HotelId == id)).GetValueOrDefault();
            }
            */
        }
}
