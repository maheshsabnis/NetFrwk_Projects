using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Based Programming");
            Banking banking = new Banking(80000);
            // Pass the banking object so that if there are any notification, then they will 
            // be received
            EventListener eventListener = new EventListener(banking);

            banking.Deposit(50000);
            Console.WriteLine($"Net Balance After Deposit {banking.GetNetBalance()}");
            banking.Withdrawal(126000);
            Console.WriteLine($"Net Balance After Withdrawal {banking.GetNetBalance()}");
            Console.ReadLine();
        }
    }
}
