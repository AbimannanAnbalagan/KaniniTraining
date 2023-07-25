using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Repository.OrderServices
{
    public class Orderservices : IOrderServices
    {
        private FinalProjectContext _context;
        public Orderservices(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Orderdetail>> GetOrderdetails()
        {
            var Details=await _context.Orderdetails.ToListAsync();
            return Details;
        }

        public async Task<List<Orderdetail>> GetOrderdetail(int id)
        {
            var Details = await _context.Orderdetails.ToListAsync();
            return Details;


        }
    }
}
