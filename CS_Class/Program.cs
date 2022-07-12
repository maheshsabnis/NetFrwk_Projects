using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The First OOPs Demo");
            // define an instance of the class
            // This will invoke the default Constructor
            ClsEmployee emp = new ClsEmployee();
            // This will invoke Parameterized Constructor
            ClsEmployee emp1 = new ClsEmployee(101, "Mahesh", 123456, "IT", "Manager");

            List<ClsEmployee> lstEmp = new List<ClsEmployee>();

            lstEmp.Add(new ClsEmployee(101, "A", 12343, "D1", "Ds1"));
            lstEmp.Add(new ClsEmployee(102, "B", 22343, "D2", "Ds2"));
            lstEmp.Add(new ClsEmployee(103, "C", 32343, "D1", "Ds3"));
            lstEmp.Add(new ClsEmployee(104, "D", 42343, "D2", "Ds1"));
            lstEmp.Add(new ClsEmployee(105, "E", 53433, "D1", "Ds2"));

            foreach (ClsEmployee itemEmp in lstEmp)
            {
                itemEmp.Display();
                itemEmp.CalculateSalary("Ds1");
            }




            Console.ReadLine(); 
        }
    }
}
