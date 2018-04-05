using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
   const person = {
    name:"Pap", 
    age: 82
   }
     */


namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var gramps = new Person(new DateTime(1925, 3, 14), "Pap");
            var auntie = new Person(new DateTime(1968, 8, 13),"Annie");
            Console.WriteLine($"{gramps.Name} was born on {gramps.Birthday} and is {gramps.Age} y/o" );
            Console.WriteLine($"Aunite was born on {auntie.Birthday}");

            Console.WriteLine(gramps.GetGreeting());
            gramps.TakesNap();
            Console.WriteLine(gramps.GetGreeting());
            gramps.DenturesFallOut();
            Console.WriteLine(gramps.GetGreeting());

            if (gramps.HasHair)
            {
                Console.WriteLine("check out that hair");
            }
            else
            {
                Console.WriteLine("hand me some dome wax");
            }

            auntie.AdoptPet("Fido");

            var fam = new List<Person>();
            fam.Add(gramps);
            fam.Add(auntie);
            fam.Add(new Person(new DateTime(2017, 5, 5), "baby"));
            fam.Add(new Person(new DateTime(1999, 7, 20), "Prince"));

            // oldest
            var oldest = fam.Max(m => m.Age);
            // youngest
            var youngest = fam.Min(m => m.Age);
            // Count of people who can drink
            var drinkers = fam.Count(c => c.Age >= 21);
            // who can orderf rom over 55 Menu at Dennys
            var seniors = fam.Where(w => w.Age >= 55);
            foreach (var elder in seniors)
            {
                Console.WriteLine(elder.Name);
            }
            // who has a pet
            var petOwners = fam.Where(w => w.Pet != null);
            var familyPets = fam
                    .Where(w => w.Pet != null)
                    .Select(s => s.Pet);

        }
    }
}
