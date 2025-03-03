using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
