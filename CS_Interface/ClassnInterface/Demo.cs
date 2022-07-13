using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface.ClassnInterface
{

    public interface IMessage
    {
        void DisplayMessage(string msg);
    }

    public class MyBase
    {
        public void PrintMessage(string msg)
        {
            Console.WriteLine($"Print Message From Class = {msg}");
        }
    }

    public class MyDerive : MyBase, IMessage
    {
        void IMessage.DisplayMessage(string msg)
        {
            Console.WriteLine($"Display Message From Interface = {msg}");
        }
    }
}
