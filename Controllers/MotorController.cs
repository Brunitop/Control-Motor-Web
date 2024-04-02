using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMotor.Controllers
{

    public class MotorController : Controller
    {
        [HttpPost]
        public IActionResult ControlMotor(string action)
        {
            string gifPath = "/images/detenido.gif";

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

            ViewBag.GifPath = gifPath;
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
