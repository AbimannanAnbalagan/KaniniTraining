using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using ProjectAPI.Repository.ProductServcies;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductdetailsController : ControllerBase
    {
        private readonly IProductServices _context;

        public ProductdetailsController(IProductServices context)
        {
            _context = context;
        }

        // GET: api/Productdetails
        [HttpGet]
        public async Task<ActionResult<List<Productdetail>>> GetProductdetails()
        {
            return await _context.GetProductdetails();
        }

        // GET: api/Productdetails/5
      

        // PUT: api/Productdetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Productdetail>> PutProductdetail(int id, Productdetail productdetail)
        {
          return await _context.PutProductdetail(id, productdetail);
        }

        // POST: api/Productdetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Productdetail>>> PostProductdetail(Productdetail productdetail)
        {
            return await _context.PostProductdetail(productdetail);
        }

        // DELETE: api/Productdetails/5
        [HttpDelete("{id}")]
        public async Task<String> DeleteProductdetail(int id)
        {
            return await _context.DeleteProductdetail(id);
        }
/*
        private bool ProductdetailExists(int id)
        {
            return (_context.Productdetails?.Any(e => e.Productid == id)).GetValueOrDefault();
        }*/
    }
}
