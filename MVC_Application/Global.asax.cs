using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_Application
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Code for Registering
        /// 1. ActionFilters for All Controllers and hence their action methods
        /// 2. Creating Route Table for Controllers and its Action Method
        /// 3. Bundling the JS and CSS files
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            // Global Filter Registration
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
