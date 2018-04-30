using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DrawingHat.Models
{
    public class HatContext :DbContext
    {
        public HatContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Groups> Groups { get; set; }
        public DbSet<People> People { get; set; }
    }
}