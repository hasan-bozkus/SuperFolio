using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("/[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class DefaultController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public DefaultController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetList();
            return View(values);
        }

        public IActionResult AnnouncementDetails(int id)
        {
            var value = _announcementService.TGetByID(id);
            return View(value);
        }
    }
}
