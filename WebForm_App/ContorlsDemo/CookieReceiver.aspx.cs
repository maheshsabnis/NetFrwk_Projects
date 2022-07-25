using System;
using System.Collections.Generic;
using WebForm_App.Models;

namespace WebForm_App.ContorlsDemo
{
    public partial class CookieReceiver : System.Web.UI.Page
    {
        Employees empDb;
        protected void Page_Load(object sender, EventArgs e)
        {
            empDb = new Employees();

            if (!IsPostBack)
            {
                BindGrid(empDb);
            }
            // For all next requests filter data from the empDb
            // 1. Read data from Cookie, Tell the browser that read the Cookie File
            // and read data from it
            var cookie = Request.Cookies["DeptId"];
            if (cookie != null)
            {
                // Read the Data from the cookie object
                var DeptId = cookie["Dept_Id"].ToString();
                if (!String.IsNullOrEmpty(DeptId))
                {
                    // 2. Filter the data
                    var FilteredEmployees = new List<Employee>();
                    foreach (var emp in empDb)
                    { 
                        if (emp.DeptId == DeptId)
                        {
                            FilteredEmployees.Add(emp);
                        }
                    }
                    // 3. Bind Filtered Employees with GridView
                    BindGrid(FilteredEmployees);
                }
            }
            else
            {
                BindGrid(empDb);
            }
        }


        private void BindGrid(List<Employee> emps)
        {
            gvEmployees.DataSource = emps;
            gvEmployees.DataBind();
        }
    }
}