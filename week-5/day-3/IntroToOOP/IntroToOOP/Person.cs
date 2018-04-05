using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{

    /*
     class blue print:
        Name (person)
        properties (values) 
        methods(actions) 
        contructor (initilazation)
         */
    /* CS IDEA: 
        data encapuslation 
        data abstraction 
      */  
    class Person
    {
        // Full Property
        private bool _doesHaveHair;

        public bool HasHair
        {
            get { return _doesHaveHair; }
            set
            {
                if (Age > 70)
                {
                    _doesHaveHair = false;
                }
                else
                {
                    _doesHaveHair = value;
                }

            }
        }

        // "Normal" Property
        public string Name { get; set; }
        // "Read" Only
        public double Age
        {
            get
            {
                var _days = DateTime.Now.Subtract(Birthday).Days;
                return _days / 365.25;
            }
        }
        public DateTime Birthday { get; set; }
        private Mood Mood { get; set; } = Mood.INDIFFERENT;

        public Pets Pet { get; set; }

        // Constructors
        public Person()
        {
            Console.WriteLine("Person created without Birthday");
        }
        
        // Constructors
        public Person(DateTime birthday, string name)
        {
            Birthday = birthday;
            // calculate age
            Name = name;
            Console.WriteLine("Person was constructed");
        }


        public void AdoptPet(string name)
        {
            Pet = new Pets();
            Pet.Name = name;
            Mood = Mood.HAPPY;
        }

        public void TakesNap()
        {
            Mood = Mood.HAPPY;
        }

        public void DenturesFallOut()
        {
            Mood = Mood.HAPPY;
        }
        public string GetGreeting()
        {
            if (Mood == Mood.HAPPY)
            {
                return "Hey there!";
            }
            else if (Mood == Mood.HAPPY)
            {
                return "get off my lawn!";
            } else
            {
                return "Back in my day....";
            }
        }
    }
}
