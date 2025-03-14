using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
