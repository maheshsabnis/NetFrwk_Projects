using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events_Lambda
{
    // 1. Define a Delegate
    public delegate double OperationHandler(double a, double b);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Understanding Delegate and Lambda Expressions");
            // The C# Traditional Method call
            var result = RaisedTo(5, 8);
            Console.WriteLine($" 8 raised to 5 is = {result}");
            Console.WriteLine();
            Console.WriteLine("Using Delegate to Invoke the method");
            // 2. Create a delegate instance and pass tye method address to it
            // Just a method name will read its address from Code-Segment
            // C# 3.0 When a Method address is passed to delegate instance
            // the delegate instance encasulate the method implementation in it
            OperationHandler handler = new OperationHandler(RaisedTo);
            // 3. Invoke the method by passing parameters to the delegate instance
            //  var powerResult = handler.Invoke(8, 5);
            var powerResult = handler(8, 5); // Invoke method will be called implicitly
            Console.WriteLine($" 5 raised to 8 is  = {powerResult}");
            Console.WriteLine();

            Console.WriteLine("Pass the Delegate to a Bridge method");
            Bridge(handler);
            Console.WriteLine();
            Console.WriteLine("Define any implementation for the delegate and pass to the method ");
            //C# 2.0 a delegate that store an anonymous implementation (aks Anonymous Method )in it
            OperationHandler handler1 =  delegate (double a, double b) { return a * b + 400; };
            Bridge(handler1);
            Console.WriteLine();
            Console.WriteLine("C# 3.0 a Lambda Expression");
            OperationHandler handler2 = (double x, double y) => { return Math.Pow(x, y); }; 
            Bridge(handler2);
            // OR, directly pass the Lambda Expression to a method
            Console.WriteLine();
            // x , y will be implicitly declared based on the Signeture of the delegate passed to Bridgr() method
            Bridge((x,y)=>Math.Pow(x,y));



            Console.ReadLine();    
        }

        static double RaisedTo(double x,double y)
        {
            if (y == 0)
            {
                return 1;
            }
            return Math.Pow(x, y);
        }

        /// <summary>
        /// a method with delegate as its input parameter 
        /// </summary>
        /// <param name="operation"></param>
        static void Bridge(OperationHandler operation)
        {
            Console.WriteLine($"Result is = {operation(10,5)}");
        }
    }
}
