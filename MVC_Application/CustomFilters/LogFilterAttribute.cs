using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Application.CustomFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        private void LogRequest(RouteData routeData, string currentState)
        {
            var controller = routeData.Values["controller"].ToString();
            var action = routeData.Values["action"].ToString();
            var log = $"Current state of execution is {currentState} with Controller request is {controller} and executing action name is {action}";
            Debug.WriteLine(log);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogRequest(filterContext.RouteData, "OnActionExecuting");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogRequest(filterContext.RouteData, "OnActionExecuted");
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogRequest(filterContext.RouteData, "OnResultExecuting");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogRequest(filterContext.RouteData, "OnResultExecuted");
        }
    }
}