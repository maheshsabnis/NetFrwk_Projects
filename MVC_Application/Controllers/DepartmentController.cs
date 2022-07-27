
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Entities;
using Application.DataAccess;

namespace MVC_Application.Controllers
{
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
            deptDbAccess.Craete(dept);
            // Once the Save / Create is Succeful Redirect to Index Action
            return RedirectToAction("Index");
        }


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