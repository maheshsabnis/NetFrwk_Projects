using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ClassProperties
{
    public class Employee
    {
        private int _EmpNo;
        // Read-Write Property
        // Intelligent Fields
        public int EmpNo
        {
            get { 
              return _EmpNo;
            }
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Sorry this is an invalid value");
                }
                else
                {
                     _EmpNo = value;
                }
            }
        }
        private string _EmpName;
        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        public void Display()
        {
            Console.WriteLine($"EmpNo = {_EmpNo} and EmpName = {_EmpNo}");
        }
    }


    /// <summary>
    /// Class with Auto-Implemented properties
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
    }
}
