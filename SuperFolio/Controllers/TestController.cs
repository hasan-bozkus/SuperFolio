using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
