using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
