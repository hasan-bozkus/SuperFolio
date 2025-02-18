using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Portfölyolar";
            ViewBag.v2 = "Portfölyolar";
            ViewBag.v3 = "Portfölyolar ";
            var values = _portfolioService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Portfölyo Ekleme";
            ViewBag.v2 = "Portfölyolar";
            ViewBag.v3 = "Portfölyo Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            _portfolioService.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var result = _portfolioService.TGetByID(id);
            _portfolioService.TDelete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Güncelleme";
            ViewBag.v2 = "Portfölyolar";
            ViewBag.v3 = "Portfölyo Güncelleme";
            var values = _portfolioService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
