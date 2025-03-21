using BusinnesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperFolio.Controllers
{
    public class WriterUserController : Controller
    {
        private readonly IWriterUserService _writerUserService;

        public WriterUserController(IWriterUserService writerUserService)
        {
            _writerUserService = writerUserService;
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_writerUserService.TGetList());
            //var values = JsonConvert.SerializeObject(liste);
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            _writerUserService.TAdd(writerUser);
            var values = JsonConvert.SerializeObject(writerUser);
            return Json(values);
        }

        private static List<Class0> liste = new List<Class0>
        {
            new Class0 { ID = 1, Ad = "Ali" },
            new Class0 { ID = 2, Ad = "Ayşe" },
            new Class0 { ID = 3, Ad = "Esra" }
        };
    }
}

public class Class0
{
    public int ID { get; set; }
    public string Ad { get; set; }
}
