using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class AdminNotficationNavbarList : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public AdminNotficationNavbarList(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
