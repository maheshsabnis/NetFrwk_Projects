using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Inheritence");
            
            Manager manager = new Manager(101, "Mahesh", 120000, "IT", 80000);
                                // GetSalary() method from the Manager class is called
                                // CompileTime
            Console.WriteLine($"Salary for Manager = {manager.GetSalary()}");
            
            Engineer engineer = new Engineer(102, "Tejas",520000, "IT", 80);
            Console.WriteLine($"Salary for Engineer = {engineer.GetSalary("Not STarted")}");
            // GetSalary() method from the SalesManager is called
            // CompileTime
            SalesManager salesManager = new SalesManager(103, "Leena", 45000, "HR", 25000, 15000, 10000);
            Console.WriteLine($"Salarr for Sales Manager = {salesManager.GetSalary()}");

            Console.ReadLine();
        }
    }
}
