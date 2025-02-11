using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listesi";
            ViewBag.v2 = "Yetenek Listesi";
            ViewBag.v3 = "Yetenek Listesi";
            var values = _skillService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Ekleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillService.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var result = _skillService.TGetByID(id);
            _skillService.TDelete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.v1 = "Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var values = _skillService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _skillService.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
