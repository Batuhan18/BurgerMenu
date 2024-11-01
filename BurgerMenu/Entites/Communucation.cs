using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class Communucation
    {
        [Key]
        public int CommunucationId { get; set; }
        public string Address  { get; set; }
        public string Phone  { get; set; }
        public string Email  { get; set; }
        public DateTime Date{ get; set; }
        public string SenderEmail{ get; set; }
        public bool IsRead{ get; set; }

    }
}