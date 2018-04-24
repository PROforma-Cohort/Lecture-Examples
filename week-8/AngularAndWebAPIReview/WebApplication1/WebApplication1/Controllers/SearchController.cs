using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class SearchController : ApiController
    {

        public IHttpActionResult Get(string title)
        {
            try
            {
                var db = new LibraryContext();
                var results = db.Books.Where(w => w.Title.Contains(title)).ToList();
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
