using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMotor.Controllers
{
    public class MotorController : Controller
    {
        public IActionResult Index()
        {
            // Por defecto, muestra el GIF de detenido
            return View("~/Views/Home/Index.cshtml", "/images/detenido.gif");
        }

        [HttpPost]
        public IActionResult ControlMotor(string action)
        {
            string gifPath = "";

            // Determina qué GIF cargar en función del botón presionado
            switch (action)
            {
                case "left":
                    gifPath = "/images/izquierda.gif";
                    break;
                case "pause":
                    gifPath = "/images/detenido.gif";
                    break;
                case "right":
                    gifPath = "/images/derecha.gif";
                    break;
                default:
                    // Por defecto, carga el GIF de detenido
                    gifPath = "/images/detenido.gif";
                    break;
            }

            return View("~/Views/Home/Index.cshtml", gifPath);
        }
    }
}