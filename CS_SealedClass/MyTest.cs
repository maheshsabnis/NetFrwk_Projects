using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SealedClass
{
    public sealed class MyTest
    {
        public void PrintMessage()
        {
            Console.WriteLine("I am Sealed Class");
        }
    }

    public class MyDeruve : MyTest
    { 
    }
}
