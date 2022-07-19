using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Using_StoredProcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Stored Procs");
            DepartmentDataAccess ds = new DepartmentDataAccess();
            ds.GetAllDepartments();
            Console.WriteLine();
            Console.WriteLine();
            // ds.InsertDepartment();
            ds.GetSumSalaryByDeptNo();
            Console.WriteLine();
            ds.InsertDepartmentParameterizedQueries();
            Console.ReadLine();
        }
    }
}
