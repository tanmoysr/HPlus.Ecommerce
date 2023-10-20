using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Product"); 
            // Redirecting to index action from product controller.
            // Be careful, the Product has no s. But this file product is with s.
        }
    }
}