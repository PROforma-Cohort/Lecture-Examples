using IntroToAPI.Models;
using IntroToAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroToAPI.Controllers
{
    public class MonsterFactoryController : ApiController
    {
        public IHttpActionResult Post(Monster data)
        {
            var db = new MonstersContext();
            db.Monsters.Add(data);
            db.SaveChanges();
            return Ok(data);
        }
    }
}
