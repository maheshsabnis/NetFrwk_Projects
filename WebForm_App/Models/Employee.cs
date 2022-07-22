using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_App.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptId { get; set; }
    }

    public class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "A", DeptId = "IT" });
            Add(new Employee() { EmpNo = 2, EmpName = "B", DeptId = "HRD" });
            Add(new Employee() { EmpNo = 3, EmpName = "C", DeptId = "TRG" });
            Add(new Employee() { EmpNo = 4, EmpName = "D", DeptId = "AC" });
            Add(new Employee() { EmpNo = 5, EmpName = "E", DeptId = "TRG" });
            Add(new Employee() { EmpNo = 6, EmpName = "F", DeptId = "AD" });
            Add(new Employee() { EmpNo = 7, EmpName = "G", DeptId = "IT" });
            Add(new Employee() { EmpNo = 8, EmpName = "H", DeptId = "HRD" });
            Add(new Employee() { EmpNo = 9, EmpName = "I", DeptId = "TRG" });
            Add(new Employee() { EmpNo = 10, EmpName = "J", DeptId = "AC" });
        }
    }
}