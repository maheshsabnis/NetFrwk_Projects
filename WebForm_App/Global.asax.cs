using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebForm_App
{
    public class Global : HttpApplication
    {
        /// <summary>
        /// The Execution Beginning of the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            // Creation of Route Table and Routes
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // Create a Build Bundle for jquery,bootstrap   
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Session_Start(object sender, EventArgs e)
        { 
           // declare bulk of Sessikon Object as per the choice
        }

        void Session_End(object sender, EventArgs e)
        {
            // Clear those object
        }
    }
}