using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var result = _messageService.TGetByID(id);
            _messageService.TDelete(result);
            return RedirectToAction("Index");
        }

        public IActionResult ContactDetails(int id)
        {
            var result = _messageService.TGetByID(id);
            return View(result);
        }
    }
}
