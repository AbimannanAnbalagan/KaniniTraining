using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Threading.Tasks;

namespace ProjectAPI.Repository.CustomerServices
{
    public class CustomerServices : ICustomerServices
    {
        private FinalProjectContext _context;
        public CustomerServices(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var Allcustomers=await _context.Customers.ToListAsync();
            return Allcustomers;
        }


        public async Task<List<Customer?>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
           await _context.SaveChangesAsync();
            return await _context.Customers.ToListAsync();
            
        }

        public async Task<List<Customer?>> PutCustomer(int id, Customer customer)
        {
            var Cus=await _context.Customers.FirstOrDefaultAsync(x=>x.Cusid==id);   
            Cus.Cuspassword=customer.Cuspassword;
            _context.SaveChanges();
            return await _context.Customers.ToListAsync();
        }

        public async Task<String> DeleteCustomer(int id)
        {
            var Cus = await _context.Customers.FirstOrDefaultAsync(x => x.Cusid==id);
            _context.Remove(Cus);
            _context.SaveChanges();
            return "Deleted Successfully";
      
        }

    }
}
