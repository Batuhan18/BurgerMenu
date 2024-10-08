﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl{ get; set; }
    }
}