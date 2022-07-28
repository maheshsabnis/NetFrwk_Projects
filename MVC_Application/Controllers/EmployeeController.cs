using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Entities;
using Application.DataAccess;

namespace MVC_Application.Controllers
{
    public class EmployeeController : Controller
    {
        private IDataAccess<Employee, int> empDbAccess;
        private IDataAccess<Department, int> deptDbAccess;

        public EmployeeController(IDataAccess<Employee, int> empDbAccess, IDataAccess<Department, int> deptDbAccess)
        {
            this.empDbAccess = empDbAccess;
            this.deptDbAccess = deptDbAccess;
        }



        // GET: Employee
        public ActionResult Index()
        {
            var emps = empDbAccess.Get();
            return View(emps);
        }

        public ActionResult Create()
        {
            var Emp = new Employee();
            // Pass the Additional Data of the List of DeptName to the View, Use either ViewData or ViewBag (Dynamic Property)
            // viewBag will be runtime Compiled to ViewDataDictionary
                                    // This will be used to read the 'DeptNo' from the DropDown when the DeptName is selected
            ViewData["DeptNo"] = new SelectList(deptDbAccess.Get(), "DeptNo", "DeptName");
            return View(Emp);
        }
        [HttpPost]
        public ActionResult Create(Employee Emp)
        {
            // Check if the Model is Validated
            if (ModelState.IsValid)
            {
                // Add Record
                empDbAccess.Craete(Emp);
                return RedirectToAction("Index");
            }
            else
            {
                // return the same Create View with Error Messages on the Model Class Properties
                // Return the Create View
              ViewData["DeptNo"] = new SelectList(deptDbAccess.Get(), "DeptNo", "DeptName");
                return View(Emp);
            }
            
        }


        public JsonResult CheckIfEmpExist(int EmpNo)
        { 
            var emp = empDbAccess.Get(EmpNo);
            if (emp == null)
            {
                // Employee is noyt already exist
                // Valid
                return Json(true, JsonRequestBehavior.AllowGet); // Execute for HTTP Get Request
            }
            else
            {
                // Invalid
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}