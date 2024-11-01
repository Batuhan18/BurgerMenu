using BurgerMenu.Context;
using BurgerMenu.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class CreditCardController : Controller
    {
        // GET: Admin/CreditCard
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult CreditCard()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreditCard(CreditCard cc)
        {
            context.CreditCards.Add(cc);
            context.SaveChanges();
            return RedirectToAction("Admin", "Product","ProductList");
        }
    }
}