using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Repository.CustomerServices
{
    public interface ICustomerServices
    {
        /* public Task<IEnumerable<Customer> GetCustomers();*/
        Task<List<Customer>> GetCustomers();
        Task<List<Customer?>> PostCustomer(Customer customer);
        Task<List<Customer?>> PutCustomer(int id, Customer customer);

        Task<String> DeleteCustomer(int id);
    }
}
