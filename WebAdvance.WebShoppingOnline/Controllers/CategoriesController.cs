using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.WebShoppingOnline.Models;

namespace WebAdvance.WebShoppingOnline.Controllers {
    public class CategoriesController : Controller {
        NorthwindCopyEntities db = new NorthwindCopyEntities();
        [ChildActionOnly]
        // GET: Categories
        public PartialViewResult CategoriesPartial() {
            List<Category> lst = db.Categories.ToList<Category>();
            return PartialView(lst);
        }


        public ActionResult ProductByCat(int CatId = 1) {
            Category c = db.Categories.Find(CatId);
            if (c == null) {
                Response.StatusCode = 404;
                return null;
            }
            List<Product> l = db.Products.Where(p => p.CategoryID == CatId).ToList<Product>();
            if (l.Count == 0) {
                ViewBag.Product = "Không có sản phẩm nào thuộc nhóm " + c.CategoryName;
            }
            else
                ViewBag.Product = c.CategoryName;
            return View(l);
        }

    }
}