using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.Entities;
using Application.DataAccess;


namespace WebForm_App.DataAccess
{
    public partial class DepartmentDbAccess : System.Web.UI.Page
    {
        IDataAccess<Department, int> deptDbAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            deptDbAccess = new DepartmentDataAccess();
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtdno.Text = 0.ToString();
            txtdname.Text = String.Empty;
            txtloc.Text = String.Empty;
            txtcap.Text = 0.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department()
                {
                     DeptNo = Convert.ToInt32(txtdno.Text),
                     DeptName = txtdname.Text,
                     Location = txtloc.Text,
                     Capacity = Convert.ToInt32(txtcap.Text)
                };

                deptDbAccess.Craete(dept);
                LoadData();
                lblstatus.Text = "New Department is Created Successfully...";

            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        private void LoadData()
        {
            gvDept.DataSource = deptDbAccess.Get();
            gvDept.DataBind();
        }
    }
}