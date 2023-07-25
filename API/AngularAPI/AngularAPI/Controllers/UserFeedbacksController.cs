using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AngularAPI.Models;
using AngularAPI.Services.FeedbackRepo;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFeedbacksController : ControllerBase
    {
        private readonly IUserFeedback _context;

        public UserFeedbacksController(IUserFeedback context)
        {
            _context = context;
        }

        // GET: api/UserFeedbacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserFeedback>>> GetUserFeedbacks()
        {
            return await _context.GetUserFeedbacks();
        }


        [HttpPost]
        public async Task<string> PostUserFeedback(UserFeedback userFeedback)
        {
            return await _context.PostUserFeedback(userFeedback);
        }


            /*
            // GET: api/UserFeedbacks/5
            [HttpGet("{id}")]
            public async Task<ActionResult<UserFeedback>> GetUserFeedback(int id)
            {
              if (_context.UserFeedbacks == null)
              {
                  return NotFound();
              }
                var userFeedback = await _context.UserFeedbacks.FindAsync(id);

                if (userFeedback == null)
                {
                    return NotFound();
                }

                return userFeedback;
            }

            // PUT: api/UserFeedbacks/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutUserFeedback(int id, UserFeedback userFeedback)
            {
                if (id != userFeedback.FeedbackId)
                {
                    return BadRequest();
                }

                _context.Entry(userFeedback).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserFeedbackExists(id))
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

            // POST: api/UserFeedbacks
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

              if (_context.UserFeedbacks == null)
              {
                  return Problem("Entity set 'AngularApiContext.UserFeedbacks'  is null.");
              }
                _context.UserFeedbacks.Add(userFeedback);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUserFeedback", new { id = userFeedback.FeedbackId }, userFeedback);
            }

            // DELETE: api/UserFeedbacks/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteUserFeedback(int id)
            {
                if (_context.UserFeedbacks == null)
                {
                    return NotFound();
                }
                var userFeedback = await _context.UserFeedbacks.FindAsync(id);
                if (userFeedback == null)
                {
                    return NotFound();
                }

                _context.UserFeedbacks.Remove(userFeedback);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool UserFeedbackExists(int id)
            {
                return (_context.UserFeedbacks?.Any(e => e.FeedbackId == id)).GetValueOrDefault();
            }*/
        }
}
