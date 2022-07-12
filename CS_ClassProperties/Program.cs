using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ClassProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using class Properties");
            Employee employee = new Employee();
            employee.EmpNo = -101; // call set
            employee.EmpName = "James"; // set
                                        // call get                     // call get
            Console.WriteLine($"EmpNo = {employee.EmpNo} and EmpName = {employee.EmpName}");

            Person person = new Person();
            person.PersonId = 100;
            person.PersonName = "ABS";
            Console.WriteLine($"{person.PersonId} and  {person.PersonName}");

            Console.ReadLine();
        }
    }
}
