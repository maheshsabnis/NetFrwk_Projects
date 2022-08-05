using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core_MVCApp.Models;
using Core_MVCApp.DataAccess;
namespace Core_MVCApp.Controllers
{
    public class DeptController : Controller
    {
        IDataAccess<Department, int> deptds;
        public DeptController(IDataAccess<Department, int> deptds)
        {
            this.deptds = deptds;
        }


        // GET: DeptController
        public ActionResult Index()
        {
            var depts = deptds.Get(); 
            return View(depts);
        }

       

        // GET: DeptController/Create
        public ActionResult Create()
        {
            return View(new Department());
        }

        // POST: DeptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                deptds.Craete(department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(department);
            }
        }

        // GET: DeptController/Edit/5
        public ActionResult Edit(int id)
        {
            var dept = deptds.Get(id);
            return View(dept);
        }

        // POST: DeptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                deptds.Update(id,department);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

         
    }
}
