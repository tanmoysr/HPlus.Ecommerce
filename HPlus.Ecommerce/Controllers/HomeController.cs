using HPlus.Ecommerce.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    [CrawlerFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // throw new System.Exception();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Curious about the Demo Project? For more information please feel free to contact me.";

            return View();
        }

        /*  public ActionResult Contact()
          {
              ViewBag.Message = "Contact";

              return View();
          }*/
    }
}