using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Simple_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Polymorphism");

            Gateway gateway = new Gateway();   

            // Create an instance for the reference of the Shape Abstract class using its derived class
            Shape s = new Traingle(100,200); // Compile Time 
            gateway.PrintArea(s);

            s = new Circle(0,0);
            ((Circle)s).SetRadious(100); // Casting the BAse class to Derive class (Down-Casting)
            gateway.PrintArea(s);
            



            Console.ReadLine();   
        }
    }
}
