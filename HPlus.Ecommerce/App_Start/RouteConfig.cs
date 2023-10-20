/*
 Rountes in MVC are set of rules that the framework uses to map a URL 
requested by a browser into a specific controller and action method that will handle that request.
They are implemented as routing table which are a list of tables matched in a specific order from top to bottom. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HPlus.Ecommerce
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); /*Attribute Routing*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
                /*Here index is the default action. So, better to create Index.cshtml in view folder for each control view*/
            );
        }
    }
}
