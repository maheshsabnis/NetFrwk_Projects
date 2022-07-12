using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_EmployeeInfo.Models;
namespace CS_EmployeeInfo.Logic
{
    public class EmployeeLogic
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> UpdateEmployee(int empno,Employee employee)
        {
           // Logic for Update
            return employees;
        }

        public List<Employee> DeleteEmployee(int empno)
        {
            // Logic for Delete
            return employees;
        }

        public List<Employee> SearchEmployee(string dname)
        {
            // Logic for s3earch by danme
            return employees;
        }

    }
}
