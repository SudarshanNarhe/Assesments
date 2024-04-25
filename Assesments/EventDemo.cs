using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{   
  //access signtaure returntype(same as method)   delegatename 
    public delegate void Bankdelegate();
    public class Bank
    {
        private double balance;

     //access evensignature  delegatename  eventname
        public event Bankdelegate LowBalance;

        public Bank()
        {
            balance = 5000;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                LowBalance();
            }
            else
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Balance is : {balance}";
        }
    }

    public class MyMessage
    {
        public void BalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }

    }
}
