using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Formats.Asn1;

namespace ProjectAPI.Repository.ProductServcies
{
    public class ProductServices : IProductServices
    {
        private readonly FinalProjectContext _context;
        public ProductServices(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Productdetail>> GetProductdetails()
        {
            var Products=await _context.Productdetails.ToListAsync();
            return Products;
        }

        public async Task<List<Productdetail>> PutProductdetail(int id, Productdetail productdetail)
        {
            var Products=await _context.Productdetails.FirstOrDefaultAsync(x=>x.Productid==id);
            Products.Costperquantity = productdetail.Costperquantity;
            Products.Producttype = productdetail.Producttype;
            Products.Productname = productdetail.Productname;
            
            _context.SaveChanges();
            return await _context.Productdetails.ToListAsync();

           
        }

        public async Task<List<Productdetail>> PostProductdetail(Productdetail productdetail)
        {
            _context.Productdetails.Add(productdetail);
            _context.SaveChanges();
            return await _context.Productdetails.ToListAsync();
        }

        public async Task<String> DeleteProductdetail(int id)
        {
            var Products = await _context.Productdetails.FirstOrDefaultAsync(x=>x.Productid==id);
            _context.Remove(Products);
            _context.SaveChanges();
            return "Deleted Successfully";

        }
    }
}
