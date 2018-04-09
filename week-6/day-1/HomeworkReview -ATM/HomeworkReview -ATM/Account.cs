using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview__ATM
{
    class Account
    {
        public double Balance { get; set; }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
