using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HPlus.Ecommerce
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() // This method fires when application first startup
        {
            AreaRegistration.RegisterAllAreas(); // Organizes related functionality in an MVC5 application into groups for routing and file organization purpose.
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); // App_Start/FilterConfig.cs
            RouteConfig.RegisterRoutes(RouteTable.Routes); // App_Start/RouteConfig.cs
            BundleConfig.RegisterBundles(BundleTable.Bundles); // // App_Start/BundleConfig.cs
        }
    }
}
