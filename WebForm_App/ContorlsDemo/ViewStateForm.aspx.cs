using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_App.ContorlsDemo
{
    public partial class ViewStateForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            // Savbe Data in Key:Value Pair
            ViewState["message"] = txtmessage.Text;
            txtmessage.Text = "";
        }

        protected void bnGet_Click(object sender, EventArgs e)
        {
            txtmessage.Text = ViewState["message"].ToString();
        }
    }
}