using ShoeAPI.Data;
using ShoeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace ShoeAPI.Controllers
{
    [Route("api/shoes")]
    public class ShoeController : ApiController
    {
        public IEnumerable<Shoe> GetAll()
        {
            Func<Shoe, bool> IsSomethingAThing = x => true;

            // get all shoes fro mthe database
            var db = new ShoeContext();
            return db.Shoes.Where(IsSomethingAThing);
        } 
    }
}
