using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace AngularAPI.Services.UserRepo
{
    public interface IUsers
    {
        Task<List<User>> GetUser(int id);
        Task<List<User>> GetUsers();
        Task<List<User>> PostUser(User user);
        Task<IList> CheckUser(int mobilenum, string password);
    }
}
