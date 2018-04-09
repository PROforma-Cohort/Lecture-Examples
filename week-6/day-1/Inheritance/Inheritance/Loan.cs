using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Loan : Account
    {

        public override double Deposit(double amount)
        {
            this.Balance -= amount;
            return this.Balance;
        }
    }
}
