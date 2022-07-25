using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_App.ContorlsDemo
{
    public partial class SessionSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Define a Session Object and store data in it
            Session["DeptId"] = ddlDepartments.SelectedValue;
        }
    }
}