using Nandha.Models;

namespace Nandha.Repository
{
    public interface IStudentService
    {
        Task<IEnumerable<StudDetail>> GetStudDetails();
        Task<StudDetail> GetStudDetail(int id);
        Task<string> PutStudDetail(int id, StudDetail studDetail);
        Task<StudDetail> PostStudDetail(StudDetail studDetail);
        Task<string> DeleteStudDetail(int id);
    }
        
}
