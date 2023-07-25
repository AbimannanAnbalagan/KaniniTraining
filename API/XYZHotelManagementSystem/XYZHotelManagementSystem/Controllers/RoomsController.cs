using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using XYZHotelManagementSystem.Models;
using XYZHotelManagementSystem.Repository.Rooms;

namespace XYZHotelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomServices _context;

        public RoomsController(IRoomServices context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize(Roles ="admin")]
        public async Task<ActionResult<List<Room>>> GetRooms()
        {

            try
            {
                return await _context.GetRooms();

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }

        }

        
        [HttpGet("{Hotelid}")]
        public async Task<ActionResult<List<Room>>> GetRoom(int Hotelid)
        {
            try
            {
                return await _context.GetRoom(Hotelid);
            }
            catch 
            {
                throw new Exception("Unable to Update");
            }
          
        }


    
        [HttpPut("{Roomid}")]
        [Authorize(Roles ="admin")]
        public async Task<ActionResult<List<Room>>> PutRoom(int Roomid, Room room)
        {
            try
            {
                return await _context.PutRoom(Roomid, room);
            }
            catch
            {
                throw new Exception("Unable to update");
            }

        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<String>> PostRoom(Room room)
        {

            try
            {
                return await _context.PostRoom(room);
            }
            catch 
            {
                return "Unable to Add Room Details";
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles ="admin")]
        public async Task<string> DeleteRoom(int id)
        {
            try
            {
                return await _context.DeleteRoom(id);
            }
            catch
            {
                return ("No matches");
            }
        }
    }
}
