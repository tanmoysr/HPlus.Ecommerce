using HPlus.Ecommerce.Filters;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute()); // default error handler
            filters.Add(new CustomExceptionHandler()); // Customized error handler
            filters.Add(new LogRequestFilter()); // Customized class from the Filter folder. The Filter folder itself is customized.
        }
    }
}
