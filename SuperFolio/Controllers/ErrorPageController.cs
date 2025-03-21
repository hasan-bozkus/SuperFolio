using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
