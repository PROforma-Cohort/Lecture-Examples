using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroToEF.Data;

/**
 * ORMS!!!
 * - Object Relationship Mapper
 * - High level Goal, as a C# Developer, I should not have to SQL to use a database
 * 
 * Entity Framework (EF) 
 *  - Interact with SQL Database
 *  - relies on LINQ 
 *  - relise on the POCO (Plain Old C# Object) 
 *  
 *  - DataContext
 *      - In Code Representation of the database
 *  
 *  Nuget
 *     - Package Manager for C# (.NET) 
 *     
 * 
 */
namespace IntroToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Query our database, Get All HairsStyles that have have Bangs
            var dbContext = new DataContext();

            //// INSERT 
            //var h1 = new HairStyles
            //{
            //    Bangs = true,
            //    Color = "brown",
            //    Name = "Classic",
            //    Price = 12.0m,
            //    TiedUp = false
            //};
            //dbContext.HairStyles.Add(h1);

            //var h2 = new HairStyles
            //{
            //    Bangs = false,
            //    Color = "brown",
            //    Name = "ponytail",
            //    Price = 12.0m,
            //    TiedUp = true
            //};
            //dbContext.HairStyles.Add(h2);

            //var h3 = new HairStyles
            //{
            //    Bangs = true,
            //    Color = "brown",
            //    Name = "bowl-cut",
            //    Price = 12.0m,
            //    TiedUp = false
            //};
            //dbContext.HairStyles.Add(h3);

            //var h4 = new HairStyles
            //{
            //    Bangs = true,
            //    Color = "blonde",
            //    Name = "beehive",
            //    Price = 20.0m,
            //    TiedUp = true
            //};
            //dbContext.HairStyles.Add(h4);

            //var h5 = new HairStyles
            //{
            //    Bangs = false,
            //    Color = "black",
            //    Name = "afro",
            //    Price = 20.0m,
            //    TiedUp = false
            //};
            //dbContext.HairStyles.Add(h5);

            // save all hairstyle to db
            dbContext.SaveChanges();

            // SELECT
            var hasBangs = dbContext.HairStyles.Where(w => w.Bangs == true);

            Console.WriteLine("These have bangs");
            foreach (var style in hasBangs)
            {
                Console.WriteLine(style.Name);
            }

            var countOfTiedUp = dbContext.HairStyles.Count(c => c.TiedUp);


            // SELECT ID, NAME
            // FROM HairStyles
            // WHERE Price < 15
            var cheapHairCuts = dbContext.HairStyles
                .Where(w => w.Price < 15)
                .Select(s => new { s.Name, s.Id });


            // Updating 

            // query to find it
            // update it
            // save it 

            // We want the duplicate for afro, and update it to be a mullet
            //var firstAfro = dbContext.HairStyles.First(f => f.Name == "afro");

            //firstAfro.Name = "mullet";
            //firstAfro.Price = 5.0m;
            //firstAfro.Color = "brown";

            //dbContext.SaveChanges();


            // Deletion
            // Query to find the object to delete
            // Remove it from database
            // delete it
            var mullet = dbContext.HairStyles.First(f => f.Name == "mullet");
            dbContext.HairStyles.Remove(mullet);
            dbContext.SaveChanges();



        }
    }
}
