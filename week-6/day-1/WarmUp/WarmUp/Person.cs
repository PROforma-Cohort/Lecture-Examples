using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp
{
    class Person
    {
        public string Name { get; set; }
        public double AccountBalance { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello!!, My name is" + Name);
        }
    }
}
