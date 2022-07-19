using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CS_Using_StoredProcs
{
    public class DepartmentDataAccess
    {
        SqlConnection Conn;
        SqlCommand Cmd;


        public DepartmentDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=UCompany;Integrated Security=SSPI");
        }

        public void GetAllDepartments()
        {
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection=Conn;
                // Inform the Command Object that the Stored Proc will be Invoked
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Pass the Name of the Stored Proc
                Cmd.CommandText = "sp_GetAllDepartments";
                // Use ExecureReader() because the SP is returning RecordSet
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"DeptNo = {reader["DeptNo"]}, DeptName = {reader["DeptName"]}, Location = {reader["Location"]}, Capacity = {reader["Capacity"]} ");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading all records: {ex.Message}");
            }
            finally
            {
                Conn.Close();
            }
        }


        public void InsertDepartment()
        {
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.CommandText = "sp_InsertDept";

                // Define Parameters Here
                SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.DbType = System.Data.DbType.Int32;
                pDeptNo.Direction = System.Data.ParameterDirection.Input;
                pDeptNo.Value = 201;

                SqlParameter pDeptName = new SqlParameter();
                pDeptName.ParameterName = "@DeptName";
                pDeptName.DbType = System.Data.DbType.String;
                pDeptName.Direction = System.Data.ParameterDirection.Input;
                pDeptName.Size = 200;
                pDeptName.Value = "Networking";

                SqlParameter pLocation = new SqlParameter();
                pLocation.ParameterName = "@Location";
                pLocation.DbType = System.Data.DbType.String;
                pLocation.Direction = System.Data.ParameterDirection.Input;
                pLocation.Size = 200;
                pLocation.Value = "Pune-East";

                SqlParameter pCapacity = new SqlParameter();
                pCapacity.ParameterName = "@Capacity";
                pCapacity.DbType = System.Data.DbType.Int32;
                pCapacity.Direction = System.Data.ParameterDirection.Input;
                pCapacity.Value = 400;

                // Add these parameters into the Parameters Collection of the SqlCommand Object
                Cmd.Parameters.AddRange(new SqlParameter[] { pDeptNo, pDeptName, pLocation, pCapacity });

                int Result = Cmd.ExecuteNonQuery();
                if (Result > 0)
                    Console.WriteLine("Insert is Successfull");
                else
                Console.WriteLine("Insert Failed");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading all records: {ex.Message}");
            }
            finally
            {
                Conn.Close();
            }
        }

        public void GetSumSalaryByDeptNo()
        {
            try
            {
                int DeptNo = 10;
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.CommandText = "sp_GetSumSalaryByDeptNoWithOutputParam";

                SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.DbType = System.Data.DbType.Int32;
                pDeptNo.Direction = System.Data.ParameterDirection.Input;
                pDeptNo.Value = DeptNo;

                Cmd.Parameters.Add(pDeptNo);

                SqlParameter pResultandSum = new SqlParameter();
                pResultandSum.ParameterName = "@ResultandSum";
                pResultandSum.DbType = System.Data.DbType.Int32;
                pResultandSum.Direction = System.Data.ParameterDirection.Output;

                Cmd.Parameters.Add(pResultandSum);
                // request to Execute the Stored Procedure
                var result = Cmd.ExecuteScalar();

                // Read the result from the Out Parameter

                int SumSalary = Convert.ToInt32(pResultandSum.Value);
                Console.WriteLine($"Sum of Salart by DeptNo = {DeptNo} is = {SumSalary}");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error for Reading Sum:{ex.Message} ");
            }
            finally
            {
                Conn.Close();
            }
        }



        public void InsertDepartmentParameterizedQueries()
        {
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Insert into Department Values(@DeptNo,@DeptName, @Location,@Capacity)";

                // Define Parameters Here
                SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.DbType = System.Data.DbType.Int32;
                pDeptNo.Direction = System.Data.ParameterDirection.Input;
                pDeptNo.Value = 202;

                SqlParameter pDeptName = new SqlParameter();
                pDeptName.ParameterName = "@DeptName";
                pDeptName.DbType = System.Data.DbType.String;
                pDeptName.Direction = System.Data.ParameterDirection.Input;
                pDeptName.Size = 200;
                pDeptName.Value = "Courier";

                SqlParameter pLocation = new SqlParameter();
                pLocation.ParameterName = "@Location";
                pLocation.DbType = System.Data.DbType.String;
                pLocation.Direction = System.Data.ParameterDirection.Input;
                pLocation.Size = 200;
                pLocation.Value = "Pune-West";

                SqlParameter pCapacity = new SqlParameter();
                pCapacity.ParameterName = "@Capacity";
                pCapacity.DbType = System.Data.DbType.Int32;
                pCapacity.Direction = System.Data.ParameterDirection.Input;
                pCapacity.Value = 20;

                // Add these parameters into the Parameters Collection of the SqlCommand Object
                Cmd.Parameters.AddRange(new SqlParameter[] { pDeptNo, pDeptName, pLocation, pCapacity });

                int Result = Cmd.ExecuteNonQuery();
                if (Result > 0)
                    Console.WriteLine("Insert is Successfull");
                else
                    Console.WriteLine("Insert Failed");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading all records: {ex.Message}");
            }
            finally
            {
                Conn.Close();
            }
        }
    }

}
