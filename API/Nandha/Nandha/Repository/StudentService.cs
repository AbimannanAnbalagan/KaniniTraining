using Microsoft.EntityFrameworkCore;
using Nandha.Models;

namespace Nandha.Repository
{
    public class StudentService : IStudentService
    {
        private readonly SystemContext _context;

        public StudentService(SystemContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudDetail>> GetStudDetails()
        {
            var std = await _context.StudDetails.ToListAsync();
            return std;
        }

        public async Task<StudDetail> GetStudDetail(int id)
        {
            var stddetails = await _context.StudDetails.FirstOrDefaultAsync(x => x.Rno == id);
            return stddetails;
        }

        public async Task<string> PutStudDetail(int id, StudDetail studDetail)
        {
            var sd = await _context.StudDetails.FirstOrDefaultAsync(x => x.Rno == id);
            sd.Name = studDetail.Name;
            sd.PhoneNum = studDetail.PhoneNum;
            await _context.SaveChangesAsync();
            return "updated successfully";
        }
        public async Task<StudDetail> PostStudDetail(StudDetail studDetail)
        {
            await _context.AddAsync(studDetail);
            await _context.SaveChangesAsync();
            return studDetail;

        }
        public async Task<string> DeleteStudDetail(int id)
        {
            var sd = await _context.StudDetails.FirstOrDefaultAsync(x => x.Rno == id);
            _context.Remove(sd);
            await _context.SaveChangesAsync();
            return "deleted successfully";

        }
    }
}


