using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Repository.HotelServices;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelServices _context;

        public HotelsController(IHotelServices context)
        {
            _context = context;
        }

        // GET: api/Hotels

        [HttpGet]
        [Authorize(Role="admin")]
        public async Task<ActionResult<List<Hotels>>> GetHotels()
        {
            
            try
            {
                return await _context.GetHotels();

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }

        }
        
        [HttpGet("ByLocation{location}")]
        public async Task<List<Bufferby>> GetHotelsLocation(string location)
        {

            
            return await _context.GetHotelsLocation(location);
        }
    
        
        [HttpGet("ByPrice")]
        public async Task<List<Bufferby>> GetHotelsPrice(float Minprice , float Maxprice)
        {
            return await _context.GetHotelsPrice(Minprice, Maxprice);
        }


        [HttpPut("{id}")]
        public async Task<List<Hotels>> PutHotels(int id, Hotels hotels)
        {
            return await _context.PutHotels(id, hotels);
        }
        

        [HttpPost]
        public async Task<ActionResult<string>> PostHotels(Hotels hotels)
        {
            var res = await _context.PostHotels(hotels);
            return Ok(res);
        }
        
       
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteHotels(int id)
        {
            var res = await _context.DeleteHotels(id);
            return Ok(res);       
        }

    }
}
