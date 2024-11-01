using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Admin/Reservation
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Index()
        {
            var value=context.Reservations.ToList();
            return View(value);
        }
    }
}