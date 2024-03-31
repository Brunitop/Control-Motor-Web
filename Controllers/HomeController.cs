using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMotor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}