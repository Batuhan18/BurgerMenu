﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BurgerMenu.Entites;

namespace BurgerMenu.Context
{
    public class BurgerMenuContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DealOfTheDay> DealOfTheDays { get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Communucation> Communucations { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
    
    }
}