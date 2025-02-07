using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SuperFolio.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
