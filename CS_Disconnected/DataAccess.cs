using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 
namespace CS_Disconnected
{
    public class DataAccess
    {
        SqlConnection Conn;
        SqlDataAdapter AdDept, AdEmp;
        DataSet Ds;

        public DataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=UCompany;Integrated Security=SSPI");
            Ds = new DataSet();
            AdDept = new SqlDataAdapter("Select * from Department", Conn);
            AdEmp= new SqlDataAdapter("Select * from Employee", Conn);
            // Ask the Adapter to use the Primary Key
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            FillData();
        }

        private void FillData()
        {
            // Fill Data into the DataSet
            AdDept.Fill(Ds, "Department");
            AdEmp.Fill(Ds, "Employee");
            // See Schema and Data from DataSet in Xml
            //Console.WriteLine($"Schema = {Ds.GetXmlSchema()}");
            Console.WriteLine($"Original Data = {Ds.GetXml()}");
        }

        public void CreateNewRecord()
        {
            try
            {
                // 1. Create a New Row Object based in Table in the DataSet
                DataRow DrNew = Ds.Tables["Department"].NewRow();
                // 2. Specify the Column Values
                DrNew["DeptNo"] = 90;
                DrNew["DeptName"] = "Administration";
                DrNew["Location"] = "Mumbai";
                DrNew["Capacity"] = 3400;
                // 3. Add this Record in Department Table of DataSet
                Ds.Tables["Department"].Rows.Add(DrNew);
                // 4. Create a Command Builder
                SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
                // 5. Update DataBase
                AdDept.Update(Ds, "Department");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error While Insert: {ex.Message}");
            }
        }


        public void UpdateRecord()
        {
            try
            {
                // 1. Find Record based on the Primary Key
                DataRow DrFind = Ds.Tables["Department"].Rows.Find(90);
                // 2. Update Its Values
                DrFind["DeptName"] = "Administration-Products";
                DrFind["Location"] = "Mumbai Andheri(West)";
                DrFind["Capacity"] = 1400;
                // Console.WriteLine($"Data = {Ds.GetXml()}");
                // 3. Create a Command Builder
                SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
                // 4. Update DataBase
                AdDept.Update(Ds, "Department");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error While Update: {ex.Message}");
            }
        }

        public void DeleteRecord()
        {
            try
            {
                // 1. Find Record based on the Primary Key
                DataRow DrFind = Ds.Tables["Department"].Rows.Find(90);
                // 2. Delete means Row will be marked for Deletion
                DrFind.Delete();
                Console.WriteLine($"Data After Delete from the DataSet = {Ds.GetXml()}");

                // 3. Create a Command Builder
                SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
                // 4. Update DataBase
                AdDept.Update(Ds, "Department");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error While Update: {ex.Message}");
            }
        }

    }
}
