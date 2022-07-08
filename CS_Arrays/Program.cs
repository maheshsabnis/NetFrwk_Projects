using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Arrays");
            // the array of integers with size as 10
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Value for " + i + "th index");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Records in Array");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Value at index " + i + " = " + arr[i]);
            //}
            // Implicitly startr reading from 0th index from array and 
            // advance (or move) next to the end of the array
            // This is known as 'Iteration'
            int index = 0;
            foreach (int record in arr)
            {
                Console.WriteLine(" Index  = " + index + "Record = " + record);
                index++;
            }
            // Initial value with Array Instance of int data type
            int[] arr1 = new int[arr.Length];

            foreach (int record in arr1)
            {
                Console.WriteLine("Record = " + record);
            }

            // copying arr to arr1
            Array.Copy(arr, arr1, arr.Length);
            Console.WriteLine("Data in New Array after Copying");
            foreach (int record in arr1)
            {
                Console.WriteLine(  "Record = " + record);
            }

            Console.ReadLine();
        }
    }
}
