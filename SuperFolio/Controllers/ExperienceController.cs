using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyimler";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler";
            var values = _experienceService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceService.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var result = _experienceService.TGetByID(id);
            _experienceService.TDelete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim GÜncelleme";
            var values = _experienceService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            _experienceService.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
