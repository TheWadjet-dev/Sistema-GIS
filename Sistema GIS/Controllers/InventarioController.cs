using Microsoft.AspNetCore.Mvc;

namespace Sistema_GIS.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
