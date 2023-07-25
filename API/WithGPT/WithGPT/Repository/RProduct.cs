using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WithGPT.Data;
using WithGPT.Models;

namespace WithGPT.Repository
{
    public class RProduct : Iproduct
    {
        private readonly AppDbContext _context;

        public RProduct(AppDbContext context)
        {
                _context = context;
        }   
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {

            if (_context.Products == null)
            {
                none();
            }
            var std = await _context.Products.ToListAsync();
            return std;
        }

        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var std = await _context.Products.FirstOrDefaultAsync(x=> x.Id == id);
            return std;
        }

        public async Task<string> PutProduct(int id, Product product)
        {
            var std = await _context.Products.FirstOrDefaultAsync(x=>x.Id == id);
            std.Id= product.Id;
            std.Name = product.Name;
            await _context.SaveChangesAsync();
            return "Updated";
        }

        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }
        /*
        public async Task<IActionResult> DeleteProduct(int id)
        {

        }
        */

        public string none()
        {
            return "Empty Table";
        }
    }
}
