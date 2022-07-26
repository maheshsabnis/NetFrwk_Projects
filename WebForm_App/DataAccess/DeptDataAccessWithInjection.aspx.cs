using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.Entities;
using Application.DataAccess;
using Unity.Attributes;

namespace WebForm_App.DataAccess
{
    public partial class DeptDataAccessWithInjection : System.Web.UI.Page
    {
        // 1. Lets Inject the DepartmentDataAccess Dependency to the Page using Constructor
        // 
        private IDataAccess<Department, int> deptDbAccess;

        ///// <summary>
        ///// Inject
        ///// </summary>
        public DeptDataAccessWithInjection(IDataAccess<Department, int> dbAccess)
        {
            this.deptDbAccess = dbAccess;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void gvDept_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvDept_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void gvDept_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gvDept_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvDept_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gvDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            gvDept.DataSource = deptDbAccess.Get();
            gvDept.DataBind();
        }
    }
}