using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IntroToAPI.Data
{
    public class MonstersContext :DbContext
    {
        public MonstersContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Models.Monster> Monsters { get; set; }
    }
}