using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using IntroToAPI.Data;
using IntroToAPI.Models;

namespace IntroToAPI.Controllers
{
    public class MonsterController : ApiController
    {
        public IEnumerable<Monster> Get()
        {
            var db = new MonstersContext();
            return db.Monsters.ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newMonster = new Monster
            {
                Name = name
            };
            var db = new MonstersContext();
            db.Monsters.Add(newMonster);
            db.SaveChanges();
            return Ok(newMonster);
        }
    }
}
