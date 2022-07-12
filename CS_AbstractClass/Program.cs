using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Use of Abstract Class");
            
            Gateway gateway = new Gateway();

            Traingle traingle = new Traingle(10,20);
            Reactable reactable = new Reactable(100,200);
            Circle circle = new Circle(0, 0);
            circle.SetRadious(300);
            gateway.PrintArea(traingle); // Runtime will call CalculateArea() from Traingle class
            gateway.PrintArea(reactable); // Runtime will call CalculateArea() from Reactangle class

            gateway.PrintArea(circle);
            Console.ReadLine();
        }
    }
}
