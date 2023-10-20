using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HPlus.Ecommerce.Data;
using HPlus.Ecommerce.Data.Entities;

namespace HPlus.Ecommerce.Controllers
{
    [Authorize] // Tell MVC to check for a valid user before allowing access to this action. Attributes, Page 175
    public class AccountController : Controller
    {
        // GET: Accouont
        public ActionResult Index()
        {
            // return View();
            Customer customer = null;
            using (var ctx = new HPlusSportDbContext())
            {                
                //var user = ctx.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);
                var user = ctx.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);

                if (user != null)
                    customer = ctx.Customers.FirstOrDefault(c => c.CustomerID == user.CustomerId);

                return View(customer);
            }
        }
    }
}