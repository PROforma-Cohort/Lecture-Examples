using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPIRewview.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string GenreName { get; set; }
        public string YearPublished { get; set; }
    }
}