using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        private readonly Context _context;

        public FeatureStatistics(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = _context.Skills.Count();
            ViewBag.messageUnReadCount = _context.Messages.Where(x => x.Status == false).Count();
            ViewBag.messageReadCount = _context.Messages.Where(x => x.Status == true).Count();
            ViewBag.experienceCount = _context.Experiences.Count();

            return View();
        }
    }
}
