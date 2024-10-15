using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        public PartialViewResult PartialOffer()
        {
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public PartialViewResult PartialGaleri()
        {
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}