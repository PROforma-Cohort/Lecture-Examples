using IntroToEFJoins.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IntroToEFJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PhoneBookContext();

            //var allAddress = db.Address.To
            var aaron = db.People.Include(i => i.Address).First(f => f.Id == 2);
            //aaron.Address = new Models.Address
            //{
            //    FullAddress = "123 Fakes"
            //};

            //var stPeteAddress = db.Addresses.Where(w => w.City == "St PEte");


            // assign a existing address to a new People
            // query for address
            var addressToAdd = db.Addresses.First(w => w.FullAddress == "123 Fakes");
            // create person
            var me = new Models.Person
            {
                FullName = "mark",
                AddressId = addressToAdd.Id, 
                Birthday = DateTime.Today
            };
            db.People.Add(me);


            me.Car.Add(new Models.Car
            {
                Make = "Honda",
                Model = "Car",

            });


            var meWithCars = db.People
                .Include(i => i.Car)
                .Include(i => i.Address)
                .First(f => f.FullName == "mark");
            
            db.SaveChanges();
        }
    }
}
