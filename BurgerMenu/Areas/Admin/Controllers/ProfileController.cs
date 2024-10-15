using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenu.Context;
using BurgerMenu.Entites;

namespace BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult MyProfileList()
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult MyProfileList(BurgerMenu.Entites.Admin admin)
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault();
            values.Username = admin.Username;   
            values.Surname = admin.Surname;
            values.Name= admin.Name;
            values.Password = admin.Password;
            values.Email = admin.Email;
            context.SaveChanges();
            return RedirectToAction("Index", "Login");

        }
    }
}