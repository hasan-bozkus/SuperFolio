using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    //[Route("[area]/[controller]/[action]")] 
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
