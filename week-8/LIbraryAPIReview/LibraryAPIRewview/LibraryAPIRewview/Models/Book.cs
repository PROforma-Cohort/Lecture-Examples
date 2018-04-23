using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPIRewview.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public bool IsCheckedOut { get; set; } = false;
        public DateTime DueBackDate { get; set; }

        // author
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // genre
        public int GenreId { get; set; }
        public  Genre Genre { get; set; }
    }
}