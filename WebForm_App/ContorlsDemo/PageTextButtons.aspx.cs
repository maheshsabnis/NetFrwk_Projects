using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_App.Models;

namespace WebForm_App.ContorlsDemo
{
    public partial class PageTextButtons : System.Web.UI.Page
    {
        Employees empDb;
        protected void Page_Load(object sender, EventArgs e)
        {
            empDb = new Employees();
            if (!IsPostBack)
            {
                gvEmployees.DataSource = empDb;
                // Inform the ASP.NET Engine (Server) to read each record from the DataSOurce
                // and Generate HTMl UI
                gvEmployees.DataBind();
            }

           
        }

        protected void txtname_TextChanged(object sender, EventArgs e)
        {
            lblName.Text = txtname.Text;
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Read the Selected Value and Text for the Selected Item from DropDownList
            lblSelDept.Text = $"Selected Value: {ddlDepartments.SelectedValue} and Selected Text: {ddlDepartments.SelectedItem.Text}";

            // Lets write a code to read Employees from empDb based on DeptName selected

            List<Employee> filteredEmployees = new List<Employee>();

            foreach (var emp in empDb)
            {
                if (emp.DeptId == ddlDepartments.SelectedValue)
                {
                    filteredEmployees.Add(emp);
                }
            }
            // Assing Filtered Employees to GridVeiw and Render it into HTML on the Page
            gvEmployees.DataSource = filteredEmployees;
            gvEmployees.DataBind();
        }
    }
}