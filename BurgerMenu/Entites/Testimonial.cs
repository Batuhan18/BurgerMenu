﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class Testimonial
    {
        public int TestimonialId {  get; set; }
        public string CustomerName {  get; set; }
        public string Comment {  get; set; }
        public string ImageUrl {  get; set; }
        public bool Status {  get; set; }

    }
}