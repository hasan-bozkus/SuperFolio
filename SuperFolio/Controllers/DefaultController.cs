using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SuperFolio.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;

        public DefaultController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            message.Status = true;
            _messageService.TAdd(message);
            return RedirectToAction("Index", null, "contact");
        }
    }
}
