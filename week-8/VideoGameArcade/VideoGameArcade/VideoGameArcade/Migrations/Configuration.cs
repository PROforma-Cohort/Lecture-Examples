namespace VideoGameArcade.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VideoGameArcade.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoGameArcade.DataContext.ArcadeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VideoGameArcade.DataContext.ArcadeContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var donkeyKong = new Game
            {
                Title = "Donkey Kong",
                Rating = Rating.EVERYONE,
                ReleaseDate = new DateTime(1981, 7, 9)
            };

            var games = new List<Game>
            {
                donkeyKong,
                new Game {Title ="Mortal Kombat",Rating=Rating.MATURE, ReleaseDate = new DateTime(1992, 8, 9) },
                new Game{ Title= "Super Mario World", Rating = Rating.EVERYONE, ReleaseDate = new DateTime(1990,1, 8 )},
                new Game { Title = "Pokemon Red", Rating = Rating.EVERYONE, ReleaseDate = new DateTime(1996, 2, 13)}
            };

            games.ForEach(game =>
            {
                db.ArcadeGames.AddOrUpdate(a => a.Title, game);
            });

            db.SaveChanges();


        }
    }
}
