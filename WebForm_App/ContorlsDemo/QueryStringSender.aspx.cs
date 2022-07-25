using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_App.ContorlsDemo
{
    public partial class QueryStringSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = ddlDepartments.SelectedValue;
            // 1. Pass this value to QueryString
            var expression = $"DeptId={selectedValue}";
            // 2. Navigate to QueryStringReceiver.aspx with QueryString
            // QueryStringReceiver.aspx?DeptId=IT
            // Response.Redirect() will inform the WebServer to navidate to QueryStringReceiver.aspx page
            Response.Redirect($"QueryStringReceiver.aspx?{expression}");
        }
    }
}