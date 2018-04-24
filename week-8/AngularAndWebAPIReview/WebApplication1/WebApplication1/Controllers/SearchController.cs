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
            var db = new LibraryContext();
            var results = db.Books.Where(w => title.Contains(w.Title)).ToList();
            if (results.Count == 0)
            {
                return NotFound();
            } else
            {            
                return Ok(results);
            }
        }
    }
}
