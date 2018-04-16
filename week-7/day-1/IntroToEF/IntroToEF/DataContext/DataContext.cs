using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF.Data
{
    // database of Hairstlyes
    // This is our database 
   public class DataContext : DbContext
    {
        public DataContext() :base("name=DefaultConnection")
        {

        }

        public DbSet<HairStyles> HairStyles { get; set; }

    }
}
