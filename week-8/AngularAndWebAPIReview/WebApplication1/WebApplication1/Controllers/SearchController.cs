using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Context;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class SearchController : ApiController
    {
        public IHttpActionResult Get(string title = null, string genre = null, string author = null)
        {
            try
            {
                var db = new LibraryContext();
                // if title == null return all books
                var query = db.Books.Include(i => i.Author).Include(i => i.Genre);
                if (!String.IsNullOrEmpty(title))
                {
                    query = query.Where(w => w.Title.Contains(title));
                }

                if (!String.IsNullOrEmpty(genre))
                {
                    query = query.Where(w => w.Genre.Name.Contains(genre));
                }
                if (!String.IsNullOrEmpty(author))
                {
                    query = query.Where(w => w.Author.FullName.Contains(author));
                }
                var results = query.ToList();
                if (results.Count == 0)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(results);
                }

            }
            catch (ArgumentNullException ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
