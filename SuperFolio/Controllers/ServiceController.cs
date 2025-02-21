using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Servis Listesi";
            ViewBag.v2 = "Servis Listesi";
            ViewBag.v3 = "Servis Listesi";
            var values = _serviceService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Servis Ekleme";
            ViewBag.v2 = "Servisler";
            ViewBag.v3 = "Servis Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var result = _serviceService.TGetByID(id);
            _serviceService.TDelete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.v1 = "Güncelleme";
            ViewBag.v2 = "Servisler";
            ViewBag.v3 = "Servis Güncelleme";
            var values = _serviceService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
