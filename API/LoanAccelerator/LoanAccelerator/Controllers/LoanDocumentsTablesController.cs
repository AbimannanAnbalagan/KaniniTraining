using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoanAccelerator.Models;
using LoanAccelerator.Repository.LoanDocuments;

namespace LoanAccelerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanDocumentsTablesController : ControllerBase
    {
        private readonly ILoanDocuments _context;

        public LoanDocumentsTablesController(ILoanDocuments context)
        {
            _context = context;
        }

        // GET: api/LoanDocumentsTables
        [HttpGet]
        public async Task<List<LoanDocumentsTable>> GetLoanDocumentsTables()
        {
            var result = await _context.GetLoanDocumentsTables();
            return result;
            /*try
            {
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }*/
        }


        [HttpGet("{id}")]
        public async Task<List<LoanDocumentsTable>> GetLoanDocumentsTable(int id)
        {
            var result = await _context.GetLoanDocumentsTable(id);
            return result;
            /*try
            {
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }*/
        }


        [HttpPut("{id}")]
        public async Task<List<LoanDocumentsTable>> PutLoanDocumentsTable(int id, LoanDocumentsTable loanDocumentsTable)
        {
            var result = await _context.PutLoanDocumentsTable(id, loanDocumentsTable);
            return result;
        }

        // POST: api/LoanDocumentsTables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<List<LoanDocumentsTable>> PostLoanDocumentsTable(LoanDocumentsTable loanDocumentsTable)
        {
            var result = await _context.PostLoanDocumentsTable(loanDocumentsTable);
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<List<LoanDocumentsTable>> DeleteLoanDocumentsTable(int id)
        {
            var result = await _context.DeleteLoanDocumentsTable(id);
            return result;
        }
    }
}
