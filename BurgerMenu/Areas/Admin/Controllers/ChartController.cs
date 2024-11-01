using BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenu.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        // GET: Admin/Chart
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult Index()
        {
            var values=context.Messages.GroupBy(x=>x.Title).Select(y=> new
            {
                Title=y.Key,
                Count=y.Count()
            }).ToList();

            ViewBag.value = values.ToDictionary(x => x.Title, y => y.Count);

			var value=context.Products.GroupBy(x=>x.ProductName).ToList();
            ViewBag.d1 = value;
            var value1 = context.Products.GroupBy(x => x.Price).Select(y => new
            {
                Price = y.Key,
                Count = y.Count()
            });
            ViewBag.d2=value1;

            var value2 = context.Messages.Sum(x => x.MessageId).ToString();
            ViewBag.d3=value2;
			return View();

            
        }
    }
}