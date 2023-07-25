using LoanAccelerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanAccelerator.Repository.LoanDocuments
{
    public class LoanDocumentsServices : ILoanDocuments
    {

        private readonly DbloanAcceleratorContext _context;

        public LoanDocumentsServices(DbloanAcceleratorContext context)
        {
            _context = context;
        }

        public async Task<List<LoanDocumentsTable>> GetLoanDocumentsTables()
        {
            var obj = await _context.LoanDocumentsTables.ToListAsync();
            if (obj == null)
            {
                throw new Exception( "No data");
            }
            return obj;
        }

        public async Task<List<LoanDocumentsTable>> GetLoanDocumentsTable(int id)
        {
            var obj = await _context.LoanDocumentsTables.Where(x=> x.LoanId == id).ToListAsync();
            if (obj == null)
            {
                throw new Exception("No data");
            }
            return obj;
        }

        public async Task<List<LoanDocumentsTable>> PutLoanDocumentsTable(int id, LoanDocumentsTable loanDocumentsTable)
        {
            var obj = await _context.LoanDocumentsTables.FirstOrDefaultAsync(x => x.LoanId == id);
            if (obj == null)
            {
                throw new Exception("No data");
            }
            obj.SignaturePhoto = loanDocumentsTable.SignaturePhoto;
            obj.PassportSizePhoto = loanDocumentsTable.PassportSizePhoto;
            obj.IdProof = loanDocumentsTable.IdProof;
            return await _context.LoanDocumentsTables.Where(x => x.LoanId == id).ToListAsync();
        }

        public async Task<List<LoanDocumentsTable>> PostLoanDocumentsTable(LoanDocumentsTable loanDocumentsTable)
        {
            await _context.LoanDocumentsTables.AddAsync(loanDocumentsTable);
            await _context.SaveChangesAsync();
            return await _context.LoanDocumentsTables.Where(x=>x.LoanId == loanDocumentsTable.LoanId).ToListAsync();
        }

        public async Task<List<LoanDocumentsTable>> DeleteLoanDocumentsTable(int id)
        {
            var obj = await _context.LoanDocumentsTables.FirstOrDefaultAsync(x => x.LoanId == id);
            if (obj == null)
            {
                throw new Exception("No data");
            }
            _context.LoanDocumentsTables.Remove(obj);
            await _context.SaveChangesAsync();
            return await _context.LoanDocumentsTables.ToListAsync();
        }

    }
}
