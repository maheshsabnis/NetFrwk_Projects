using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Method");
            StringUtility utility = new StringUtility();
            string message = "I am Trainer for .NET Framework";
            Console.WriteLine($"Upper Case for {message} = {utility.ChangeCase(message, 'u')}");
            Console.WriteLine($"Lower Case for {message} = {utility.ChangeCase(message, 'l')}");
            Console.WriteLine($"Length of {message} = {utility.GetLength(message)}");
            Console.WriteLine($"Reverse of {message} = {utility.Reverse(message)}");
            Console.WriteLine("Using an extension for standard string class");
            Console.WriteLine();
            Console.WriteLine($"Reverse of {message} = {message.ReverseString()}");
            Console.ReadLine(); 
        }
    }
}
