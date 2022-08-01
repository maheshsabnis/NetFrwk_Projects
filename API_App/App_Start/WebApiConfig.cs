using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_App
{
    public static class WebApiConfig
    {
        /// <summary>
        /// The Method that will be used to create ROUTE Table for HTTP Requests
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // "api/{controller}/{id}"
            // controller: The API Controller class Name
            // id: This will be used to Read a Single Record or can also be used to search record on server
            // for Update and Delete Record Operations 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
