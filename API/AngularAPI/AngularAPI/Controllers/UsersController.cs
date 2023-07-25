using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AngularAPI.Models;
using AngularAPI.Services.UserRepo;
using System.Security.Policy;
using System.Numerics;
using System.Collections;

namespace AngularAPI.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _context;

        public UsersController(IUsers context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet("AllUsers")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {

            return await _context.GetUsers();
        }


        // GET: api/Users/5
        [HttpGet("Byid{id}")]
        public async Task<List<User>> GetUser(int id)
        {
            return await _context.GetUser(id);
        }

        /*
        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<List<User>> PostUser(User user)
        {
            return await _context.PostUser(user);
        }

        [HttpGet("{mobilenum},{password}")]
        public async Task<IList> CheckUser(int mobilenum , string password)
        {
            return await _context.CheckUser(mobilenum,password);
        }
        /*
        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }*/
    }
}
