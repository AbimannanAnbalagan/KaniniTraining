using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAPI.Services.FeedbackRepo
{
    public class UserFeedbackServices : IUserFeedback
    {
        private readonly AngularApiContext _context;

        public UserFeedbackServices(AngularApiContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<UserFeedback>>> GetUserFeedbacks()
        {
            return await _context.UserFeedbacks.ToListAsync();
        }

        public async Task<string> PostUserFeedback(UserFeedback userFeedback)
        {
            await _context.UserFeedbacks.AddAsync(userFeedback);
            await _context.SaveChangesAsync();
            return "New User Added Successfully";
        }

    }
}
