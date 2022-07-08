using System;
using System.Collections; 


namespace CS_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections");
            UsingArrayList();
            Console.ReadLine();
        }

        static void UsingArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add("Tejas");
            array.Add("Mahesh");
            array.Add("Sabnis");
            array.Add(10.20);
            array.Add(20.30);
            array.Add(30.40);
            array.Add('A');
            array.Add('B');
            array.Add('C');
            array.Add('D');
            Console.WriteLine("ENter the Type Name of the data you want to read from ArrayList");
            string type = Console.ReadLine();
            Print(array, type);
        }

        static void Print(ArrayList array, string type)
        {
            Console.WriteLine(array);
            foreach (object item in array)
            {
               
                // Console.WriteLine(item.GetType());
                switch (type)
                {
                    case "string":
                        // typeof() is an operator that is used to 
                        // extract the valid data type defined by .NET Farmework 
                        // The 'GetType()' method, will return the data-type of the data
                        if (item.GetType() == typeof(string))
                        {
                            Console.WriteLine("Value = " + item);
                        }
                        break;
                    case "int":
                        // typeof() is an operator that is used to 
                        // extract the valid data type defined by .NET Farmework 
                        // The 'GetType()' method, will return the data-type of the data
                        if (item.GetType() == typeof(int))
                        {
                            Console.WriteLine("Value = " + item);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
