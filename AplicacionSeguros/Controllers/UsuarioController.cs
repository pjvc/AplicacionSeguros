using Microsoft.AspNetCore.Mvc;

namespace AplicacionSeguros.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
