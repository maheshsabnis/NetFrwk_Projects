using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Events
{
    // 1. Define a Delegate for Declaring Event 
    public delegate void TransactionHandler(double amount);

    public class Banking
    {
        // 2. Declare Events

        public event TransactionHandler OverBalance;
        public event TransactionHandler UnderBalance;

        private double NetBalance = 0;

        public Banking(double netBalance)
        {
            NetBalance = netBalance;
        }

        public void Deposit(double trAmount)
        {
            NetBalance += trAmount;
            //3. Raise Events Conditionally
            if (NetBalance > 100000)
            {
                // Raise to Execute the Subscription Logic
                OverBalance(NetBalance);
            }
        }
        public void Withdrawal(double trAmount)
        {
            NetBalance -= trAmount;
            //3. Raise Events Conditionally
            if (NetBalance < 5000)
            {
                UnderBalance(NetBalance);
            }
        }
        public double GetNetBalance()
        {
            return NetBalance;
        }
    }


    /// <summary>
    /// This classs will be used to Listen to Events those
    /// are raised by Banking class
    /// </summary>
    public class EventListener
    {
        // 1. Define Banking Reference
        Banking banking;
        // 2. Declare a Parameterized ctor that will accept Banking instance from the client
        // The State of the Transaction will be informed to the Client class
        // // so that if events are raised after the transaction is done then they will be notified
        public EventListener(Banking b)
        {
            banking = b;
            // 3. Subscribe to events so that notification can be send
            // Link Methods with event so that these methods
            // willbe invoked when an event is raised
            banking.OverBalance += Banking_OverBalance;
            banking.UnderBalance += Banking_UnderBalance;
        }

        /// <summary>
        /// Method that will generate Notification
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Banking_UnderBalance(double amount)
        {
            double amountLessToMinBalance = 5000 - amount;
            Console.WriteLine($"Dear Sir, you current balance is Rs.{amount} which is Rs.{amountLessToMinBalance} less that Minimum Balance of Rs.5000/-, so please maintain the Minimum operative balance.");
        }

        /// <summary>
        /// Method that will generate Notification
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Banking_OverBalance(double amount)
        {
            double taxableAmount = amount - 100000;
            double tax = taxableAmount * 0.2;
            Console.WriteLine($"Dear Sir your net Balance is Rs.{amount}/- which is Rs.{taxableAmount}/- more that Rs.100000, so please pay tax of Rs.{tax}/- immediately else I-T will catch you.");
        }
    }
}
