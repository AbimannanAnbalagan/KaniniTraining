using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using ProjectAPI.Repository.CustomerServices;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _context;

        public CustomersController(ICustomerServices context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            /*if (_context.GetCustomers() == null)
            {
                return NotFound();
            }*/
            return await _context.GetCustomers();
        }

        // GET: api/Customers/5


        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Customer>> PutCustomer(int id, Customer customer)
        {
            return await _context.PutCustomer(id, customer);
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Customer?>>> PostCustomer(Customer customer)
        {
           

            return await _context.PostCustomer(customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<String> DeleteCustomer(int id)
        {
            return await _context.DeleteCustomer(id);
        }
/*
        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.Cusid == id)).GetValueOrDefault();
        }*/
    }
}
