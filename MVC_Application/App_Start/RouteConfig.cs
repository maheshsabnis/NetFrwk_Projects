using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Application
{
    public class RouteConfig
    {
        /// <summary>
        /// This will Create  Route Table Entries for All Controllers and its Action Methods   
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Default Route
            // "{controller}/{action}/{id}", Router Expression 
            // The 'controller' the Controller Class Name
            // The 'action', the action method for the Controller Class
            // The 'id', the Route Parameter that will be used incase of Edit and Delete and Details
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                // Defaulut is for HomeController and Its action Method
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
