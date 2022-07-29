
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Entities;
using Application.DataAccess;
using MVC_Application.CustomFilters;

namespace MVC_Application.Controllers
{
    // 3. rd eay for Exception Management at controller level
    // All action methods throws 'Exception' ExceptionType = typeof(Exception))
    // Go to Error View
    //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
    // Custom Filter at Controller Level
  //  [LogFilter]
    public class DepartmentController : Controller
    {
        IDataAccess<Department, int> deptDbAccess;
        /// <summary>
        /// Inject Dependnecy
        /// </summary>
        public DepartmentController(IDataAccess<Department,int> d)
        {
            deptDbAccess = d;
        }

        // GET: Department
        public ActionResult Index()
        {
            var departments = deptDbAccess.Get();
            // PAss the Departments Collection to View() method 
            // The departments List (IEnumerable<Department>) will be used 
            // to generate (Scaffold) Index.cshtml view
            // Right-CLick inside the action and select option 'Add View'
            return View(departments);
        }
        /// <summary>
        /// Http Get method for Scaffolding a vbiew for Creating a new Department
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var dept = new Department();
            return View(dept);
        }

        [HttpPost]

        public ActionResult Create(Department dept)
        {
            //try
            //{
                if (dept.DeptNo < 0) throw new Exception("DeptNo cannot be 0 or negative");
                deptDbAccess.Craete(dept);
                // Once the Save / Create is Succeful Redirect to Index Action
                return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{
            //    // Return to the Error View
            //    return View("Error", new HandleErrorInfo(
            //           ex, "Department", "Create"
            //        ) 
            //    );
            //}
        }
        /// <summary>
        /// A Common Exception method for all Action Methods
        /// </summary>
        /// <param name="filterContext"></param>
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    // Read the exception that is thrown
        //    Exception ex = filterContext.Exception;
        //    // Tell to Request processing that the exception is Handled so that the exception Handling Logic will be executed
        //    filterContext.ExceptionHandled = true;
        //    // Set the Error View ans Result
        //    // this.RouteData.Values["controller"].ToString(): Will Provide the 'controller' anme from the URL
        //    // this.RouteData.Values["action"].ToString(): Will Provide an action  name from URL
        //    ViewResult result = this.View("Error", new HandleErrorInfo(ex, this.RouteData.Values["controller"].ToString(), this.RouteData.Values["action"].ToString()));
        //    // Set this View Result to 'Result' property of the ExceptionCOntext

        //    filterContext.Result = result;
        //}

        public ActionResult Edit(int id)
        {
            // Get the Dept that is to be edited based on the 'id'
            var dept = deptDbAccess.Get(id);
            // pass the dept to edit to View
            return View(dept);
        }

        [HttpPost]
        public ActionResult Edit(int id, Department dept)
        { 
            deptDbAccess.Update(id, dept);
            // redirect to Index
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Show Details View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var dept = deptDbAccess.Get(id);
            return View(dept);
        }


        public ActionResult Delete(int id)
        {
            deptDbAccess.Delete(id);
            return RedirectToAction("Index");
        }
    }
}