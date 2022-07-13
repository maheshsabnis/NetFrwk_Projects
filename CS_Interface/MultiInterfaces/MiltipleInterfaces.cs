using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.MultiInterfaces
{
    public interface IMath
    {
        int Add(int x, int y);
    }

    public interface INewMath
    {
        int Add(int x, int y);
    }


    public class Operation : IMath, INewMath
    {
        int IMath.Add(int x, int y)
        {
            return x + y;
        }

        int INewMath.Add(int x, int y)
        {
            return (x * x) + (y * y) + 2 * x * y;
        }
    }
}
