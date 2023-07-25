using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using ProjectAPI.Repository.OrderServices;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderdetailsController : ControllerBase
    {
        private readonly IOrderServices _context;

        public OrderdetailsController(IOrderServices context)
        {
            _context = context;
        }

        // GET: api/Orderdetails
        [HttpGet]
        public async Task<ActionResult<List<Orderdetail>>> GetOrderdetails()
        {
            return await _context.GetOrderdetails();
          
        }

        // GET: api/Orderdetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Orderdetail>>> GetOrderdetail(int id)
        {
            return await _context.GetOrderdetail(id);
        }

        /*  // PUT: api/Orderdetails/5
          // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
          [HttpPut("{id}")]
          public async Task<IActionResult> PutOrderdetail(int id, Orderdetail orderdetail)
          {
              if (id != orderdetail.Orderid)
              {
                  return BadRequest();
              }

              _context.Entry(orderdetail).State = EntityState.Modified;

              try
              {
                  await _context.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (!OrderdetailExists(id))
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

          // POST: api/Orderdetails
          // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
          [HttpPost]
          public async Task<ActionResult<Orderdetail>> PostOrderdetail(Orderdetail orderdetail)
          {
              if (_context.Orderdetails == null)
              {
                  return Problem("Entity set 'FinalProjectContext.Orderdetails'  is null.");
              }
              _context.Orderdetails.Add(orderdetail);
              await _context.SaveChangesAsync();

              return CreatedAtAction("GetOrderdetail", new { id = orderdetail.Orderid }, orderdetail);
          }

          // DELETE: api/Orderdetails/5
          [HttpDelete("{id}")]
          public async Task<IActionResult> DeleteOrderdetail(int id)
          {
              if (_context.Orderdetails == null)
              {
                  return NotFound();
              }
              var orderdetail = await _context.Orderdetails.FindAsync(id);
              if (orderdetail == null)
              {
                  return NotFound();
              }

              _context.Orderdetails.Remove(orderdetail);
              await _context.SaveChangesAsync();

              return NoContent();
          }

          private bool OrderdetailExists(int id)
          {
              return (_context.Orderdetails?.Any(e => e.Orderid == id)).GetValueOrDefault();
          }*/
    }
}
