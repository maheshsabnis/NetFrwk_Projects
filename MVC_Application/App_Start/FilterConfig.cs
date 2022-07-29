using System.Web;
using System.Web.Mvc;
using MVC_Application.CustomFilters;

namespace MVC_Application
{
    public class FilterConfig
    {
        /// <summary>
        /// Register all Action Filters at Global aka Application Level
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Register HandleErrorAttribute Filter for Handling Exception
            filters.Add(new HandleErrorAttribute());
            // Register the LogFilter Globally
            filters.Add(new LogFilterAttribute());
        }
    }
}
