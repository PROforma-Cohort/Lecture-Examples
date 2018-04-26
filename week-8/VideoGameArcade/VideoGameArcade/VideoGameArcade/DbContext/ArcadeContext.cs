using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VideoGameArcade.Models;

namespace VideoGameArcade.DataContext
{
    public class ArcadeContext: DbContext
    {
        public ArcadeContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Game> ArcadeGames { get; set; }
    }
}