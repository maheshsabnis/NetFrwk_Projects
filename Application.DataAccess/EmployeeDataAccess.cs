using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
namespace Application.DataAccess
{
    public class EmployeeDataAccess : IDataAccess<Employee, int>
    {

        SqlConnection Conn;
        SqlCommand Cmd;
        public EmployeeDataAccess()
        {
            Conn = new SqlConnection("Data Source=.;Initial Catalog=UCompany;Integrated Security=SSPI");
        }
        Employee IDataAccess<Employee, int>.Craete(Employee entity)
        {
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Insert into Employee Values({entity.EmpNo}, '{entity.EmpName}', '{entity.Designation}', {entity.Salary}, {entity.DeptNo})";
                Cmd.ExecuteNonQuery();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        Employee IDataAccess<Employee, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IDataAccess<Employee, int>.Get()
        {
            List<Employee> Employees = new List<Employee>();
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Select EmpNo,EmpName,Designation,Salary, DeptNo  from Employee";
                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Employees.Add(new Employee() 
                    {
                       EmpNo = Convert.ToInt32(Reader["EmpNo"]),
                       EmpName = Reader["EmpName"].ToString(),
                       Designation = Reader["Designation"].ToString(),
                        Salary = Convert.ToInt32(Reader["Salary"]),
                        DeptNo = Convert.ToInt32(Reader["DeptNo"])
                    });
                }
                Reader.Close();
                return Employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        Employee IDataAccess<Employee, int>.Get(int id)
        {
            Employee Emp = null;
            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Select EmpNo,EmpName,Designation,Salary, DeptNo  from Employee";
                SqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Emp = new Employee()
                    {
                        EmpNo = Convert.ToInt32(Reader["EmpNo"]),
                        EmpName = Reader["EmpName"].ToString(),
                        Designation = Reader["Designation"].ToString(),
                        Salary = Convert.ToInt32(Reader["Salary"]),
                        DeptNo = Convert.ToInt32(Reader["DeptNo"])
                    };
                }
                Reader.Close();
                return Emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        Employee IDataAccess<Employee, int>.Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
