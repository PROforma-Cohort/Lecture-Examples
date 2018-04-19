using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
namespace ShoeAPI.Controllers
{

    public class SearchParams
    {
        public string Style { get; set; }
        public int? Size { get; set; }
        public string Color { get; set; }
    }

    public class SearchController : ApiController
    {
        // Complex Object for a GET
        [HttpGet]
        public IEnumerable<Models.Shoe> Search([FromUri]SearchParams param)
        {
            using (var db = new Data.ShoeContext())
            {
                var query = db.Shoes.Include(i => i.Size);

                if (!String.IsNullOrEmpty(param.Style))
                {
                    query = query.Where(w => w.Style == param.Style);
                }

                if (param.Size != null)
                {
                    query = query.Where(w => w.Size.UsSize == param.Size);
                }


                if (!String.IsNullOrEmpty(param.Color))
                {
                    query = query.Where(w => w.Color == param.Color);
                }

                return query.ToList();

            }
        }
    }
}
    

