using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Monkey : Mammal, IHowler
    {
        public void Howl()
        {
            Console.WriteLine("OOOO AHHHH");
        }
    }
}
