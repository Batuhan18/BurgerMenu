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
    public class ProductController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values=(from x in context.Categories.ToList()
                                         select new SelectListItem
                                         {
                                             Text=x.CategoryName,
                                             Value=x.CategoryId.ToString()
                                         }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public ActionResult DeleteProduct(int id)
        {
            var values = context.Products.Find(id);
            context.Products.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value=context.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var values = context.Products.Find(product.ProductId);
            values.ProductName = product.ProductName;
            values.ImageUrl = product.ImageUrl;
            values.Description = product.Description;
            values.Price= product.Price;
            values.CategoryId = product.CategoryId;
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}