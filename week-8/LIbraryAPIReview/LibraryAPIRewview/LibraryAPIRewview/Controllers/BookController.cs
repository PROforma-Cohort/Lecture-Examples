using LibraryAPIRewview.Context;
using LibraryAPIRewview.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;


namespace LibraryAPIRewview.Controllers
{
    public class BookController : ApiController
    {

        // GET all Books
        /*
            we want: 
            [{
                Title
                AuthorName
                YearPub
                GenreName
                Id
            },...]

            but we have :
            {
                Id,
                YearPub, 
                Title
                Author:{
                    FullName
                },
                Genre:{
                    Name:
            }


             */
        public IEnumerable<BookViewModel> Get()
        {
            // returns all books
            var db = new LibraryContext();
            var data = db.Books
                .Include(i => i.Author)
                .Include(i => i.Genre)
                .ToList();                   

            var rv = data.Select(book => new BookViewModel
            {
                BookName = book.Title,
                AuthorName = book.Author.FullName,
                GenreName = book.Genre.Name,
                YearPublished = book.YearPublished
            });
            return rv;
        }

    }
}
