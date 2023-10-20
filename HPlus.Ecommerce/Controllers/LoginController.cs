using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HPlus.Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /*[HttpPost] //this will tell asp.NET MVC 5 to route any post requests to this index route to this specific method. 
        public ActionResult Index(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                
                FormsAuthentication.SetAuthCookie(username, false); //false means it will expire when the user closes the browser
                return Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }

            ViewBag.Failed = true;
            return View();
        }*/

        [HttpPost]
        public ActionResult Index(Models.Login request)
        {
            if (!ModelState.IsValid) return View(request);
            /*By confirming the ModelState valid property, MVC 5 look at all of the parameter types
             on this action method and any data annotation attributes to run those validation attributes.*/

            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                FormsAuthentication.SetAuthCookie(request.Username, false);
                return Redirect(FormsAuthentication.GetRedirectUrl(request.Username, false));
            }

            ViewBag.Failed = true;
            return View(request);
        }
    }
}