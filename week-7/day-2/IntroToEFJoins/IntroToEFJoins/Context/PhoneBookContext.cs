using IntroToEFJoins.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEFJoins.Context
{
    class PhoneBookContext :DbContext
    {
        public PhoneBookContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
