// Syntax for imporing namespace for the current file
// so that all classes of that namespace will be accessible
using System;

namespace CS_Types_Conditions
{
    /// <summary>
    /// The EntryPoint class to the Application
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry Point Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Output Statement
            Console.WriteLine("Hello World!!!");
            // Local Variable Declarations inside a method
            int x, y, z;

            // Accept data for x and y from the End-User
            Console.WriteLine("Enter x");
            // Convert string-to-integer
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            // Convert string-to-integer
            y = Convert.ToInt32(Console.ReadLine());

            //z = x + y;
            //// Concatenate the string "z = " with integer z using + sign
            //Console.WriteLine("z = " + z);
            //// A Method Call
            //NoInputNoOutputMethod();
            //Multiply();

           


            int addRes = AddValues(x,y);
            Console.WriteLine("Addition = " + addRes);
            int subRes = SubstractValues(x, y);
            Console.WriteLine("Substraction = " + subRes);
            int multRes = MultiplyValues(x, y);
            Console.WriteLine("Multiplication = " + multRes);
            int divRes = DivideValues(x, y);
            Console.WriteLine("Division = " + divRes);


            int resultWitb0 = DivideValuesWithCheck(10, 0);
            Console.WriteLine("Result with 0 = " + resultWitb0);
            int resultWithout0 = DivideValuesWithCheck(100, 2);
            Console.WriteLine("Result without 0 = " + resultWithout0);
            int result = DivideValuesWithCheck(100, 22);
            Console.WriteLine("Result without 0 = " + result);


            double r1 = DivideWithDoubleResult(100, 22);
            Console.WriteLine("Result double = " + r1);


            // Input Statement
            Console.ReadLine();
        }


        static void NoInputNoOutputMethod()
        {
            Console.WriteLine("No Input Output Method is called");
        }

        static void Multiply()
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine("Multiplication result = " + result);
        }

        /// <summary>
        /// Method with input and output parameters
        /// a and b are formal parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AddValues(int a,int b)
        {
            int c = a + b;
            return c;
        }

        static int SubstractValues(int a, int b)
        {
            return a - b;
        }

        static int MultiplyValues(int a, int b)
        {
            return a * b;
        }
        static int DivideValues(int a, int b)
        {
            return a / b;
        }

        static int DivideValuesWithCheck(int a,int b)
        {
            if (b == 0) // if true the return 0
                return 0;

            return a / b;
        }
        /// <summary>
        /// Using 'double' because we want to receive result as floating point  
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double DivideWithDoubleResult(int x, int y)
        {
            double result = 0;
            // Casting the 'y' to double to get the correct numerical result
            result = Convert.ToDouble(x / (double)y);
            return result;
        }
    }
}
