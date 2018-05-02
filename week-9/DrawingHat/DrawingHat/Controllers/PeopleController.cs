using DrawingHat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrawingHat.Controllers
{
    public class PeopleController : ApiController
    {
        [HttpGet]
        [Route("api/people")]
        public IHttpActionResult GetAllPeople()
        {
            using (var db = new HatContext())
            {
                var rv = db.People.OrderBy(o => o.Name).ToList();
                return Ok(rv);
            }
        }


        [HttpPost]
        [Route("api/people")]
        public IHttpActionResult AddPerson([FromBody]People person)
        {
            using(var db = new HatContext())
            {
                db.People.Add(person);
                db.SaveChanges();
                return Ok(person);
            }
        }

        [HttpDelete]
        [Route("api/people/{id}")]
        public IHttpActionResult DeletePerson([FromUri] int id)
        {
            using(var db = new HatContext())
            {
                var person = db.People.SingleOrDefault(s => s.Id == id);
                if (person == null) return NotFound();
                db.People.Remove(person);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
