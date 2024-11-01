using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using BurgerMenu.Context;
using BurgerMenu.Entites;

namespace BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {

        BurgerMenuContext context = new BurgerMenuContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Communucation com)
        {
            com.Date = DateTime.Now;
            com.IsRead = false;
            context.Communucations.Add(com);
            context.SaveChanges();
            return RedirectToAction("Index");
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
            var values = context.AboutUss.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialOffer()
        {
            var values = context.Products.Where(x => x.DealofTheDay == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView("PartialMenu",values);
        }


        public PartialViewResult PartialCategory()
        {
            var values = context.Categories.Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGaleri()
        {
            return PartialView();
        }

        public PartialViewResult PartialContactInfo()
        {
            var values = context.Communucations.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContactHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialLocation()
        {
            ViewBag.mapLocation = context.AboutUss.Select(x => x.MapLocation).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialFooter(Subscribe sub)
        {
  
            if (ModelState.IsValid)
            {
                context.Subscribes.Add(sub);
                context.SaveChanges();
                return RedirectToAction("Index","Default");
            }
            return PartialView(); 
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialReservation(Reservation reservation)
        {
            reservation.ReservationStatus = "Onay Bekleniyor";
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }


    }
}