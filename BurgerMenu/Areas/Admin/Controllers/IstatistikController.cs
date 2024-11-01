using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Admin/Istatistik
        BurgerMenuContext c=new BurgerMenuContext();
     
        public ActionResult Index()
        {
            var deger1=c.Messages.Count().ToString();
            ViewBag.d1=deger1;
            var deger2=c.Admins.Count().ToString();
            ViewBag.d2=deger2;
            var deger3=c.Categories.Count().ToString(); 
            ViewBag.d3=deger3; 
            var deger4=c.Products.Count().ToString();
            ViewBag.d4=deger4;
            var deger5=c.Reservations.Count().ToString();   
            ViewBag.d5=deger5;
            var deger6=c.Subscribes.Count().ToString();
            ViewBag.d6=deger6;
            var deger7=c.Testimonials.Count().ToString();
            ViewBag.d7=deger7;
            var deger8 = c.Messages.Count(x => x.Title == "Tebrik").ToString();
            ViewBag.d8=deger8;
            return View();
        }
    }
}