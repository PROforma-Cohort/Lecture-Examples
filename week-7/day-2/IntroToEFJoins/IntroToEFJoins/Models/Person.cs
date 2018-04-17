using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEFJoins.Models
{
    /*
       - 1 Person lives at address
       - Many People can live at the same address 
         */

    /**
     * a Person Can Onw Many Cars
     * Car Can be own by Many People
     */

    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }

        // 1 to many
        public int? AddressId { get; set; }
        public Address Address { get; set; }

        // 
        public ICollection<Car> Car { get; set; } = new HashSet<Car>();

    }
}
