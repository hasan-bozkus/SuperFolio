using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        private readonly IMessageService _messageService;

        public MessageList(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _messageService.TGetList();
            return View(values);
        }
    }
}
