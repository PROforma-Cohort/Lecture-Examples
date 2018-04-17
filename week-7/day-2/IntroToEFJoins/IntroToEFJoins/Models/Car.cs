using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEFJoins.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string VIN { get; set; }
        public string Model { get; set; }

        public ICollection<Person> Owners { get; set; } = new HashSet<Person>();
    }
}
