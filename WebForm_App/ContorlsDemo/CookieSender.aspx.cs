using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_App.ContorlsDemo
{
    public partial class CookieSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Create a Cookie
            HttpCookie cookie = new HttpCookie("DeptId");
            // 2. Set the Value
            cookie["Dept_Id"] = ddlDepartments.SelectedValue;
            // 3. Set the Expoiry time for cookie
            cookie.Expires.AddMinutes(1);
            // 4. Request the server that when the response is generated then create a cookie
            Response.Cookies.Add(cookie);
            
        }
    }
}