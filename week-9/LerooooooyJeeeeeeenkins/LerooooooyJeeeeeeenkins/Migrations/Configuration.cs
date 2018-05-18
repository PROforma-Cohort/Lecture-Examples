namespace LerooooooyJeeeeeeenkins.Migrations
{
    using LerooooooyJeeeeeeenkins.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LerooooooyJeeeeeeenkins.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LerooooooyJeeeeeeenkins.AuthContext context)
        {

            var restaurant = new Restaurant { Name = "DISSS", PhoneNumber = "813-867-5309" };

            context.Restaurants.AddOrUpdate(a => a.Name, restaurant);
            context.SaveChanges();

            var categories = new List<Category>
            {
                new Category{Name="Starters"},
                new Category{Name="Entrees"},
                new Category{Name="Sweets"},
                new Category{Name="Drinks"},
            };

            categories.ForEach(cat => context.Categories.AddOrUpdate(i => i.Name, cat));
            context.SaveChanges();

            var seedPrice = 8;
            var menuItems = new List<MenuItem>
            {
                new MenuItem {Restaurant = restaurant, Category = categories[0], Name = "Poppers", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[0], Name = "Nachos", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[1], Name = "Chicken", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[1], Name = "Steak & Eggs", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[2], Name = "Pie", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[2], Name = "Cake", Price = seedPrice + new Random().Next(0,3) },
                new MenuItem {Restaurant = restaurant,Category = categories[3], Name = "Vanilla Shake", Price = seedPrice + new Random().Next(0,3) },
            };

            menuItems.ForEach(item => context.MenuItems.AddOrUpdate(i => i.Name, item));
            context.SaveChanges();


        }
    }
}
