using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}