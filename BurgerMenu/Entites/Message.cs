using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenu.Entites
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Title{ get; set; }
        public string SenderEMail{ get; set; }
        public string ReceiverEMail{ get; set; }
        public string Content{ get; set; }
        public DateTime SendDate{ get; set; }
        public bool IsRead{ get; set; }
    }
}