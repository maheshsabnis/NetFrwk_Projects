using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_App.UserDefinedUI
{
    public partial class UserControlContainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Subscribe to an event explicitly
            DbConnector.ConnectionRequested += OnConnectionRequested;
        }

        protected void OnConnectionRequested(object sender, EventArgs args)
        {
            // Receive data from the Control
            gvTable.DataSource = DbConnector.DbTable;
            gvTable.DataBind();
        }
    }
}