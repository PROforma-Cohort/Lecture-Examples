﻿using LibraryAPIRewview.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryAPIRewview.Context
{
    public class LibraryContext:DbContext
    {
        public LibraryContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author>Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}