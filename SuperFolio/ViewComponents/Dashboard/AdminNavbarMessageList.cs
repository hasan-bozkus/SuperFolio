using BusinnesLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        private readonly IWriterMessageService _writerMessageService;
        private readonly UserManager<WriterUser> _userManager;

        public AdminNavbarMessageList(IWriterMessageService writerMessageService, UserManager<WriterUser> userManager)
        {
            _writerMessageService = writerMessageService;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            string mail;
            mail = "admin@gmail.com";

            Context c = new Context();

            var sender = c.WriterMessages.Where(x => x.Receiver == mail).Select(z => z.Sender).FirstOrDefault();

            var senderImage = c.Users.Where(x => x.Email == sender).Select(z => z.ImageUrl).FirstOrDefault();

            ViewBag.senderImage = senderImage;

            var values = _writerMessageService.TGetListReeiverMessage(mail).OrderByDescending(x => x.WriterMessageID).Take(5);
            return View(values);
        }
    }
}
