using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {

        private readonly Context _context;

        public StatisticsDashboard2(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.portfolioCount = _context.Portfolios.Count();
            ViewBag.messageCount = _context.Messages.Count();
            ViewBag.serviceCount = _context.Services.Count();
            return View();
        }
    }
}
