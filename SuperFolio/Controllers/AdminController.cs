using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavigation()
        {
            return PartialView();
        }

        public PartialViewResult NewSidebar()
        {
            return PartialView();
        }
    }
}
