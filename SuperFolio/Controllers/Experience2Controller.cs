
using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SuperFolio.Controllers
{
    public class Experience2Controller : Controller
    {
        private readonly IExperienceService _experienceService;

        public Experience2Controller(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(_experienceService.TGetList());
            //var values = JsonConvert.SerializeObject(liste);
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceService.TAdd(experience);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceID)
        {
            var result = _experienceService.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(result);
            return Json(values);
        }

        public IActionResult DeleteExperience(int id)
        {
            var result = _experienceService.TGetByID(id);
            _experienceService.TDelete(result);
            return NoContent();
        }

        public IActionResult UpdateExperience(Experience experience)
        {
            _experienceService.TUpdate(experience);
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }
    }
}
