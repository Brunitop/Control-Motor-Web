using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMotor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Por defecto, muestra el GIF de detenido
            ViewBag.GifPath = "/images/detenido.gif";
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
