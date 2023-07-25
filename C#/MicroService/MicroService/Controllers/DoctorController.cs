using Microsoft.AspNetCore.Mvc;

namespace DoctorManagement.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
