using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
using System.Data.SqlClient;
namespace Application.DataAccess
{
    public class DepartmentDataAccess : IDataAccess<Department, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        /// <summary>
        /// Instantiate the Connection Object
        /// </summary>
        public DepartmentDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=UCompany;Integrated Security=SSPI");
        }

        Department IDataAccess<Department, int>.Craete(Department entity)
        {
            Department department = new Department();
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Insert into Department Values({entity.DeptNo}, '{entity.DeptName}', '{entity.Location}', {entity.Capacity})";
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return department;
        }

        Department IDataAccess<Department, int>.Delete(int id)
        {
            Department department = null;
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Delete from Department where DeptNo={id}";
                int result = Cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    // create an empty Department object 
                    department = new Department();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return department;
        }

        IEnumerable<Department> IDataAccess<Department, int>.Get()
        {
            List<Department> departments = new List<Department>();
            try
            {
                // 1. Connecto to Database by opening it
                Conn.Open();
                // 2. Create Command Object
                Cmd = new SqlCommand();
                // 2.a. Pass the Connection top Command so that Command Know to which Database
                // the query will be fired
                Cmd.Connection = Conn;  
                // 3. Set the Command Type
                Cmd.CommandType = System.Data.CommandType.Text;
                // 4. Set the Command Text
                Cmd.CommandText = "Select * from Department";
                // 5. Execute the Command
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 6. Get Result by reading data from Reader object and put it in List<Department>
                // 6.a. Using While loop to start reading records from Reader from first record and so till end
                while (Reader.Read())
                {
                    // 6.b. Put each Row Value into the Department object 
                    departments.Add(new Department()
                    { 
                      DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                      DeptName = Reader["DeptName"].ToString(),
                      Location = Reader["Location"].ToString(),
                      Capacity = Convert.ToInt32(Reader["Capacity"])
                    });
                }
                // 6.c. Close the Reader so that tthe Cursor will be closed
                Reader.Close();


            }
            catch (Exception ex)
            {
                // 7. Throw exception, so that the caller app will kno about the error
                throw ex;
            }
            finally
            {
                // 8. If the try failed then catch will be executed which will throw the error
                // so Close the Connection, please do not keep it open
                Conn.Close();
            }
            return departments;
        }

        Department IDataAccess<Department, int>.Get(int id)
        {
            Department department = null;
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Select * from Department where DeptNo={id}";
                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    department = new Department()
                    {
                        DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                        DeptName = Reader["DeptName"].ToString(),
                        Location = Reader["Location"].ToString(),
                        Capacity = Convert.ToInt32(Reader["Capacity"])
                    };
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return department;
        }

        Department IDataAccess<Department, int>.Update(int id, Department entity)
        {
            Department department = new Department();
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Update Department Set DeptName ='{entity.DeptName}', Location='{entity.Location}', Capacity={entity.Capacity} where DeptNo={entity.DeptNo}";
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return department;
        }
    }
}
