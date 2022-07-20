using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebForm_App
{
    /// <summary>
    /// Class that is used to define Route
    /// </summary>
    public static class RouteConfig
    {
        /// <summary>
        /// Register the Route Expression in RouteTable and will update the RouteTable
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
