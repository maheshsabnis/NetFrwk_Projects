using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Class
{
    public class ClsEmployee
    {
        // private data members
        int EmpNo;
        string EmpName;
        decimal Salary;
        string DeptName;
        string Designation;

        public ClsEmployee()
        {
            Console.WriteLine("The Default Constructor Called");
        }
        // Lets initialize Private Memebers using Parameterized Constructor  
        // The COnstructor Overloading 
        public ClsEmployee(int eno, string ename, decimal sal, string dname, string desig)
        {
            EmpNo = eno;
            EmpName = ename;
            Salary = sal;
            DeptName = dname;
            Designation = desig;
        }  
        // Public Member
        public void Display()
        {
            Console.WriteLine("Employee Details");
            // C# 7.0+ String Interpolation, a new syntax to build a string object aka string Mutation
            Console.WriteLine($"{EmpNo} {EmpName} {Salary} {DeptName} {Designation}");
        }

        public void CalculateSalary(string desig)
        {
            if (desig == "Ds1")
            {
                Console.WriteLine($"For Ds1 Salary = {Salary + Salary * Convert.ToDecimal(0.02)}");
            }
            if (desig == "Ds2")
            {
                Console.WriteLine($"For Ds2 Salary = {Salary + Salary * Convert.ToDecimal(0.04)}");
            }
            if (desig == "Ds2")
            {
                Console.WriteLine($"For Ds3 Salary = {Salary + Salary * Convert.ToDecimal(0.06)}");
            }
        }

    }
}
