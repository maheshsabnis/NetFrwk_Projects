using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_UsingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("In Try Block");
                Console.WriteLine("Enter a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a == 0 || b == 0)
                {
                    throw new Exception($"In division operands cannot be zero. In ypur case a = {a} and b  ={b}");
                }
                int z = a / b;
                Console.WriteLine($"Result  = {z}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occured {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Code Completed");
            }
            Console.ReadLine();
        }
    }
}
