using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_App.Models;
namespace WebForm_App.ContorlsDemo
{
    public partial class QueryStringReceiver : System.Web.UI.Page
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
            // 1. Read data from QueryString
            if (Request.QueryString["DeptId"] != null)
            {
                var DeptId = Request.QueryString["DeptId"].ToString();
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