using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Mammal : Animal
    {
        public double LungCapicaity { get; set; }
        public bool HasHair { get; set; } = true;

        public void Breathe()
        {
            Console.WriteLine("Breathing with lung capicity: " + this.LungCapicaity );
        }
    }
}
