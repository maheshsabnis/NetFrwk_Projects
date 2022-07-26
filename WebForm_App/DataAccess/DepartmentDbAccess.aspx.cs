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

        protected void gvDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            // read the cells collection for a selected row
            var cells = gvDept.SelectedRow.Cells;
            // show data in text boxes
            txtdno.Text = cells[0].Text;
            txtdname.Text = cells[1].Text;
            txtloc.Text = cells[2].Text;
            txtcap.Text = cells[3].Text;
        }

        /// <summary>
        /// Indicate that the Current Row is Ready to Update
        /// This will replace the Edit button by Update and Cancel buttons
        /// The Current selected row for edit will be editable i.e. Cells will be replaced by TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvDept_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // The Row at the selected index will be editable
            gvDept.EditIndex = e.NewEditIndex;


            // read the cells collection for a selected row
            var cells = gvDept.Rows[e.NewEditIndex].Cells;
            // show data in text boxes
            txtdno.Text = cells[0].Text;
            txtdname.Text = cells[1].Text;
            txtloc.Text = cells[2].Text;
            txtcap.Text = cells[3].Text;

            LoadData();
        }

        /// <summary>
        /// GridViewUpdateEventArgs: This will provide the RowIndex that is being updated  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvDept_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                // 1. Read Cell Value
                // a. Read the DeptNo
                Department dept = new Department();
                dept.DeptNo = Convert.ToInt32(gvDept.Rows[e.RowIndex].Cells[0].Text);
                // b. Read Controls collection that is present inside the Editable Cell of Selected
                // Row

                dept.DeptName = (gvDept.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
                dept.Location = (gvDept.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
                dept.Capacity = Convert.ToInt32((gvDept.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text);

                // 2. Update
                deptDbAccess.Update(dept.DeptNo, dept);
                // 3. Remove the Edit effect
                gvDept.EditIndex = -1;
                LoadData();
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void gvDept_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Removed  the Edit effect on the Row and Make it ReadOnly
            gvDept.EditIndex = -1;
            LoadData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvDept_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // REad the DeptNo for selected row when the 'Delete' buton is clicked
                var deptno = Convert.ToInt32(gvDept.Rows[e.RowIndex].Cells[0].Text);
                // Delete the Record
                deptDbAccess.Delete(deptno);
                LoadData();
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        /// <summary>
        /// Code for Pagination to move across pages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvDept_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //  based on the Paginition the The no. of Records to be shown will be displayed for the next page
            gvDept.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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

                deptDbAccess.Update(dept.DeptNo,dept);
                LoadData();
                lblstatus.Text = "New Department is Created Successfully...";
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }
    }
}