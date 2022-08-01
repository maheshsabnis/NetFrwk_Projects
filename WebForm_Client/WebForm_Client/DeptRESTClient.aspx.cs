using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Application.Entities;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace WebForm_Client
{
    public partial class DeptRESTClient : System.Web.UI.Page
    {
        HttpClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            if (!IsPostBack)
            { 
                LoadData();
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtdno.Text = 0.ToString();
            txtdname.Text = "";
            txtloc.Text = "";
            txtcap.Text = 0.ToString() ;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                client.PutAsync("https://localhost:44365/api/Department/{id}");
                client.DeleteAsync("https://localhost:44365/api/Department/{id}")
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
              //  client.DefaultRequestHeaders.Add("Content-Type", "application/json");

                // Deseriaize the Department Object in the JSON form
                Department department = new Department()
                {
                     DeptNo = Convert.ToInt32(txtdno.Text),
                     DeptName = txtdname.Text,
                     Location = txtloc.Text,
                     Capacity= Convert.ToInt32(txtcap.Text)
                };

                var jsonData = JsonConvert.SerializeObject(department);
                // Create aString HTTP Content
                var stringDataToPost = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = client.PostAsync("https://localhost:44365/api/Department",stringDataToPost).Result;

                

                lblstatus.Text = response.Content.ReadAsStringAsync().Result;
                LoadData();
            }
            catch (Exception ex)
            {
                lblstatus.Text = $"Error Occurred {ex.Message}";
            }
        }

        private void LoadData()
        {
            // Get the data
            var stringResponse = client.GetStringAsync("https://localhost:44365/api/Department").Result;
            // Conveert the response from String to List of Departments
            // Using NetwonSoft Package and access its JsonSerializer Class
            List<Department> departments = JsonConvert.DeserializeObject<List<Department>>(stringResponse);
            gvDept.DataSource = departments;
            gvDept.DataBind();
        }
        
    }
}