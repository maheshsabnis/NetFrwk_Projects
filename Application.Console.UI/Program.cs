using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
using Application.DataAccess;
namespace Application.UI
{
    internal class Program
    {
        static IDataAccess<Department, int> dsDept = new DepartmentDataAccess();
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Connected Architecture");
            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1. Read All Records");
            Console.WriteLine("2. Read Record by Primary Key");
            Console.WriteLine("3. Create New Record");
            Console.WriteLine("4. Update Exisitjng Record");
            Console.WriteLine("5. Delete Record");
            // Since the Console App access IDataAccess classses
            // Methods from these classes throws exception so please catch them here
            try
            {
                
                var Departments = dsDept.Get();
                PrintResults(Departments);
                Console.WriteLine();
                Console.WriteLine("Enter Department Details like follows");
                Console.WriteLine("DeptNo");
                Department department = new Department();
                department.DeptNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("DeptName");
                department.DeptName = Console.ReadLine();
                Console.WriteLine("Location");
                department.Location = Console.ReadLine();
                Console.WriteLine("Capacity");
                department.Capacity = Convert.ToInt32(Console.ReadLine());
                CreateDepartment(department);
                Departments = dsDept.Get();
                PrintResults(Departments);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred {ex.Message}");
            }
            Console.ReadLine();
        }

        static void PrintResults(IEnumerable<Department> depts)
        {
            Console.WriteLine("DeptNo   DeptName    Location    Capacity");
            foreach (var dept in depts)
            {
                Console.WriteLine($"{dept.DeptNo}   {dept.DeptName} {dept.Location} {dept.Capacity}");
            }
        }
        static void CreateDepartment(Department department)
        {
            dsDept.Craete(department);
        }
    }
}
