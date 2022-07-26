using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebForm_App.UserDefinedUI
{
    public partial class DbConnector : System.Web.UI.UserControl
    {
        SqlConnection Conn;
        SqlDataAdapter AdTable;
        DataSet Ds;

        // a Public Property that will be exposed by the User Control to the Page
        public DataTable DbTable { get; set; }
        // define an event that will be raised by the User Control but it will be subscribed
        // by the Page and the Data will be exposed by the User Control to the Page
        public event EventHandler ConnectionRequested; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlcrdentials_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            // Logic to connect to database

            // based on the Crdentials selected by the DropDownList define a Connection String
            if (ddlcrdentials.SelectedItem.Value == "0")
            {
                ViewState["ConnStr"] = $"Data Source={txtdbserver.Text.Trim()};Initial Catalog={txtdbname.Text.Trim()};Integrated Security=SSPI";
                txtuname.Text = "Administrator";
            }
            if (ddlcrdentials.SelectedItem.Value == "1")
            {
                //Enable UserName and PAssword TextBoxes
                txtuname.Enabled = true;
                txtpwd.Enabled = true;
                ViewState["ConnStr"] = $"Data Source={txtdbserver.Text.Trim()};Initial Catalog={txtdbname.Text.Trim()};User Id={txtuname.Text.Trim()};Password={txtpwd.Text.Trim()}";
            }


            Conn = new SqlConnection(ViewState["ConnStr"].ToString());
            Ds = new DataSet();
            AdTable = new SqlDataAdapter($"Select * from {txttablename.Text.Trim()}", Conn);
            AdTable.Fill(Ds, txttablename.Text.Trim());
            // Assing the Table from DataSet to TableName property of UserControl
            // SO that over the event it will be exposed to Page
            DbTable = Ds.Tables[txttablename.Text.Trim()];
            // Raise an event on the Control So that the Container Page will be 
            // Subscribing to it and receive data from Control
            if (ConnectionRequested != null)
            {
                // Raise on Current Object (this) with No Event Data
                // This will Make sure that all Public proeprties can be accesible
                // to the Page (Container)
                ConnectionRequested(this, EventArgs.Empty);
            }

            ViewState["ConnStr"] = "";
        }
    }
}