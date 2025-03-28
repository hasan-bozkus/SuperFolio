﻿using BusinnesLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        private readonly IWriterMessageService _writerMessageService;

        public MessageList(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
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
