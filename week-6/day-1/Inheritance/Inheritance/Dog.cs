using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog :Mammal, IHowler
    {

        public string Size { get; set; } = "standard";
        public Dog()
        {
            this.LungCapicaity = 5;
        }

        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public void Howl()
        {
            Console.WriteLine("Hooooooooooooooooooooooooooooowwl");
        }
    }
}
