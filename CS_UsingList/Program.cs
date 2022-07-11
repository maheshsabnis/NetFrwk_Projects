using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_UsingList
{
    internal class Program
    {
        // Define a List that will be available for all methods in the program class
        static List<string> lstStrings = new List<string>();    
        static void Main(string[] args)
        {
            Console.WriteLine("Using List");

            string canContinue = "y";
            do
            {
                Console.WriteLine("1. Add Record in List");
                Console.WriteLine("2. Find a Record from List");
                Console.WriteLine("3. Print All Records from List");
                Console.WriteLine("Enter the Option");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter String that is to be added in list");
                        string value = Console.ReadLine();
                        lstStrings.Add(value);
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter record to search from List");
                        string rec = Console.ReadLine();
                        foreach (string val in lstStrings)
                        {
                            if (val == rec)
                            {
                                Console.WriteLine("Searched Record is found " + val + " On index " + lstStrings.IndexOf(val));
                                break;
                            }
                        }
                        break;
                    case 3:
                        foreach (string val in lstStrings)
                        {
                            Console.WriteLine(val);
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter y or Y to continue");
                canContinue = Console.ReadLine();
                Console.Clear(); // Clearing the Screen
            } while (canContinue == "y" || canContinue == "Y");
            Console.ReadLine();
        }
    }
}
