using Microsoft.AspNetCore.Mvc;
using WithGPT.Models;

namespace WithGPT.Repository
{
    public interface Iproduct
    {
        Task<ActionResult<IEnumerable<Product>>> GetProducts();
        public string none();
        Task<ActionResult<Product>> GetProduct(int id);
        Task<string> PutProduct(int id, Product product);
        Task<ActionResult<Product>> PostProduct(Product product);
        //Task<IActionResult> DeleteProduct(int id);
    }
}
