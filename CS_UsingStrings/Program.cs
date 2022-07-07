using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_UsingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Strings");
            string name = "Mahesh Rameshrao Sabnis";
            Console.WriteLine("Original String = " + name);
            // 1. Convert the string in Upper Case
            string strUpper = name.ToUpper();
            Console.WriteLine("Upper Case " + strUpper);

            // 2. Convert To Lower case
            Console.WriteLine("To Lower case = " + name.ToLower());

            // 3. Get length of string
            Console.WriteLine("Length = " + name.Length);

            // 4. Find out First index of 'm' in the string
            Console.WriteLine("First occurance of  'm'  at index = " + name.IndexOf('m'));

           

            Console.ReadLine();
        }
    }
}
