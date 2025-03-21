using BusinnesLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;

        public AdminMessageController(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }

        public IActionResult ReceiverMessageList()
        {
            string mail;
            mail = "admin@gmail.com";
            var values = _writerMessageService.TGetListReeiverMessage(mail);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string mail;
            mail = "admin@gmail.com";
            var values = _writerMessageService.TGetListSenderMessage(mail);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {
            var values = _writerMessageService.TGetByID(id);
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _writerMessageService.TGetByID(id);
            _writerMessageService.TDelete(values);
            if (values.Receiver == "admin@gmail.com")
            {
                return RedirectToAction("ReceiverMessageList");
            }
            else
            {
                return RedirectToAction("SenderMessageList");
            }
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(WriterMessage writerMessage)
        {
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = DateTime.Parse(DateTime.Now.ToString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernamesurname;
            _writerMessageService.TAdd(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}
