using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SuperFolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("/[area]/[controller]/[action]/{id?}")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserName = values.Name + " " + values.Surname;

            //weather api
            string api = "dd6e5716727e03344c38dfb6a2419c27";
            string connection = " http://api.openweathermap.org/data/2.5/weather?q=mardin&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.Weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            //statistics
            Context context = new Context();
            ViewBag.MessageCount = context.WriterMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.NotificationCount = context.Announcements.Count();
            ViewBag.TotalUserCount = context.Users.Count();
            ViewBag.TotalSkillCount = context.Skills.Count();

            return View();
        }
    }
}
/*
 http://api.openweathermap.org/data/2.5/weather?q=mardin&mode=xml&lang=tr&units=metric&appid=dd6e5716727e03344c38dfb6a2419c27
 */
