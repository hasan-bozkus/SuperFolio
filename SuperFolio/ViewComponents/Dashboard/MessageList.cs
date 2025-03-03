using BusinnesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        private readonly IUserMessageService _userMessageService;

        public MessageList(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _userMessageService.TGetUserMessagesWithUser();
            return View(values);
        }
    }
}
