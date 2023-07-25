using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Repository.OrderServices
{
    public interface IOrderServices
    {
        Task<List<Orderdetail>> GetOrderdetails();
        Task<List<Orderdetail>> GetOrderdetail(int id);

    }
}
