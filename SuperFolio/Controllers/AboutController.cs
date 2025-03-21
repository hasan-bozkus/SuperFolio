using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutService.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
