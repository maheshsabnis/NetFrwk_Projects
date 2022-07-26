using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

using Unity;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Application.DataAccess;
using Application.Entities;
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


            // 1. Create a Unity Container
            var container = new UnityContainer();

            // 2. Register All Dependencies
            // e.g. DepartmentDataAccess, EmployeeDataAccess

            container.RegisterType<IDataAccess<Department, int>, DepartmentDataAccess>();
            container.RegisterType<IDataAccess<Employee, int>, EmployeeDataAccess>();
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