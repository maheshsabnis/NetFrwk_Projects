using System;
using System.Collections.Generic;
 

namespace CS_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Generics");
            UsingStringList();
            Console.ReadLine();
        }

        static void UsingIntList()
        {
            List<int> lstInt = new List<int>();
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);
            lstInt.Add(40);
        }

        static void UsingStringList()
        {
            List<string> lstStr = new List<string>();
            lstStr.Add("Mahesh");
            lstStr.Add("Mukesh");
            lstStr.Add("Manish");
            lstStr.Add("Mohan"); 
            lstStr.Add("Mandar");
            lstStr.Add("Mohit");
            lstStr.Add("Manohar");
            lstStr.Add("Madhanv");
            lstStr.Add("Manoj");
            lstStr.Add("Makrand");

            foreach (string str in lstStr)
            {
                if (str.Length > 5)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
