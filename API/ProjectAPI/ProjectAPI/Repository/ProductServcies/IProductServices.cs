using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Repository.ProductServcies
{
    public interface IProductServices
    {
        /*  Task<List<Productdetail>> GetProductdetails();*/

        Task<List<Productdetail>> GetProductdetails();
        Task<List<Productdetail>> PutProductdetail(int id, Productdetail productdetail);

        Task<List<Productdetail>> PostProductdetail(Productdetail productdetail);
        Task<String> DeleteProductdetail(int id);
    }
}
