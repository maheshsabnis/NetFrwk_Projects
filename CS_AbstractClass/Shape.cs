using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AbstractClass
{
    public abstract class Shape
    {
        protected double height, width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public virtual double CalculateArea()
        {
            Console.WriteLine("Method call from Abstract Class");
            return 0;
        }
    }

    public class Traingle : Shape
    {
        public Traingle(double h,double w):base(h,w)
        {
        }
        /// <summary>
        /// New Implementation by Overriding base class method
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            Console.WriteLine("Implementation for Area of Traingle");
            return (height * width / 2);
        }
    }

    public class Reactable : Shape
    {
        public Reactable(double h, double w):base(h,w)
        {
        }
        /// <summary>
        /// New Implementation by Overriding base class method
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            Console.WriteLine("Implementation for Area of Rectangle");
            return (height * width);
        }
    }

    public class Circle : Shape
    {
        double radiuos = 0;
        public Circle(double h, double w) : base(h, w)
        {
            radiuos = width / 2;
        }
       
        public void SetRadious(double r)
        {
            radiuos = r;
        }
        /// <summary>
        /// New Implementation by Overriding base class method
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            Console.WriteLine("Implementation for Area of Circle");
            return (Math.PI * radiuos * radiuos);
        }
    }


    /// <summary>
    /// Gateway classs to calculate the Area of 'Shape'
    /// </summary>
    public class Gateway
    {
        public void PrintArea(Shape shape)
        {
            // Dynamic Polymrpism is here
            double area = shape.CalculateArea();
            Console.WriteLine($"Area = {area}");
        }
    }
}
