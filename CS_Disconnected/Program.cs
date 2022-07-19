using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Disconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DisConnected Architecture");
            DataAccess da = new DataAccess();
            // da.CreateNewRecord();
            // da.UpdateRecord();
             //da.DeleteRecord();
            Console.ReadLine();
        }
    }
}
