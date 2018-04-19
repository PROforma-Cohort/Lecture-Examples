using ShoeAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoeAPI.Data
{
    public class ShoeContext:DbContext
    {
        public ShoeContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }


    }
}