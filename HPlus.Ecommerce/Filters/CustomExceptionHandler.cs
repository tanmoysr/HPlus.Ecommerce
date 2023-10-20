using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Filters
{
    public class CustomExceptionHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var path = filterContext.HttpContext.Server.MapPath("/error/500.html");
            var bytes = System.IO.File.ReadAllBytes(path);
            filterContext.Result = new FileContentResult(bytes, "text/html");
            filterContext.ExceptionHandled = true;
        }
    }
}