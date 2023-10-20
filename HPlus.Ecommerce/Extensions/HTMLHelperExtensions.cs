using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc // Changed the namespace to match the namespace that the HTML Helper class itself comes from
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Copyright(this HtmlHelper helper)
        {
            return helper.Raw($"&copy; Tanmoy Chowdhury {DateTime.Now.Year}");
            // This prevents the string to be HTML encoded by MVC 5. Use return type as IHtmlString
        }
    }
}