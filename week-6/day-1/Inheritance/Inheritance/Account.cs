using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Account
    {
        public double Balance { get; set; }

        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }

        public virtual double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
    }
}
