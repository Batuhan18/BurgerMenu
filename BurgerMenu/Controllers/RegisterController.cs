﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenu.Entites;
using BurgerMenu.Context;

namespace BurgerMenu.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}