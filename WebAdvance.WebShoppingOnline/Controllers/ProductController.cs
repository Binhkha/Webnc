using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.WebShoppingOnline.Models;

namespace WebAdvance.WebShoppingOnline.Controllers
{
    public class ProductController : Controller
    {
        NorthwindCopyEntities db = new NorthwindCopyEntities();

        // GET: Product
        public ActionResult Index()
        {
            List<Product> lst = db.Products.Where(x=>x.ProductName.StartsWith("A")).ToList();

            return View(lst);
        }
    }
}