using Microsoft.AspNetCore.Mvc;

namespace AplicacionSeguros.Controllers
{
    public class SegurosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
