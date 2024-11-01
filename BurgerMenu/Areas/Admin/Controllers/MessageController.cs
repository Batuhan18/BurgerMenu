using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenu.Context;
using BurgerMenu.Entites;

namespace BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        // GET: Admin/Message
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Inbox()
        {
            var userName = Session["x"];
            var email=context.Admins.Where(x=>x.Username==userName).Select(y=> y.Email).FirstOrDefault();
            var values=context.Messages.Where(x=>x.ReceiverEMail==email).ToList();
            return View(values);
        }

        public ActionResult SendBox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderEMail == email).ToList();
            return View(values);
        }

        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            message.SenderEMail = email;
            message.IsRead = false;
            message.SendDate=DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("SendBox","Message",new {area="Admin"});
        }

        public PartialViewResult MessageDetail(int id)
        {
            var messages = context.Messages.Find(id);
            return PartialView(messages);
        }
    }
}