using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var poochy = new SaintBernard
            {
                Size = "Teacup"
            };


            var zoo = new List<Mammal>();
            zoo.Add(new Whale());
            zoo.Add(new Pug());
            zoo.Add(new SaintBernard());

            foreach(var animal in zoo)
            {
                animal.Breathe();
            }

            var pack = new List<Dog>
            {
                new SaintBernard(),
                new Pug(),
                new AmericanEskimo()
            };


            foreach (var dog in pack)
            {
                dog.Bark();
            }



            var howlers = new List<IHowler>();
            howlers.Add(new SaintBernard());
            howlers.Add(new Monkey());

            foreach(var howl in howlers)
            { 
                howl.Howl();
            }


            var check = new Checkings();
            var save = new Savings();
            //var account = new Account(); // nope, cause its abstract


        }
    }
}
