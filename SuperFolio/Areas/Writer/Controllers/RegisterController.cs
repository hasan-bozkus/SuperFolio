using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuperFolio.Areas.Writer.Models;
using System.Security.Policy;
using System.Threading.Tasks;

namespace SuperFolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("/[area]/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid && userRegisterViewModel.ConfirmPassword == userRegisterViewModel.Password)
            {
                WriterUser writerUser = new WriterUser()
                {
                    Name = userRegisterViewModel.Name,
                    Surname = userRegisterViewModel.Surname,
                    UserName = userRegisterViewModel.UserName,
                    Email = userRegisterViewModel.Email,
                    ImageUrl = userRegisterViewModel.ImageUrl
                };

                if (userRegisterViewModel.ConfirmPassword == userRegisterViewModel.Password)
                {

                    var result = await _userManager.CreateAsync(writerUser, userRegisterViewModel.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            return View();
        }
    }
}
