using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SuperFolio.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public Notification(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _announcementService.TGetList().Take(5).OrderByDescending(x => x.AnnouncementID);
            return View(values);
        }
    }
}
