﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class AboutUs
    {
        [Key]
        public int AboutId{ get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string ImageUrl{ get; set; }

        public string MapLocation{ get; set; }
    }
}