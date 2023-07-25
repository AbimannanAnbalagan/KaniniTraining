using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nandha.Models;
using Nandha.Repository;

namespace Nandha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudDetailsController : ControllerBase
    {
        private readonly IStudentService _context;

        public StudDetailsController(IStudentService context)
        {
            _context = context;
        }

        // GET: api/StudDetails
        [HttpGet]
        public async Task<IEnumerable<StudDetail>> GetStudDetails()
        {
            return await _context.GetStudDetails();
        }

        // GET: api/StudDetails/5
        [HttpGet("{id}")]
        public async Task<StudDetail> GetStudDetail(int id)
        {
          
            return await _context.GetStudDetail(id);
        }

        // PUT: api/StudDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<string> PutStudDetail(int id, StudDetail studDetail)
        { 
            return await _context.PutStudDetail(id,studDetail);
        }

        // POST: api/StudDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<StudDetail> PostStudDetail(StudDetail studDetail)
        {
          

            return await _context.PostStudDetail(studDetail);
        }

        // DELETE: api/StudDetails/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteStudDetail(int id)
        {
            
            return await _context.DeleteStudDetail(id);
        }

      
    }
}
