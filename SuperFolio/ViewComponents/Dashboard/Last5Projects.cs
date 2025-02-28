using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
