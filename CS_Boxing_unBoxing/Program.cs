using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Boxing_unBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demp Boxing and UnBoxing");
            int i = 10;
            object o = i; // Boxing
            Console.WriteLine("Type od data Stored in 'o' is = " + o.GetType() + " value of o is = " + o);

            int j = (int)o; // UnBoxing
            Console.WriteLine("Data after UnBoxing is = " + j);
            Console.ReadLine();
        }
    }
}
