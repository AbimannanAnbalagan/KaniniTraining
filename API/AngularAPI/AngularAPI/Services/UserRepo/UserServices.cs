using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace AngularAPI.Services.UserRepo
{
    public class UserServices : IUsers
    {
        private readonly AngularApiContext _context;

        public UserServices (AngularApiContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> PostUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetUser(int id)
        {
            var det = await _context.Users.Where(h => h.UserId == id).ToListAsync();
            return det;
        }
        public async Task<IList> CheckUser(int mobilenum, string password)
        {
            var det = await _context.Users.CountAsync(x=> x.MobileNumber == mobilenum && x.Password == password);
            string[] animals = { det.ToString()};
            return animals;
        }
    }
}
