using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Savings:Account
    {
        public double InterestRate { get; set; }

        public void CalculateInterest() { }
    }
}
