using AngularAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularAPI.Services.FeedbackRepo
{
    public interface IUserFeedback
    {
        Task<ActionResult<IEnumerable<UserFeedback>>> GetUserFeedbacks();

        Task<string> PostUserFeedback(UserFeedback userFeedback);
    }
}
