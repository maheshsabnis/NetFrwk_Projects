using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SimpleAbstract
{
    public abstract class MathAbstract
    {
        public abstract int Add(int x, int y);
        public abstract int Subtract(int x, int y);
        public abstract int Multiplication(int x, int y);
    }


    public  class SimpleMath : MathAbstract
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
        public override int Subtract(int x, int y)
        {
            return x - y;
        }
        public override int Multiplication(int x, int y)
        {
            return x* y;
        }
    }


    public class SquareMath : MathAbstract
    {
        public override int Add(int x, int y)
        {
            return (x * x) + 2 *x*y + (y * y);
        }
        public override int Subtract(int x, int y)
        {
            return (x * x) - 2 * x * y + (y * y);
        }
        public override int Multiplication(int x, int y)
        {
            return (x * x) * 2 * x * y + (y * y);
        }
    }
}
