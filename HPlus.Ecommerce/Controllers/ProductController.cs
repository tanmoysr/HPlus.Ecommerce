using HPlus.Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Index");
            /*return View("Detail"); */
            /*Instead of default index cshtml which was configured in RouteConfig, it will call the Detail.cshtml*/
        }

        [Route("product/{productName}")] /**In the RouteConfig.cs used MapMvcAttributeRoutes so that, we can use routing attribute like this*/
        public ActionResult Detail( string productName)
        {
            ViewBag.Product = new Product
            {
                Name = "Women's Winter Jacket", // Normally the value is lookup in the database
                FullPrice = 20.00M,
                CurrentPrice = 16.00M,
                PercentOff = 20,
                ImagePath = "/Content/Images/Products/1.jpg",
                StarRating = 4
            };

            // lookup the product name in the databse
            return View();

        }
    }
}