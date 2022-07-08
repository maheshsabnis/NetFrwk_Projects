using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Array Methods");
            int[] arr = new int[] { 10, 2, 4, 1, 6, 5, 7, 9, 8,3 };
            Array.Sort(arr); // This will sort the same array
            Print(arr);
            Array.Reverse(arr); // Thsi will Modify the Same Array
            Print(arr);
            Console.WriteLine();
            string[] names = new string[] { "James Bond", "Jason Bourn", "Ethan Hunt", "Indiana Jones", "Jack Reacher", "Jack Ryan" };
            Array.Sort(names);
            PrintStr(names);

            Console.ReadLine();
        }

        static void Print(int[] values)
        {
            foreach (int val in values)
            {
                Console.WriteLine("Record = " + val);
            }
        }

        static void PrintStr(string[] values)
        {
            foreach (string val in values)
            {
                Console.WriteLine("Record = " + val);
            }
        }
    }
}
